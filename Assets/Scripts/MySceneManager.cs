using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public string nextSceneName;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene(nextSceneName);
            //SceneManager.LoadSceneAsync(nextSceneName);
            //SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }
}
