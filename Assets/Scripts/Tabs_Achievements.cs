using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tabs_Achievements : MonoBehaviour
{
    public Transform content;

    public void clickTab(int n) {
        for (int i = 0; i < content.childCount; i++){
            if(i == n)
                UIUtilities.SetUIActive(content.GetChild(i).gameObject, true);
            else
                UIUtilities.SetUIActive(content.GetChild(i).gameObject, false);
        }
    }
}
