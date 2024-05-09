using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private string prevSceneName = null;
    public void goToScene(string sceneName)
    {
        if(Input.touchCount > 1)
            return;
        if(GameManager.Instance.getCurrnetSceneName().Equals(sceneName))
            return;
        prevSceneName = GameManager.Instance.getCurrnetSceneName();
        GameManager.Instance.setCurrnetSceneName(sceneName);
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive).completed += UnLoadPrevScene;
        
    }

    private void UnLoadPrevScene(AsyncOperation operation)
    {
        if(prevSceneName != null){
            SceneManager.UnloadSceneAsync(prevSceneName);
            prevSceneName = null;
        }
    }

    public void EndIntroScene()
    {
        prevSceneName = "IntroScene";
        GameManager.Instance.setCurrnetSceneName("SignUpScene");
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
