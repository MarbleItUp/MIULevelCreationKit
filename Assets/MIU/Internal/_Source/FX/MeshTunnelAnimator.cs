using System.Collections.Generic;
using UnityEngine;

class TunnelMeshNote
{
    public float Time = 0.0f;
    public float SpeedScale = 1.0f;
    public GameObject MeshGO;
}

public class MeshTunnelAnimator : MonoBehaviour
{
    [Header("Spawn")]

    [Tooltip("Mesh to be spawned.")]
    public GameObject DisplayMesh;

    [Tooltip("If spawning in a line, # to be spawned; spread evenly along path.")]
    public int NumberToSpawn = 5;

    [Tooltip("If set, spawn meshes on a grid instead of a line.")]
    public bool SpawnOnGrid = false;

    [Tooltip("How many meshes to spawn along each grid axis.")]
    public Vector3Int GridSize = Vector3Int.one;

    [Tooltip("Enable motion lock.")]
    public bool EnableGridMotionLock = false;

    [Tooltip("Lock motion from this grid coordinate.")]
    public Vector3Int LockBoxMin = Vector3Int.zero;

    [Tooltip("Lock motion to this grid coordinate.")]
    public Vector3Int LockBoxMax = Vector3Int.zero;

    [Tooltip("Distance between meshes when in grid mode.")]
    public Vector3 GridSpacing = Vector3.one;

    [Tooltip("Override mesh material. If set replaces material on DisplayMesh's MeshRenderers.")]
    public Material OverrideMaterial;

    [Header("Cycles")]

    [Tooltip("Start all meshes at t=0.")]
    public bool SpawnWithZeroTime = false;

    [Tooltip("How long in seconds is a cycle?")]
    public float CycleTime = 5.0f;

    [Tooltip("Seconds randomly added to cycle time per mesh.")]
    public float SpeedVariance = 0.0f;

    [Tooltip("Randomly offsets progress per mesh at spawn.")]
    [Range(0.0f, 1.0f)]
    public float SpeedOffset = 0.0f;

    [Header("Motion")]

    [Tooltip("What is the location of items over time?")]
    public AnimationCurve Location = AnimationCurve.Linear(0, 0, 1, 1);

    [Tooltip("Direction and distance over which motion occurs.")]
    public Vector3 DirectionOfMotion = Vector3.forward;

    [Tooltip("Rotation over time in radians.")]
    public AnimationCurve Rotation = AnimationCurve.Linear(0, 0, 1, 0);

    [Tooltip("Direction about which rotation occurs.")]
    public Vector3 AxisOfRotation = Vector3.up;

    [Tooltip("Zero to one on the rotation curve corresponds to this many degrees.")]
    public float RotationScale = 360.0f;

    [Tooltip("Uniform scale over time.")]
    public AnimationCurve Scale = AnimationCurve.Linear(0, 1, 1, 1);

    [Tooltip("Scale curve multiplies this scale factor.")]
    public Vector3 ScaleFactor = Vector3.one;

    [Header("Color")]

    [Tooltip("Color over time.")]
    public Gradient Color = new Gradient();

    // Internal state.
    static MaterialPropertyBlock CachedBlock;
    List<TunnelMeshNote> Meshes = new List<TunnelMeshNote>();

    Color BaseTint = UnityEngine.Color.white;

    static Dictionary<int, Material> MaterialHash = new Dictionary<int, Material>();

    static int RenderQueueGenerator = 1;

    [EasyButtons.Button]
    void Respawn()
    {
        // Delete any prior items. We use a loop like this to avoid infinite
        // loop if the destroys fail.
        var count = transform.childCount;
        for (var i = 0; i < count; i++)
            DestroyImmediate(transform.GetChild(transform.childCount - 1).gameObject);

        Meshes.Clear();

        // Spawn our items.
        count = SpawnOnGrid ? GridSize.x * GridSize.y * GridSize.z : NumberToSpawn;
        for (var i = 0; i < count; i++)
        {
            var note = new TunnelMeshNote();
            note.Time = SpawnWithZeroTime ? 0 : (1.0f / NumberToSpawn) * i;
            note.Time += Random.value * SpeedOffset;
            note.SpeedScale = 1.0f / (CycleTime + Random.value * SpeedVariance);
            note.MeshGO = Instantiate(DisplayMesh, transform);
            note.MeshGO.hideFlags = HideFlags.HideAndDontSave;
            Meshes.Add(note);
        }

        // Override materials.
        if (OverrideMaterial != null)
        {
            // Generate hash key.
            int key = DisplayMesh.GetInstanceID() ^ OverrideMaterial.name.GetHashCode();

            // Look for attempt to use the same material/mesh combo if already
            // present; same material instance means we can sort together and
            // do instanced draws.
            int queueId = 3000;            
            Material mat;
            if(MaterialHash.ContainsKey(key) == false)
            {
                queueId = RenderQueueGenerator++;
                mat = new Material(OverrideMaterial);
                mat.renderQueue = 3000 + queueId; // 3000 is the first translucent queue.
                MaterialHash[key] = mat;

                // Note that we only need unique queue IDs per level, so wrapping
                // is OK. We'll just wipe and continue.
                if (RenderQueueGenerator > 1000) {
                    Debug.LogWarning("Wrapped around material hash in MeshTunnelAnimator!");
                    RenderQueueGenerator = 0;
                    MaterialHash = new Dictionary<int, Material>();
                }

            }
            else
            {
                mat = MaterialHash[key];
            }

            if(OverrideMaterial.HasProperty("_TintColor"))
                BaseTint = OverrideMaterial.GetColor("_TintColor");
            var renderers = GetComponentsInChildren<MeshRenderer>();
            foreach (var r in renderers)
            {
                r.sharedMaterial = mat;
            }
        }

        Update();

        if(!setupEditor && !Application.isPlaying)
        {
            setupEditor = true;
            UnityEditor.EditorApplication.update += EditorUpdate;
        }
    }

