using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class information : MonoBehaviour {

    bool isShow;
    public string Infor = "女菀";
    public GUIStyle _GUIStyle;
    public float offset = 15;
     void Start()
    {
        isShow = false;   
    }
     void OnMouseEnter()
    {
        isShow = true; 
    }
     void OnMouseExit()
    {
        isShow = false;
    }
     void OnGUI()
    {
        if(isShow)
        {
            _GUIStyle.fontSize = 30;
            GUI.Label(new Rect(Input.mousePosition.x+offset, Screen.height - Input.mousePosition.y, 100, 100), Infor, _GUIStyle);
        }
    }
}
