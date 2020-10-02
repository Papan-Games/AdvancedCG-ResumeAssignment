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
            skills.text = "1. Unity C#\n2. C++\n3. Web Design\n4. Graphic Design\n5. Video Editing";
        }
        else if (Manager.instance.PeiYi)
        {
            skills.text = "1. Unity\n2. C++\n3. C#";
        }
        else if (Manager.instance.KengLiang)
        {
            skills.text = "1. Unity C# Scripting\n2. C++";
        }
    }
}
