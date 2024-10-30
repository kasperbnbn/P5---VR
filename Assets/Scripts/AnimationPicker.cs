using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPicker : MonoBehaviour
{
    private Animator animator;
    private int variantNumber;
    
    void OnEnable()
    {
        animator = GetComponent<Animator>();
        variantNumber = Random.Range(0, 3);
        float offset = Random.Range(0, 1);

        Invoke("Starting", offset);
    }

    private void Starting()
    {
        animator.SetInteger("Variant", variantNumber);
    }
}
