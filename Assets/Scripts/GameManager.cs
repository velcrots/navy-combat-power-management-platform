using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null)
                {
                    Debug.LogError("GameManager가 씬에 존재하지 않습니다.");
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance == null){
            _instance = this;
        }
        else{
            Destroy(gameObject);
        }
#if UNITY_ANDROID && !UNITY_EDITOR
        Application.targetFrameRate = 60;
#endif
    }

    private string currentSceneName = null;

    public string getCurrnetSceneName(){
        return currentSceneName;
    }
    public void setCurrnetSceneName(string sceneName){
        currentSceneName = sceneName;
    }

    void Start()
    {
    }

    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        */
    }

    
}
