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
        Time.timeScale = 0;
    }

    public void OnClickYes()
    {
        confirmPopup.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void OnClickNo()
    {
        confirmPopup.SetActive(false);
        Time.timeScale = 1;
    }

}