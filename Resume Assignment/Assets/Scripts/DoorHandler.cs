using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour
{
    public Animator doorAnim;
    public Collider DoorCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            doorAnim.SetBool("character_nearby", true);
            DoorCollider.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            doorAnim.SetBool("character_nearby", false);
            DoorCollider.enabled = true;
        }
    }
}
