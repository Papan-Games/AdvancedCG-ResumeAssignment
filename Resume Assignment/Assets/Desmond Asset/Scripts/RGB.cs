using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGB : MonoBehaviour
{
    float red;
    float green;
    float blue;
    public bool StartRed, StartGreen, StartBlue;
    public bool includeMaterial;
    public bool changeRed, changeGreen, changeBlue;
    public Material emissionMat;
    public Color lightColor;
    public Light pointLight;
    [SerializeField] float TransitionSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        if(StartRed)
        {
            changeRed = true;
            changeGreen = false;
            changeBlue = false;
            red = 1.0f;
            green = 0.0f;
            blue = 0.0f;
        }
        else if (StartGreen)
        {
            changeRed = false;
            changeGreen = true;
            changeBlue = false;
            red = 0.0f;
            green = 1.0f;
            blue = 0.0f;
        }
        else if(StartBlue)
        {
            changeRed = false;
            changeGreen = false;
            changeBlue = true;
            red = 0.0f;
            green = 0.0f;
            blue = 1.0f;
        }
        else
        {
            //Default start Red
            changeRed = true;
            changeGreen = false;
            changeBlue = false;
            red = 1.0f;
            green = 0.0f;
            blue = 0.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        lightColor = new Color (red, green, blue);
        pointLight.color = lightColor;
        if(includeMaterial)
        {
            emissionMat.SetColor("_EmissionColor", lightColor);
        }
        if (changeRed)
        {
           if(red > 0.0f)
           {
               red -= TransitionSpeed;
           }
           else
           {
               green += TransitionSpeed;
               if(green >= 1.0f)
               {
                   changeRed = false;
                   changeGreen = true;
                   changeBlue = false;
               }
           }
        }
        else if (changeGreen)
        {
           if(green > 0.0f)
           {
               green -= TransitionSpeed;
           }
           else
           {
               blue += TransitionSpeed;
               if(blue >= 1.0f)
               {
                   changeRed = false;
                   changeGreen = false;
                   changeBlue = true;
               }
           }
        }
        else if (changeBlue)
        {
           if(blue > 0.0f)
           {
               blue -= TransitionSpeed;
           }
           else
           {
               red += TransitionSpeed;
               if(red >= 1.0f)
               {
                   changeRed = true;
                   changeGreen = false;
                   changeBlue = false;
               }
           }
        }
    }
}
