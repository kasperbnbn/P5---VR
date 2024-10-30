using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPicker : MonoBehaviour
{
    private Animator animator;
    [SerializeField]private int variantNumber;
    
    void OnEnable()
    {
        animator = GetComponent<Animator>();
        variantNumber = Random.Range(0, 4);
        float offset = Random.Range(0f, 1f);

        Invoke("Starting", offset);
    }

    private void Starting()
    {
        animator.SetInteger("Variant", variantNumber);
    }
}
