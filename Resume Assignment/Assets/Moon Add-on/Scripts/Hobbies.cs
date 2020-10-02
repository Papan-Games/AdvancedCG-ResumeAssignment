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
            personalHobbies.text = "1. Gaming\n2. Dancing\n3. Singing\n4. Acting";
        }
        else if (Manager.instance.PeiYi)
        {
            personalHobbies.text = "1. Reading\n2. Gaming";
        }
        else if (Manager.instance.KengLiang)
        {
            personalHobbies.text = "Live streaming games";
        }
    }
}
