using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hobbies : MonoBehaviour
{
    public TextMeshProUGUI personalHobbies;

    void Start()
    {
        if (Manager.instance.ChiaLing)
        {
            personalHobbies.text = "Dancing\nSinging\nActing\nGaming";
        }
        else if (Manager.instance.PeiYi)
        {
            personalHobbies.text = "Reading";
        }
        else if (Manager.instance.KengLiang)
        {
            personalHobbies.text = "Live streaming games";
        }
    }
}
