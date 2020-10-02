using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameMenuScript : MonoBehaviour
{
    public GameObject confirmPopup;

    public GameObject joystick;
    public GameObject jumpButton;
    public GameObject homeButton;
    public GameObject interactButton;

    // Start is called before the first frame update
    void Start()
    {
        confirmPopup.SetActive(false);
    }

    private void ShowGUI(bool active)
    {
        joystick.SetActive(active);
        jumpButton.SetActive(active);
        homeButton.SetActive(active);
    }

    public void OnClickMenu()
    {
        confirmPopup.SetActive(true);
        confirmPopup.GetComponent<Animator>().SetBool("isOpen", true);
        ShowGUI(false);
        StartCoroutine(HandlePanel(true));
    }

    public void OnClickYes()
    {
        confirmPopup.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void OnClickNo()
    {
        Time.timeScale = 1;
        confirmPopup.GetComponent<Animator>().SetBool("isOpen", false);
        StartCoroutine(HandlePanel(false));
    }

    IEnumerator HandlePanel(bool open)
    {
        yield return new WaitForSeconds(0.75f);
        if (open)
        {
            Time.timeScale = 0;
            interactButton.SetActive(false);
        }
        else
        {
            confirmPopup.SetActive(false);
            ShowGUI(true);
        }
    }
}