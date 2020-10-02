using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Profile : MonoBehaviour
{
    public TextMeshProUGUI fullName;
    public TextMeshProUGUI contactNumber;
    public TextMeshProUGUI email;
    public TextMeshProUGUI address;

    void Start()
    {
        if (Manager.instance.ChiaLing)
        {
            fullName.text = "Ng Chia Ling";
            contactNumber.text = "017-5165776";
            email.text = "vivianng1998 @ 1utar.my";
            address.text = "242, Lorong 6, Taman Kami A, 34000 Taiping, Perak";
        }
        else if (Manager.instance.PeiYi)
        {
            fullName.text = "Tham Pei Yi";
            contactNumber.text = "016-6919861";
            email.text = "peiyi456 @ 1utar.my";
            address.text = "CG-013, Jalan Indah 3, Taman Universiti Indah, 43300 Seri Kembangan, Selongor";
        }
        else if (Manager.instance.KengLiang)
        {
            fullName.text = "Yeoh Keng Liang";
            contactNumber.text = "016-6505631";
            email.text = "desmondyeoh22 @ 1utar.my";
            address.text = "24, Jalan USJ 8/2E, 47610 Subang Jaya, Selangor";
        }
    }
}
