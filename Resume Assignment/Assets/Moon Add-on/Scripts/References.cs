using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class References : MonoBehaviour
{
    public TextMeshProUGUI references;

    void Start()
    {
        if (Manager.instance.ChiaLing)
        {
            references.text = "Dr. Bong Mei Fern\n@\nbongmf@utar.edu.my";
        }
        else if (Manager.instance.PeiYi)
        {
            references.text = "Dr. Bong Mei Fern\n@\nbongmf@utar.edu.my";
        }
        else if (Manager.instance.KengLiang)
        {
            references.text = "Leon\n@\nOmniAppSolutions";
        }
    }
}
