using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleMaterial : MonoBehaviour
{
    public Material[] screenMaterial;
    Material[] meshMaterial;

    void Start()
    {
        meshMaterial = GetComponent<MeshRenderer>().materials;

        if (Manager.instance.ChiaLing)
        {
            meshMaterial[1].mainTexture = screenMaterial[0].mainTexture;
        }
        else if (Manager.instance.PeiYi)
        {
            meshMaterial[1].mainTexture = screenMaterial[1].mainTexture;
        }
        else if (Manager.instance.KengLiang)
        {
            meshMaterial[1].mainTexture = screenMaterial[2].mainTexture;
        }
    }
}
