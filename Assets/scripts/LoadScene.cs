using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public void loadScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }
}
