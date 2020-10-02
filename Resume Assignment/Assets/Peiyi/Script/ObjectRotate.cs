using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(50 * Time.deltaTime, 0, 0); //rotates 50 degrees per second around x axis
    }
}
