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
        variantNumber = Random.Range(0, 10);

        animator.SetInteger("Variant", variantNumber);
    }
}
