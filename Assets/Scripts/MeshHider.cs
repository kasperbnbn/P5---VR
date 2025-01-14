using System.Collections;
using UnityEngine;

public class MeshHider : MonoBehaviour
{
    [SerializeField] private GameObject[] meshToHide;
    private bool cooldown;

    public void Hide()
    {
        if(!cooldown)
        {
            cooldown = true;
            foreach (GameObject m in meshToHide)
            {
                MeshRenderer meshRenderer = m.GetComponent<MeshRenderer>();
                meshRenderer.enabled = !meshRenderer.enabled;
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
