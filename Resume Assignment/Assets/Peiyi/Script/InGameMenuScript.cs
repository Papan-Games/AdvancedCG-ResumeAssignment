using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameMenuScript : MonoBehaviour
{
    public GameObject confirmPopup;

    // Start is called before the first frame update
    void Start()
    {
        confirmPopup.SetActive(false);
    }

    public void OnClickMenu()
    {
        confirmPopup.SetActive(true);
    }

    public void OnClickYes()
    {
        confirmPopup.SetActive(false);
        SceneManager.LoadScene("Menu");
    }

    public void OnClickNo()
    {
        confirmPopup.SetActive(true);
    }

}