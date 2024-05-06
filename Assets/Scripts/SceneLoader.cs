using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private string currentSceneName = null;
    public void goToScene(SceneAsset sc)
    {
        currentSceneName = SceneManager.GetSceneAt(1).name;
        SceneManager.LoadSceneAsync(sc.name, LoadSceneMode.Additive).completed += UnLoadPrevScene;
        
    }

    private void UnLoadPrevScene(AsyncOperation operation)
    {
        if(currentSceneName != null){
            SceneManager.UnloadSceneAsync(currentSceneName);
            currentSceneName = null;
        }
    }

    public void EndIntroScene(SceneAsset sc)
    {
        currentSceneName = "IntroScene";
        SceneManager.LoadSceneAsync(sc.name, LoadSceneMode.Additive).completed += UnLoadPrevScene;
    }

    private void Start() {

    }
    private void Update() {
    }
}
