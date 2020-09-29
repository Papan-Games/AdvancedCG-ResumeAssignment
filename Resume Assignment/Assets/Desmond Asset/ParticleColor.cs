using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleColor : MonoBehaviour
{
    //float red, green, blue;
    //public RGB scriptRef;
    public Material smokeMaterial;
    public Light pointLight;
    //[SerializeField] float TransitionSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
    //     if(scriptRef.StartRed)
    //     {
    //         red = 1.0f;
    //         green = 0.0f;
    //         blue = 0.0f;
    //     }
    //     else if (scriptRef.StartGreen)
    //     {
    //         red = 0.0f;
    //         green = 1.0f;
    //         blue = 0.0f;
    //     }
    //     else if(scriptRef.StartBlue)
    //     {
    //         red = 0.0f;
    //         green = 0.0f;
    //         blue = 1.0f;
    //     }
    //     else
    //     {
    //         red = 1.0f;
    //         green = 0.0f;
    //         blue = 0.0f;
    //     }
    }

    // // Update is called once per frame
     void Update()
    {
    //     smokeMaterial.color = new Color(red,green,blue);
    //     if (scriptRef.changeRed)
    //     {
    //        if(red > 0.0f)
    //        {
    //            green += TransitionSpeed;
    //            blue += TransitionSpeed;
    //        }
    //        else
    //        {
    //            blue -= TransitionSpeed;
    //            red -= TransitionSpeed; 
    //        }
    //     }
    //     else if (scriptRef.changeGreen)
    //     {
    //        if(green > 0.0f)
    //        {
    //            blue += TransitionSpeed;
    //            red += TransitionSpeed;
    //        }
    //        else
    //        {
    //            red -= TransitionSpeed;
    //            green -= TransitionSpeed;
    //        }
    //     }
    //     else if (scriptRef.changeBlue)
    //     {
    //        if(blue > 0.0f)
    //        {
    //            red += TransitionSpeed;
    //            green += TransitionSpeed;
    //        }
    //        else
    //        {
    //            blue -= TransitionSpeed;
    //            green -= TransitionSpeed;
    //        }
    //     }
        smokeMaterial.color = pointLight.color;
        smokeMaterial.SetColor("_EmissionColor", pointLight.color);
    }
}
