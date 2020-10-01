using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skills : MonoBehaviour
{
    public TextMeshProUGUI skills;

    void Start()
    {
        if (Manager.instance.ChiaLing)
        {
            skills.text = "Unity C#\nC++\nWeb Design\nGraphic Design\nVideo Editing";
        }
        else if (Manager.instance.PeiYi)
        {
            skills.text = "Unity\nC++\nC#";
        }
        else if (Manager.instance.KengLiang)
        {
            skills.text = "Unity C# Scripting\nC++";
        }
    }
}
