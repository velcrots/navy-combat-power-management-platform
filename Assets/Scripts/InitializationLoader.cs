using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitializationLoader : MonoBehaviour
{
    [SerializeField] private SceneAsset _managersScene = default;
    [SerializeField] private SceneAsset _introScene = default;

    private void Start()
	{
		SceneManager.LoadSceneAsync(_managersScene.name, LoadSceneMode.Additive).completed += LoadIntroScene;
	}

    private void LoadIntroScene(AsyncOperation operation)
    {
        SceneManager.LoadSceneAsync(_introScene.name, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(0);
    }

}
