using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactions : MonoBehaviour
{
    public GameObject interactButton;
    public GameObject UIPopUpPanel;
    // Start is called before the first frame update
    void Start()
    {
        interactButton.SetActive(false);
        UIPopUpPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            interactButton.SetActive(true);
            interactButton.GetComponent<InteractButton>().PanelRef = UIPopUpPanel;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            interactButton.GetComponent<InteractButton>().PanelRef = null;
            interactButton.SetActive(false);
        }    
    }

}
