using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Strengths : MonoBehaviour
{
    public TextMeshProUGUI personalStrengths;

    void Start()
    {
        if (Manager.instance.ChiaLing)
        {
            personalStrengths.text = "Leadership\nTeamwork\nPlanning and decision making\nCommunication\nCritical";
        }
        else if (Manager.instance.PeiYi)
        {
            personalStrengths.text = "Optimistic\nWilling to learn";
        }
        else if (Manager.instance.KengLiang)
        {
            personalStrengths.text = "Communicate well";
        }
    }
}
