using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public Material[] materials;
    private MeshRenderer mr;
    private int matIndex = 0;
    Timer timer;
    bool debounce;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
        timer = new Timer();
        timer.StartTimer();
    }

    public void ChangeMat()
    {
        if(!debounce)
        {
            matIndex++;
            if (matIndex >= materials.Length)
                matIndex = 0;
            mr.material = materials[matIndex];
            debounce = true;
        }

    }

    private void Update()
    {
        if(debounce)
        {
            if(timer.time > 1)
            {
                debounce = false;
                timer.ResetTimer();
            }
        }

        timer.IncrementTime();
    }

}
