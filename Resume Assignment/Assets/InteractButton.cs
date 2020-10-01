using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton : MonoBehaviour
{
    bool interacted;
    public GameObject PanelRef;
    // Start is called before the first frame update
    void Start()
    {
        interacted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InteractPlease()
    {
        if(PanelRef != null && !interacted)
        {
            PanelRef.SetActive(true);
            interacted = true;
            Time.timeScale = 0;
        }
    }

    public void CloseButton()
    {
        if(PanelRef != null && interacted)
        {
            interacted = false;
            PanelRef.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
