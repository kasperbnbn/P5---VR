using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHider : MonoBehaviour
{
    [SerializeField]private GameObject[] objectsToHide;
    private bool cooldown;

    public void Hide()
    {
        if(!cooldown)
        {
            cooldown = true;
            foreach(GameObject obj in objectsToHide)
            {
                obj.SetActive(!obj.activeSelf);

            }
            StartCoroutine(CoolDown());
        }
        
    }

    IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(1f);
        cooldown = false;
    }
}
