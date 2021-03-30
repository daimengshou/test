using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Menucontrol : MonoBehaviour {

    public Record Record;    
    public Button button5;
    public Button buttonExit;
    

    void Start()
    {  
        button5.onClick.AddListener(onclickButton5);
        buttonExit.onClick.AddListener(onbuttonExit);
    }

    private void onbuttonExit()
    {     
        Application.Quit();
        Record.list.Add("关闭项目");
    }

 
    public void onclickButton5() {

        SceneManager.LoadScene(1);
        Record.list.Add("点击开始实验");      
    }


}
