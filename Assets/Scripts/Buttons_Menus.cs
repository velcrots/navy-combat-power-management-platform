using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons_Menus : MonoBehaviour
{
    public void goToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    string[] buttons_name = new string[]{"", "Button_Home", "Button_CPM", "Button_Board", "Button_Training", "Button_SM", "Button_ToDo", ""};

    private void Start() {
        if(name == buttons_name[SceneManager.GetActiveScene().buildIndex]){
            Color color = GetComponent<Image>().color;
            color.a = 1.0f;
            GetComponent<Image>().color = color;
        }
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
}