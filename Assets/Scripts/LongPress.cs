using System;
using System.Collections;
using UnityEngine ;
using UnityEngine.Events ;
using UnityEngine.EventSystems ;
using UnityEngine.UI ;

[RequireComponent(typeof(Button))]
public class LongPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    [Tooltip("길게 누르는 시간(초)")]
    [Range(0.3f, 5f)] public float holdDuration = 0.5f;
    public UnityEvent onLongPress;
    public UnityEvent onPress;

    private bool isPointerDown = false;
    private bool isLongPressed = false;
    private DateTime pressTime;
    private Button button;
    private WaitForSeconds delay;
    private Vector2 m_position;

    private void Awake() {
        button = GetComponent<Button>();
        delay = new WaitForSeconds(0.1f);
    }

    public Vector2 getMousePosition(){
        return m_position;
    }

    public void OnPointerDown(PointerEventData eventData) {
        isPointerDown = true;
        pressTime = DateTime.Now;
        StartCoroutine(Timer());

        m_position = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData) {
        if(!eventData.IsPointerMoving())
            if(!isLongPressed)
                onPress?.Invoke();
        isPointerDown = false;
        isLongPressed = false;
    }

    private IEnumerator Timer() {
        while (isPointerDown && !isLongPressed) {
            double elapsedSeconds = (DateTime.Now - pressTime).TotalSeconds;

            if (elapsedSeconds >= holdDuration) {
                isLongPressed = true;
                if (button.interactable){
                    onLongPress?.Invoke();
                }
                yield break;
            }
            yield return delay;
        }
    }
}