using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cocurricular : MonoBehaviour
{
    public TextMeshProUGUI cocurricular;

    void Start()
    {
        if (Manager.instance.ChiaLing)
        {
            cocurricular.text = "1. Bequest (DPS Showcase) - Treasurer\n" +
                "2. Chess Tournament - Logistic HOD\n3. Orientation (Jan 2020) - GNA Umbrella Manager\n" +
                "4. Bogacon - Fundraising Committee\n5. MAD Talent - Logistic & Technical Committee\n" +
                "6. CANVAS (DPS Showcase) - Program Committee\n";
        }
        else if (Manager.instance.PeiYi)
        {
            cocurricular.text = "PLKN";
        }
        else if (Manager.instance.KengLiang)
        {
            cocurricular.text = "2nd place at Solar Car Design Competition";
        }
    }
}
