using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Text;

public class Test1control : MonoBehaviour {

    //记录操作过程
    public Record Record;
    public Button button;
  
    public GameObject Text1;
    public GameObject Text3;
    public GameObject Text4;

    public Button button1;
    public Button button3;
    public Button button4;
    string path;

    void Start()
    {
        path = Application.dataPath + "\\实验原理、方法和目的操作过程.txt";
        Text1.SetActive(false);
        Text3.SetActive(false);
        Text4.SetActive(false);

        button.onClick.AddListener(onclickbutton);       
    }
    public void first1()
    {
        Text1.SetActive(false);
        button1.GetComponent<Image>().color = new Color32(255,255,255,0);
    }
    public void first3()
    {
        Text3.SetActive(false);
        button3.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }
    public void first4()
    {
        Text4.SetActive(false);
        button4.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }
    public void test1()
    {
        Text1.SetActive(true);
        button1.GetComponent<Image>().color = Color.yellow;
        Record.list.Add("查看实验原理");
    }

    public void test3()
    {
        Text3.SetActive(true);
        button3.GetComponent<Image>().color = Color.yellow;
        Record.list.Add("查看实验目的");
    }

    public void test4()
    {
        Text4.SetActive(true);
        button4.GetComponent<Image>().color = Color.yellow;
        Record.list.Add("查看实验方法");
    }

    public void onclickbutton()
    {
        SceneManager.LoadScene(0);
        Record.list.Add("返回到开始界面");
    }

    public void onbutton6()
    {
        SceneManager.LoadScene("Test5");
        Record.list.Add("点击进入实验操作");

        //string[] string1 = new string[Record.list.Count];
        //for (int i = 0; i < Record.list.Count; i++)
        //{
        //    string1[i] = Record.list[i].ToString();
        //}
        ////导出txt文件：实验原理、目的和方法界面的操作过程
        //System.IO.File.WriteAllLines("C:/Users/ZX/Desktop/实验原理、方法和目的操作过程.txt", string1);

        //写入文本
        FileStream fileStream = new FileStream(path,FileMode.OpenOrCreate);
        StreamWriter sw = new StreamWriter(fileStream,Encoding.UTF8);
        foreach (var item in Record.list)
        {
            sw.WriteLine(item);
        }
        sw.Close();
        fileStream.Close();
    }
 

}
