using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

// 에디터용 Scene ColdStart
public class EditorColdStartup : MonoBehaviour
{
#if UNITY_EDITOR
    [SerializeField] private SceneAsset _thisScene = default;
    [SerializeField] private SceneAsset _managersScene = default;

    private bool isColdStart = false;
    private void Awake() {
        if(!SceneManager.GetSceneByName(_managersScene.name).isLoaded){
            isColdStart = true;
            SceneManager.LoadSceneAsync(_managersScene.name, LoadSceneMode.Additive).completed += LoadThisScene;
        }
    }

    private void Start() {
        if(isColdStart){
            SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(0));
        }        
    }

    private void LoadThisScene(AsyncOperation operation)
        {
            SceneManager.LoadSceneAsync(_thisScene.name, LoadSceneMode.Additive);
            GameManager.Instance.setCurrnetSceneName(_thisScene.name);
        }

#endif
}
