using MIU;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Profiling;

// We need to do lots of manipulation of mover state... thus:
public class MoverState
{
    public float playhead;
    public bool collapsing;

    public void CopyFrom(MoverState other)
    {
        playhead = other.playhead;
        collapsing = other.collapsing;
    }
}

[DisallowMultipleComponent]
public class ElevatorMover : MonoBehaviour
{
    [NonSerialized]
    public ushort Id;

    // Increment on every mover change. TriCache doesn't recalc triangles unless
    // this doesn't match last known value.
    [NonSerialized]
    public static int InvalidationToken = 0;

    private MoverState currentState = new MoverState();
    private MoverState priorState = new MoverState();

    // We set this to 0 to stop platform movement for a while.
    [NonSerialized]
    public float StopTime = 0.0f;

    // How is our movement driven?
    public enum Mode
    {
        Elevator,
        Spline,
        Loop
    };

    public Mode mode;

    [Tooltip("Offsets the initial starting time by this many seconds.")]
    public float StartOffsetTime = 0.0f;

    [Header("Collapse")]

    [Tooltip("If true, we only start our movement once a player touches us.")]
    public bool WaitForTouched;

    #region Elevator

    [Header("Elevator")]
    public Vector3 delta = Vector3.zero;
    public Vector3 deltaRotation = Vector3.zero;

    public float pauseTime = 2.0f;
    public float moveTime = 4.0f;

    [Tooltip("On startup, move first or pause first?")]
    public bool moveFirst = false;

    [Header("Bobbing")]
    [Tooltip("Enable Bobbing Up/Down (for rotating platforms)")]
    public bool EnableBob = false;
    public Vector3 BobVector = Vector3.up;
    public float BobPeriod = 2.5f, BobOffset = 0.0f;

    #endregion

    #region Spline

    [Header("Spline")]
    public float splineSpeed = 0.2f;

    // If set, platform stays in it's orientation.
    public bool KeepOrientation = false;

    public GameObject splineGo;

   
    #endregion
}
