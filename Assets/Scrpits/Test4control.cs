using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;


public class Test4control : MonoBehaviour {

    //记录操作过程
    private string path;
    public Record Record;
    public Button button;

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;

    public Button button1;
    public Button button2;
    public Button button3;
 
    void Start ()
    {
        path = Application.dataPath + "\\实验重点、难点讨论操作过程.txt";
        first();
        button.onClick.AddListener(onbutton);      
    }

    public void first()
    {   
        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);

        button1.GetComponent<Image>().color = new Color32(255,255,  255, 0);
        button2.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        button3.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    public void delete1()
    {
        Text1.SetActive(false);
        button1.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    public void delete2()
    {
        Text2.SetActive(false);
        button2.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }
    public void delete3()
    {
        Text3.SetActive(false);
        button3.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    public void test1()
    {
        Text1.SetActive(true);
        button1.GetComponent<Image>().color = Color.yellow;
        Record.list.Add("点击问题1：为什么强调随机取样？");
    }
    public void test2()
    {
        Text2.SetActive(true);
        button2.GetComponent<Image>().color = Color.yellow;
        Record.list.Add("点击问题2：样方的多少会影响调查结果吗？");
    }
    public void test3()
    {
        Text3.SetActive(true);
        button3.GetComponent<Image>().color = Color.yellow;
        Record.list.Add("点击问题3：实地调查与本实验活动的模拟调查有什么异同？");
    }

    public void onbutton6()
    {
        SceneManager.LoadScene("Test6");
        Record.list.Add("进入视频学习界面");

        FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
        StreamWriter sw = new StreamWriter(fileStream, System.Text.Encoding.UTF8);
        foreach (var item in Record.list)
        {
            sw.WriteLine(item);
        }
        sw.Close();
        fileStream.Close();
    }

    private void onbutton()
    {
        SceneManager.LoadScene("Test5");
        //Record.list.Add("返回到调查区域和方法选择界面");
        //string[] string1 = new string[Record.list.Count];
        //for (int i = 0; i < Record.list.Count; i++)
        //{
        //    string1[i] = Record.list[i].ToString();
        //}
        //System.IO.File.WriteAllLines("C:/Users/ZX/Desktop/实验重点、难点讨论操作过程.txt", string1);
    }
}
