using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Education : MonoBehaviour
{
    public TextMeshProUGUI educationBackground;

    void Start()
    {
        if (Manager.instance.ChiaLing)
        {
            educationBackground.text = "Bachelor of Science in Game Development\n\nCGPA 3.5123";
        }
        else if (Manager.instance.PeiYi)
        {
            educationBackground.text = "Bachelor of Science in Game Development\n\nCGPA 3.1537";
        }
        else if (Manager.instance.KengLiang)
        {
            educationBackground.text = "Bachelor of Science in Game Development\n\nCGPA 3.57";
        }
    }
}
