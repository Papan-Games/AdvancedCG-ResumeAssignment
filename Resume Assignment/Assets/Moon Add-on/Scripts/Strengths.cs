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
            personalStrengths.text = "1. Leadership\n2. Teamwork\n3. Planning\n4. Decision making\n5. Communication";
        }
        else if (Manager.instance.PeiYi)
        {
            personalStrengths.text = "1. Willing to learn\n2. Problem solver\n3. Good teamwork\n4. Good follower";
        }
        else if (Manager.instance.KengLiang)
        {
            personalStrengths.text = "1. Communicate well\n2. Adapt quickly\n3. Problem solver";
        }
    }
}
