using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchScene(int x)
    {
        int scene = SceneManager.GetActiveScene().buildIndex + x;
        if (scene >= SceneManager.sceneCountInBuildSettings)
            scene = 0;
        SceneManager.LoadScene(scene);
    }
}
