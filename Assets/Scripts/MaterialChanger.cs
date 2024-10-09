using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public Material[] materials;
    private MeshRenderer mr;
    private int matIndex = 0;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }

    public void ChangeMat()
    {
        matIndex++;
        mr.material = materials[matIndex];
    }

}
