using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelTiming : MonoBehaviour {

    [Header("Medal Times")]
    public float DiamondTime = 15;
    public float GoldTime = 30;
    public float SilverTime = 60;
    public string Author = "";

    public string GetTimingString()
    {
        string s = "";
        s += "_" + FloatToString(SilverTime);
        s += "_" + FloatToString(GoldTime);
        s += "_" + FloatToString(DiamondTime);
        return s;
    }

    string FloatToString(float f)
    {
        return (Math.Truncate(100 * f) / 100f).ToString().Replace('.','-');
    }
}
