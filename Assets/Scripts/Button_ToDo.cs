using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

//public enum Mode {Plus, Edit}

public class Button_ToDo : MonoBehaviour
{
    /*
    public Transform content;
    public GameObject originalToDo;
    public UIPopup popup;

    private Mode mode;
    private TMP_InputField inputText;
    private TextMeshProUGUI selectedToDo;

    private string originString;

    private void OnEnable() {
        if(inputText==null)
            inputText = GetComponentInChildren<TMP_InputField>();
    }

    public void OnNull(Button but){
        if(inputText.text.Equals(originString) || inputText.text == ""){
            but.interactable = false;
        }
        else {
            but.interactable = true;
        }
    }

    public void EditToDo(Button but)
    {
        if(mode == Mode.Plus){
            GameObject copyToDo = Instantiate(originalToDo, new Vector3(0, 0, 0), Quaternion.identity);
            copyToDo.transform.SetParent(content, false);
            copyToDo.GetComponentInChildren<TextMeshProUGUI>().text = inputText.text;
            copyToDo.SetActive(true);
        }
        else if(mode == Mode.Edit){
            selectedToDo.text = inputText.text;
        }
        originString = inputText.text;
        inputText.text = "";
        but.interactable = false;
        UIManager.Instance.ClosePopup(popup);
    }
    public void OpenPlus()
    {
        mode = Mode.Plus;
        originString = "";
        UIManager.Instance.OpenPopup(popup);
    }
    public void OpenEdit(TextMeshProUGUI selectedToDo)
    {
        mode = Mode.Edit;
        this.selectedToDo = selectedToDo;
        inputText.text = selectedToDo.text;
        UIManager.Instance.OpenPopup(popup);
    }
    public void OpenPo(GameObject originalPo2)
    {
        GameObject copyPo2 = Instantiate(originalPo2, new Vector3(0, 0, 0), Quaternion.identity);
        copyPo2.transform.SetParent(content, false);
        UIManager.Instance.OpenPopup(copyPo2.GetComponentInChildren<UIPopup>());
    }
    public void ClosePo()
    {
        UIManager.Instance.ClosePopup(popup);
    }
    */
}