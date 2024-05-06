using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolution : MonoBehaviour
{
    public float fixedAspectRatio;
    Canvas canvas;
    CanvasScaler canvasScaler;

    //Awake
    
    private void Update()
        {
        canvas = GetComponent<Canvas>();
        canvasScaler = canvas.GetComponent<CanvasScaler>();

        float currentAspectRatio = (float)Screen.width / (float)Screen.height;

        if (currentAspectRatio > fixedAspectRatio) canvasScaler.matchWidthOrHeight = 1;
        else if (currentAspectRatio < fixedAspectRatio) canvasScaler.matchWidthOrHeight = 0;
    }
}