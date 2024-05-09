using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 열린 메뉴의 버튼색 진하게 설정
public class Buttons_Menus : MonoBehaviour
{
    private void Start() {
        int buttonIndex = SceneManager.GetSceneByName(GameManager.Instance.getCurrnetSceneName()).buildIndex - 3;
        if(buttonIndex>=0 && buttonIndex < 5){
            Transform buttonObject = transform.GetChild(buttonIndex).transform.GetChild(0);
            Color color = buttonObject.GetComponent<Image>().color;
            color.a = 1.0f;
            buttonObject.GetComponent<Image>().color = color;
        }
    }
}
