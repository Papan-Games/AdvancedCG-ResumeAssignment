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
            educationBackground.text = "UTAR Bachelor of Science in Game Development\nCGPA - 3.5123" +
                "\n\nTARUC Diploma in Multimedia Design\nCGPA - 3.2694\n\nSPM - 1A+ 3A 1A- 1B+ 3B 1C";
        }
        else if (Manager.instance.PeiYi)
        {
            educationBackground.text = "UTAR Bachelor of Science in Game Development\nCGPA - 3.1537" +
                "\n\nSTPM - 1B+ 1D+ 1C\n\nSPM - 1A 1A- 2B+ 1B 4C+ 1D";
        }
        else if (Manager.instance.KengLiang)
        {
            educationBackground.text = "UTAR Bachelor of Science in Game Development\nCGPA - 3.57" +
                "\n\nSPM - 3A+ 5A- 1B+";
        }
    }
}
