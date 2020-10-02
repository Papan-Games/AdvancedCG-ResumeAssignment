using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WorkingExperience : MonoBehaviour
{
    public TextMeshProUGUI workingExperiences;

    void Start()
    {
        if (Manager.instance.ChiaLing)
        {
            workingExperiences.text = "1. Video Editor (Freelance) for T7 Global Bhd\n2. Song Grader (Freelance) for NEXT Music\n" +
                "3. Self-Employed Online Business Owner";
        }
        else if (Manager.instance.PeiYi)
        {
            workingExperiences.text = "1. General Clerk in Interstrive Sdn Bhd\n2. Home Tutor";
        }
        else if (Manager.instance.KengLiang)
        {
            workingExperiences.text = "1. Junior Web UI Designer\n2. App UI Designer";
        }
    }
}
