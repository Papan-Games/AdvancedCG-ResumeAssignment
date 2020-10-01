using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PersonalInfo : MonoBehaviour
{
    public TextMeshProUGUI age;
    public TextMeshProUGUI IC;
    public TextMeshProUGUI DOB;
    public TextMeshProUGUI gender;
    public TextMeshProUGUI maritalStatus;
    public TextMeshProUGUI nationality;
    public TextMeshProUGUI languageKnown;

    void Start()
    {
        if (Manager.instance.ChiaLing)
        {
            age.text = "22";
            IC.text = "980307-08-5966";
            DOB.text = "07 / 03 / 1998";
            gender.text = "Female";
            maritalStatus.text = "Single";
            nationality.text = "Malaysian";
            languageKnown.text = "English, Malay, Mandarin, Hokkien";
        }
        else if (Manager.instance.PeiYi)
        {
            age.text = "22";
            IC.text = "980227-10-5912";
            DOB.text = "27 / 02 / 1998";
            gender.text = "Female";
            maritalStatus.text = "Single";
            nationality.text = "Malaysian";
            languageKnown.text = "Mandarin, Malay, English";
        }
        else if (Manager.instance.KengLiang)
        {
            age.text = "22";
            IC.text = "980403-14-6335";
            DOB.text = "03 / 04 / 1998";
            gender.text = "Male";
            maritalStatus.text = "Single";
            nationality.text = "Malaysian";
            languageKnown.text = "English, Malay, Mandarin, Japanese, Korean";
        }
    }
}
