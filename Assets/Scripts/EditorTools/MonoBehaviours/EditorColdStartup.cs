using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EditorColdStartup : MonoBehaviour
{
#if UNITY_EDITOR
    [SerializeField] private SceneAsset _thisScene = default;
    [SerializeField] private SceneAsset _managersScene = default;

    private bool isColdStart = false;
    private void Awake() {
        if(!SceneManager.GetSceneByName(_managersScene.name).isLoaded){
            isColdStart = true;
        }
    }

    private void Start() {
        if(isColdStart){
            SceneManager.LoadSceneAsync(_managersScene.name, LoadSceneMode.Additive).completed += LoadThisScene;
        }        
    }

    private void LoadThisScene(AsyncOperation operation)
        {
            SceneManager.LoadSceneAsync(_thisScene.name, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(0));
        }

#endif
}
