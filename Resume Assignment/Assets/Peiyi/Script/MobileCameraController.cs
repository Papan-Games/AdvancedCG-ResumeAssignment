using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCameraController : MonoBehaviour
{
    public FixedTouchField CameraTouchField;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //var fps = GetComponent<PlayerMove>();

        //fps.
        var mouseLook = GetComponent<MouseLook>();
        mouseLook.LookAxis = CameraTouchField.TouchDist;
    }
}
