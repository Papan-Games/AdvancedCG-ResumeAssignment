using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseChiaLing()
    {
        Manager.instance.ChiaLing = true;
        Manager.instance.PeiYi = false;
        Manager.instance.KengLiang = false;
        SceneManager.LoadScene("Peiyi room temp");
    }

    public void ChoosePeiYi()
    {
        Manager.instance.ChiaLing = false;
        Manager.instance.PeiYi = true;
        Manager.instance.KengLiang = false;
        SceneManager.LoadScene("Peiyi room temp");
    }

    public void ChooseKengLiang()
    {
        Manager.instance.ChiaLing = false;
        Manager.instance.PeiYi = false;
        Manager.instance.KengLiang = true;
        SceneManager.LoadScene("Peiyi room temp");
    }
}
