using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance {get; private set;}

    public bool ChiaLing, PeiYi, KengLiang;

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != null || instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ChiaLing = false;
        PeiYi = false;
        KengLiang = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
