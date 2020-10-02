using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton : MonoBehaviour
{
    bool interacted;
    public GameObject PanelRef;

    public GameObject joystick;
    public GameObject jumpButton;
    public GameObject homeButton;
    public GameObject backButton;
    public PlayerMove moveRef;
    private AudioSource FlipPageSFX;

    // Start is called before the first frame update
    void Start()
    {
        interacted = false;
        FlipPageSFX = GetComponent<AudioSource>();
    }

    private void ShowGUI(bool active)
    {
        joystick.SetActive(active);
        jumpButton.SetActive(active);
        homeButton.SetActive(active);
        backButton.SetActive(!active);
    }

    public void InteractPlease()
    {
        if(PanelRef != null && !interacted)
        {
            moveRef.canMove = false;
            PanelRef.SetActive(true);
            PanelRef.GetComponent<Animator>().SetBool("isOpen", true);
            FlipPageSFX.PlayOneShot(FlipPageSFX.clip);
            ShowGUI(false);
            StartCoroutine(HandlePanel(true));
        }
    }

    public void CloseButton()
    {
        if(PanelRef != null && interacted)
        {
            interacted = false;
            Time.timeScale = 1;
            PanelRef.GetComponent<Animator>().SetBool("isOpen", false);
            FlipPageSFX.PlayOneShot(FlipPageSFX.clip);
            StartCoroutine(HandlePanel(false));
        }
    }

    IEnumerator HandlePanel(bool open)
    {
        yield return new WaitForSeconds(0.75f);
        if (open)
        {
            Time.timeScale = 0;
            interacted = true;
        }
        else
        {
            moveRef.canMove = true;
            PanelRef.SetActive(false);
            PanelRef = null;
            ShowGUI(true);
        }
    }
}
