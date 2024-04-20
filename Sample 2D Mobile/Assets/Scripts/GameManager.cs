using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public GameObject UIo;
    //public GameObject UIo2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToMainScene() {
        SceneManager.LoadScene("MainScene");
        //UIo.gameObject.SetActive(false);
        //UIo2.gameObject.SetActive(true);
        Debug.Log("dsa");
    }

    public void goToCPMScene() {
        SceneManager.LoadScene("CPMScene");
        //UIo.gameObject.SetActive(true);
        //UIo2.gameObject.SetActive(false);
    }

    public void goToBoardScene() {
        SceneManager.LoadScene("BoardScene");
        //UIo.gameObject.SetActive(true);
        //UIo2.gameObject.SetActive(false);
    }

    public void goToTrainingScene() {
        SceneManager.LoadScene("TrainingScene");
    }

    public void goToSMScene() {
        SceneManager.LoadScene("SMScene");
    }

    public void goToToDoScene() {
        SceneManager.LoadScene("ToDoScene");
    }
}
