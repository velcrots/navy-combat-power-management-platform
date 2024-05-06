using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private string currentSceneName = null;
    public void goToScene(string sceneName)
    {
        currentSceneName = SceneManager.GetSceneAt(1).name;
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive).completed += UnLoadPrevScene;
        
    }

    private void UnLoadPrevScene(AsyncOperation operation)
    {
        if(currentSceneName != null){
            SceneManager.UnloadSceneAsync(currentSceneName);
            currentSceneName = null;
        }
    }

    public void EndIntroScene()
    {
        currentSceneName = "IntroScene";
        SceneManager.LoadSceneAsync("SignUpScene", LoadSceneMode.Additive).completed += UnLoadPrevScene;
    }

    public void goToMainScene() {
        goToScene("MainScene");
    }

    public void goToCPMScene() {
        goToScene("CPMScene");
    }

    public void goToBoardScene() {
        goToScene("BoardScene");
    }

    public void goToTrainingScene() {
        goToScene("TrainingScene");
    }

    public void goToSMScene() {
        goToScene("SMScene");
    }

    public void goToToDoScene() {
        goToScene("ToDoScene");
    }

    public void goToFeedbackScene() {
        goToScene("FeedbackScene");
    }

    public void goToSignUpScene() {
        goToScene("SignUpScene");
    }
}
