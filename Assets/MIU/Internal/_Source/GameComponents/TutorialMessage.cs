using System;
using UnityEngine;

namespace MIU
{

/**
 * Used to indicate a zone in which a tutorial message is displayed.
 */
public class TutorialMessage : MonoBehaviour {

    [TextArea]
    public string message = "Hello, World";

    public Sprite graphic = null;

    // When set, only show it once - after that disable.
    public bool ShowOnce = false;

        
}
}
