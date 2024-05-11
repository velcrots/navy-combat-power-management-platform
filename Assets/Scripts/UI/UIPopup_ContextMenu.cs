using UnityEngine;
using UnityEngine.EventSystems;

public class UIPopup_ContextMenu : UIPopup
{
    public UIPopup_EditTodo popup_EditTodo;
    private GameObject selected;

    public override void OnCloseAnimationFinished()
    {
        Destroy(transform.parent.gameObject);
    }

    override public void Close()
    {
        if (popupCanvas != null)
        {
            if (popupAnimator != null)
            {
                popupAnimator.SetTrigger("Close");
            }
            else
            {
                Destroy(transform.parent.gameObject);
            }
        }
    }

    // ContextMenu 열기(포인터위치)
    public void OpenContextMenu(GameObject originalContextMenu)
    {
        GameObject copyContextMenu = Instantiate(originalContextMenu, Vector3.zero, Quaternion.identity);
        copyContextMenu.transform.SetParent(transform.parent.parent.transform, false);
        UIPopup_ContextMenu copyUIPopup = copyContextMenu.GetComponentInChildren<UIPopup_ContextMenu>();
        copyUIPopup.selected = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;
        UIManager.Instance.OpenPopup(copyUIPopup);
        
        copyContextMenu.transform.GetChild(1).position = copyUIPopup.selected.GetComponentInChildren<LongPress>().getMousePosition();
    }

    // ContextMenu 열기(원점)
    public void OpenContextMenuZero(GameObject originalContextMenu)
    {
        GameObject copyContextMenu = Instantiate(originalContextMenu, Vector3.zero, Quaternion.identity);
        copyContextMenu.transform.SetParent(transform.parent.parent.transform, false);
        UIPopup_ContextMenu copyUIPopup = copyContextMenu.GetComponentInChildren<UIPopup_ContextMenu>();
        copyUIPopup.selected = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;
        UIManager.Instance.OpenPopup(copyUIPopup);
    }

    // ContextMenu 닫기
    public void CloseContextMenu()
    {
        UIManager.Instance.ClosePopup(this);
    }

    // 할 일 삭제
    public void Delete()
    {
        popup_EditTodo.DecreaseSize();
        Destroy(selected);
        UIManager.Instance.ClosePopup(this);
    }
}