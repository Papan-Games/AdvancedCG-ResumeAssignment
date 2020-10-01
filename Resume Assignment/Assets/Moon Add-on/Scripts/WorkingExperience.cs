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
            workingExperiences.text = "Video Editor (Freelance) for T7 Global Bhd\nSong Grader (Freelance) for NEXT Music\n" +
                "Self-Employed Online Business Owner";
        }
        else if (Manager.instance.PeiYi)
        {
            workingExperiences.text = "General Clerk in Interstrive Sdn Bhd\nHome Tutor";
        }
        else if (Manager.instance.KengLiang)
        {
            workingExperiences.text = "Junior Web UI Designer\nApp UI Designer";
        }
    }
}
