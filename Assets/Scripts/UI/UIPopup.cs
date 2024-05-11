using UnityEngine;

public class UIPopup : MonoBehaviour
{
    [SerializeField] protected GameObject popupCanvas; // 팝업 창의 캔버스
    [SerializeField] protected Animator popupAnimator; // 팝업 창의 애니메이터

    // 애니메이션 이벤트에서 호출할 메서드
    virtual public void OnCloseAnimationFinished()
    {
        // 애니메이션 완료 후 팝업 캔버스 비활성화
        UIUtilities.SetUIActive(popupCanvas, false);
    }

    // 팝업이 열릴 때 호출
    virtual public void Open()
    {
        if (popupCanvas != null)
        {
            // 팝업 캔버스 활성화
            UIUtilities.SetUIActive(popupCanvas, true);

            // 팝업 애니메이션 재생 (애니메이션 이벤트로 OnCloseAnimationFinished 호출)
            if (popupAnimator != null)
            {
                popupAnimator.SetTrigger("Open");
            }
        }
    }

    // 팝업이 닫힐 때 호출
    virtual public void Close()
    {
        if (popupCanvas != null)
        {
            // 팝업 애니메이션 재생 (애니메이션 이벤트로 OnCloseAnimationFinished 호출)
            if (popupAnimator != null)
            {
                popupAnimator.SetTrigger("Close");
            }
            else
            {
                // 애니메이션을 사용하지 않는 경우 즉시 팝업 캔버스를 비활성화
                UIUtilities.SetUIActive(popupCanvas, false);
            }
        }
    }

    virtual public void InvokeOpen(){
        UIManager.Instance.OpenPopup(this);
    }
    virtual public void InvokeClose(){
        UIManager.Instance.ClosePopup(this);
    }

    // 팝업 내에서 어떤 동작을 수행할 때 호출될 메서드들을 추가
    virtual public void OnClick()
    {

    }
}