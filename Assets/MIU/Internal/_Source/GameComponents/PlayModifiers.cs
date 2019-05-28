using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class PlayModifiers : MonoBehaviour {

    public float GravityMult = 1;
    public float JumpForceMult = 1;
    public float BounceMult = 1;
    public float FrictionMult = 1;
    public Vector2 RollForceMult = Vector2.one;
    public Vector2 AirForceMult = Vector2.one;
    public float ScaleMult = 1;
    public bool CanBlast = false;
    public int AirJumps = 0;

    public string ToJSON()
    {
        JSONClass json = new JSONClass();
        json.Add("gravity", new JSONData(GravityMult));
        json.Add("jumpmult", new JSONData(JumpForceMult));
        json.Add("bouncemult", new JSONData(BounceMult));
        json.Add("scalemult", new JSONData(ScaleMult));
        json.Add("frictionmult", new JSONData(FrictionMult));

        json.Add("rollX", new JSONData(RollForceMult.x));
        json.Add("rollY", new JSONData(RollForceMult.y));

        json.Add("airX", new JSONData(AirForceMult.x));
        json.Add("airY", new JSONData(AirForceMult.y));

        json.Add("canblast", new JSONData(CanBlast));
        json.Add("airjumps", new JSONData(AirJumps));

        return json.ToString();

    }
}
