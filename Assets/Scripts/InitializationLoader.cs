using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 앱 실행시 초기 Scene Load
public class InitializationLoader : MonoBehaviour
{
    private string _managersScene = "PersistentManagers";
    private string _introScene = "IntroScene";

    private void Start()
	{
		SceneManager.LoadSceneAsync(_managersScene, LoadSceneMode.Additive).completed += LoadIntroScene;
	}

    private void LoadIntroScene(AsyncOperation operation)
    {
        SceneManager.LoadSceneAsync(_introScene, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(0);
    }

}