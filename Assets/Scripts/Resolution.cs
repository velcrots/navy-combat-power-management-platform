using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolution : MonoBehaviour
{
    Canvas canvas;
    CanvasScaler canvasScaler;

    //Awake
    private void Awake()
        {
        canvas = GetComponent<Canvas>();
        canvasScaler = canvas.GetComponent<CanvasScaler>();

        float fixedAspectRatio = 9f / 16f;

        float currentAspectRatio = (float)Screen.width / (float)Screen.height;

        if (currentAspectRatio > fixedAspectRatio) canvasScaler.matchWidthOrHeight = 1;
        else if (currentAspectRatio < fixedAspectRatio) canvasScaler.matchWidthOrHeight = 0;
    }
}