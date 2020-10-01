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
            objective.text = "Working a job that I enjoy and continue to be involved in art performances";
        }
        else if (Manager.instance.PeiYi)
        {
            objective.text = "Reduce family burden";
        }
        else if (Manager.instance.KengLiang)
        {
            objective.text = "My life goal is to be able to buy something without looking at the price.";
        }
    }
}
