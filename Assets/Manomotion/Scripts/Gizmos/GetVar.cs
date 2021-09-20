using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetVar : MonoBehaviour
{
    public Text textDisplay;
    public Text summary;

    void Update()
    {
        int receivedCount = TriggerGizmo.countingGesture;
        textDisplay.text = "" + receivedCount;
        if (receivedCount >= 10 && receivedCount <= 12)
        {
            summary.text = "Nice Job!";
        }else if (receivedCount <= 9)
        {
            summary.text = "Please Follow the Gesture Properly!";
        }else if (receivedCount >= 13)
        {
            summary.text = "Please Slow Down!";
        }
    }
}
