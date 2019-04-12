using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static Main Self;

    public RectTransform CanvasRectTransform;
    public CanvasScaler CanvasScaler;


    public RectTransform Target1;
    public RectTransform Target2;
    public RectTransform Target3;

    public void Awake()
    {
        Self = this;
        var guideMask = FindObjectOfType<GuideMask>();
        guideMask.Init();
    }


    public void OnGUI()
    {
        if (GUILayout.Button("=============  Close GuideMask  ============="))
        {
            GuideMask.Self.Close();
        }
        if (GUILayout.Button("=============  Target 1  ============="))
        {
            GuideMask.Self.Play(Target1);
        }
        if (GUILayout.Button("=============  Target 2  ============="))
        {
            GuideMask.Self.Play(Target2);
        }
        if (GUILayout.Button("=============  Target 3  ============="))
        {
            GuideMask.Self.Play(Target3);
        }
    }
}
