using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Objective : MonoBehaviour
{
    public TextMeshProUGUI objective;

    void Start()
    {
        if (Manager.instance.ChiaLing)
        {
            objective.text = "Getting a job in game industry and continue to be involved in art performances";
        }
        else if (Manager.instance.PeiYi)
        {
            objective.text = "Learn new things and work in a new environment";
        }
        else if (Manager.instance.KengLiang)
        {
            objective.text = "My life goal is to be able to buy something without looking at the price.";
        }
    }
}
