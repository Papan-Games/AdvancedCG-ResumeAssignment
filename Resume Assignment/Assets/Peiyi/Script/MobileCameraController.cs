using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCameraController : MonoBehaviour
{
    public FixedTouchField CameraTouchField;

    // Update is called once per frame
    void Update()
    {
        var mouseLook = GetComponent<MouseLook>();
        mouseLook.LookAxis = CameraTouchField.TouchDist;
    }
}
