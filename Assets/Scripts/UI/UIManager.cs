using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<UIManager>();
                if (_instance == null)
                {
                    Debug.LogError("UIManager가 씬에 존재하지 않습니다.");
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance == null){
            _instance = this;

            action = new UIInputActions();
            action.UI.Cancel.performed += Cancel;
        }
        else{
            Destroy(gameObject);
        }
    }

    private Stack<UIPopup> openPopups = new Stack<UIPopup>();
    private Queue<UIPopup> pendingPopups = new Queue<UIPopup>(); // 예약된 팝업을 위한 큐

    private UIInputActions action;

    private void OnEnable() {
        if(action != null)
            action.UI.Enable();
    } 
    private void OnDisable() {
        if(action != null)
            action.UI.Disable();
    }

    // 취소키 누르면 최근 팝업 닫기
    public void Cancel(InputAction.CallbackContext context){
        if (openPopups.Count == 0)
        {
            Application.Quit();
        }
        CloseLastOpenedPopup();
    }

    private void Update()
    {
    }

    // 팝업 열기
    public void OpenPopup(UIPopup popup)
    {
        if (popup != null)
        {      
            popup.Open();
            openPopups.Push(popup);
        }
    }

    // 팝업 닫기
    public void ClosePopup(UIPopup popup)
    {
        if (popup != null && openPopups.Contains(popup))
        {
            popup.Close();
            openPopups.Pop();

            // 예약 팝업 열기
            if (pendingPopups.Count > 0)
            {
                OpenPopup(pendingPopups.Dequeue());
            }
        }
    }

    // 최근 팝업 닫기
    public void CloseLastOpenedPopup()
    {
        if (openPopups.Count > 0)
        {
            ClosePopup(openPopups.Peek());
        }
    }

    // 모든 열린 팝업 닫기
    public void CloseAllOpenPopups()
    {
        while (openPopups.Count > 0)
        {
            ClosePopup(openPopups.Peek());
        }
    }

    // 예약된 팝업 추가
    public void ReservePopup(UIPopup popup)
    {
        if (popup != null)
        {
            pendingPopups.Enqueue(popup);
        }
    }
}