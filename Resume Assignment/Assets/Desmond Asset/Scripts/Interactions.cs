using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactions : MonoBehaviour
{
    public GameObject interactButton;
    public GameObject UIPopUpPanel;
    private bool interacted;
    // Start is called before the first frame update
    void Start()
    {
        interactButton.SetActive(false);
        UIPopUpPanel.SetActive(false);
        interacted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            interactButton.SetActive(true);
        }
    }

    public void InteractPlease()
    {
        if(!interacted)
        {
            interacted = true;
            UIPopUpPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void CloseButton()
    {
        if(interacted)
        {
            interacted = false;
            UIPopUpPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
