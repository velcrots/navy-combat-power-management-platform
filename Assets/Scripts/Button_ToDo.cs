using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Button_ToDo : MonoBehaviour
{
    public Transform content;
    
    private int size = 0;
    public void PlusToDo(Transform content, TextMeshProUGUI scripttext)
    {
        content.GetChild(1).gameObject.SetActive(true);
        
        content.GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text = scripttext.text;
        scripttext.SetText("dsa");
    }
}
