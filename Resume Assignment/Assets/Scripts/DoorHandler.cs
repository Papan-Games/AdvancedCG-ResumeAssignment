using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour
{
    public Animator doorAnim;
    public Collider DoorCollider;
    private AudioSource DoorSFX;
    // Start is called before the first frame update
    void Start()
    {
        DoorSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            DoorSFX.PlayOneShot(DoorSFX.clip);
        }
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
