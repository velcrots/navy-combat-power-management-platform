using UnityEngine;
using TMPro;
using UnityEngine.UI;

public enum Mode {Plus, Edit}

public class UIPopup_EditTodo : UIPopup
{
    public Transform content;
    public GameObject originalToDo;

    private Mode mode;
    private TMP_InputField inputText;
    private TextMeshProUGUI selectedToDo;
    private Button but;

    private string originString;

    override public void Close()
    {
        inputText.text="";
        base.Close();
    }

    private void OnEnable() {
        if(inputText==null)
            inputText = GetComponentInChildren<TMP_InputField>();
        if(but==null)
            but = GetComponentInChildren<Button>();
        but.interactable = false;
    }

    // 저장할게 없으면 버튼 비활성화
    public void OnNull(Button but){
        if(inputText.text.Equals(originString) || inputText.text == ""){
            but.interactable = false;
        }
        else {
            but.interactable = true;
        }
    }

    // 할 일 저장
    public void SaveToDo(Button but)
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
        inputText.text = "";
        UIManager.Instance.ClosePopup(this);
    }

    // 할 일 추가모드 열기
    public void OpenPlus()
    {
        mode = Mode.Plus;
        originString = "";
        UIManager.Instance.OpenPopup(this);
    }

    // 할 일 편집모드 열기
    public void OpenEdit(TextMeshProUGUI selectedToDo)
    {
        mode = Mode.Edit;
        this.selectedToDo = selectedToDo;
        inputText.text = selectedToDo.text;
        originString = selectedToDo.text;
        UIManager.Instance.OpenPopup(this);
    }
}