    [EasyButtons.Button]
    public void Stop()
    {
        if(setupEditor && !Application.isPlaying)
        {
            setupEditor = false;
            UnityEditor.EditorApplication.update -= EditorUpdate;
        }
    }

    bool setupEditor = false;

    void Start()
    {
        Respawn();
    }

    void OnDrawGizmosSelected()
    {
        if (SpawnOnGrid && EnableGridMotionLock)
        {
            for(var i=0; i<Meshes.Count; i++)
            {
                var mn = Meshes[i];

                int xIdx, yIdx, zIdx;
                ConvertIndexToGridIndex(i, out xIdx, out yIdx, out zIdx);

                var offset = ConvertGridIndexToLocalPosition(xIdx, yIdx, zIdx);

                var applyAnimation = true;

                applyAnimation = CheckGridItemMotionLock(applyAnimation, xIdx, yIdx, zIdx);

                Gizmos.color = applyAnimation ? UnityEngine.Color.green : UnityEngine.Color.red;

                Gizmos.DrawWireCube(mn.MeshGO.transform.position, GridSpacing * 0.5f);
            }
        }
    }

    double editorDeltaTime = 0f;
    double lastTimeSinceStartup = 0f;

    private void SetEditorDeltaTime()
    {
        if (lastTimeSinceStartup == 0f)
        {
            lastTimeSinceStartup = UnityEditor.EditorApplication.timeSinceStartup;
        }
        editorDeltaTime = UnityEditor.EditorApplication.timeSinceStartup - lastTimeSinceStartup;
        lastTimeSinceStartup = UnityEditor.EditorApplication.timeSinceStartup;
    }

    void EditorUpdate()
    {
        SetEditorDeltaTime();
        Update();
    }

    void Update()
    {
        if (CachedBlock == null)
            CachedBlock = new MaterialPropertyBlock();

        var curIndex = 0;
        foreach (var mn in Meshes)
        {
            curIndex++;

            // Increment time for this mesh.
            if (CycleTime == 0.0f)
                continue;
#if UNITY_EDITOR
            mn.Time = Mathf.Repeat(mn.Time + (float)editorDeltaTime * mn.SpeedScale, 1.0f);
            if (this == null)
            {
                UnityEditor.EditorApplication.update -= EditorUpdate;
                return;
            }
#else
            mn.Time = Mathf.Repeat(mn.Time + Time.deltaTime * mn.SpeedScale, 1.0f);
#endif
            var t = mn.Time;

            // Apply state.
            var mt = mn.MeshGO.transform;

            var offset = Vector3.zero;
            bool applyAnimation = true;

            if (SpawnOnGrid)
            {
                int xIdx, yIdx, zIdx;
                ConvertIndexToGridIndex(curIndex, out xIdx, out yIdx, out zIdx);

                offset = ConvertGridIndexToLocalPosition(xIdx, yIdx, zIdx);

                if (EnableGridMotionLock)
                {
                    applyAnimation = CheckGridItemMotionLock(applyAnimation, xIdx, yIdx, zIdx);
                }
            }

            var animationOffset = DirectionOfMotion * Location.Evaluate(t);

            if (!applyAnimation)
                animationOffset = Vector3.zero;

            mt.localPosition = offset + animationOffset;

            mt.localScale = Scale.Evaluate(t) * ScaleFactor;
            mt.localRotation = Quaternion.AngleAxis(Rotation.Evaluate(t) * RotationScale, AxisOfRotation);

            // For color use a material property block to be instance compatible.
            var mr = mn.MeshGO.GetComponent<MeshRenderer>();

            // Note clever gamma math. Apparently the particle system does this
            // silently, but now we match it!
            var tmp = Color.Evaluate(t);
            var bt = BaseTint.linear;

            tmp.r *= bt.r;
            tmp.g *= bt.g;
            tmp.b *= bt.b;
            tmp.a *= bt.a;

            mr.GetPropertyBlock(CachedBlock);
            CachedBlock.SetColor("_TintColor", tmp.gamma);
            mr.SetPropertyBlock(CachedBlock);
        }
    }

    private bool CheckGridItemMotionLock(bool applyAnimation, int xIdx, int yIdx, int zIdx)
    {
        bool xCheck = xIdx >= LockBoxMin.x && xIdx <= LockBoxMax.x;
        bool yCheck = yIdx >= LockBoxMin.y && yIdx <= LockBoxMax.y;
        bool zCheck = zIdx >= LockBoxMin.z && zIdx <= LockBoxMax.z;

        if (xCheck && yCheck && zCheck)
            applyAnimation = false;
        return applyAnimation;
    }

    private Vector3 ConvertGridIndexToLocalPosition(int xIdx, int yIdx, int zIdx)
    {
        Vector3 offset;
        offset.x = xIdx * GridSpacing.x;
        offset.y = yIdx * GridSpacing.y;
        offset.z = zIdx * GridSpacing.z;
        return offset;
    }

    private void ConvertIndexToGridIndex(int curIndex, out int xIdx, out int yIdx, out int zIdx)
    {
        xIdx = curIndex % GridSize.x;
        yIdx = Mathf.FloorToInt(curIndex / GridSize.x) % GridSize.y;
        zIdx = Mathf.FloorToInt(curIndex / (GridSize.x * GridSize.y)) % GridSize.z;
    }
}
