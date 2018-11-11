using System;
using UnityEngine;

public class TutorialMessage : MonoBehaviour
{

    [TextArea]
    public string message = "Hello, World";

    [HideInInspector]
    public Sprite graphic = null;

    // When set, only show it once - after that disable.
    public bool ShowOnce = false;


}
