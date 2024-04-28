using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tabs_Achievements : MonoBehaviour
{
    public Transform content;

    public void clickTab1() {
        for (int i = 0; i < content.childCount; i++){
            if(i == 0)
                content.GetChild(i).gameObject.SetActive(true);
            else
                content.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void clickTab2() {
        for (int i = 0; i < content.childCount; i++){
            if(i == 1)
                content.GetChild(i).gameObject.SetActive(true);
            else
                content.GetChild(i).gameObject.SetActive(false);
        }
    }

    public void clickTab3() {
        for (int i = 0; i < content.childCount; i++){
            if(i == 2)
                content.GetChild(i).gameObject.SetActive(true);
            else
                content.GetChild(i).gameObject.SetActive(false);
        }
    }
}
