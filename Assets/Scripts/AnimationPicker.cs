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

        StartCoroutine(Starting(offset));
    }

    IEnumerator Starting(float time)
    {
        yield return new WaitForSeconds(time);
        animator.SetInteger("Variant", variantNumber);
    }
}
