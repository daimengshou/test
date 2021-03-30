using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Test5control : MonoBehaviour {

    //记录操作过程
    //public Record Record;
    public GameObject button551;
    public GameObject button552;
    public GameObject button553;
    public GameObject button554;
    public GameObject button555;
    public GameObject button556;

    public GameObject button1;
    public GameObject Button58;
    public Button buttonStar;
    
    public GameObject Image6;

    int[] array = new int[4] {0,0,0,0};
   
    public botanyControl BotanyControl;//直接调用botanyControl方法
   
    void Start()
    {
        Button58.SetActive(false);

        button554.SetActive(false);
        button555.SetActive(false);
        button556.SetActive(false);

        button552.GetComponent<Button>().onClick.AddListener(onbutton552);
        button553.GetComponent<Button>().onClick.AddListener(onbutton553);
        button555.GetComponent<Button>().onClick.AddListener(onbutton555);
        button556.GetComponent<Button>().onClick.AddListener(onbutton556);

        BotanyControl.Image2.SetActive(false);
        BotanyControl.Image3.SetActive(false);
        BotanyControl.Image4.SetActive(false);
        BotanyControl.Image5.SetActive(false);
       
        buttonStar.onClick.AddListener(onbuttonStar);
    }

    void onbutton552()
    {
        array[0]++;
        if (array[0]%2!=0)
        {
            button552.GetComponent<Image>().color = Color.yellow;
            button553.GetComponent<Image>().color = new Color32(255,255,255,0);
            array[0]++;
            button554.SetActive(true);
            button555.SetActive(true);
            button556.SetActive(true);
        }
        else
        {
            button552.GetComponent<Image>().color = new Color32(255,255,255,0);
        }
        BotanyControl.colorVanish();
        button1.GetComponent<Image>().color = Color.yellow;
        BotanyControl.Record.list.Add("选择调查区域为正方形");
        
    }
    void onbutton553()
    {       
        array[1]++;
        if (array[1] % 2 != 0)
        {
            button553.GetComponent<Image>().color = Color.yellow;
            button552.GetComponent<Image>().color = new Color32(255,255,255,0);
            array[1]++;
            button554.SetActive(true);
            button555.SetActive(true);
            button556.SetActive(true);
        }
        else
        {
            button553.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        }
        BotanyControl.colorVanish();
        button1.GetComponent<Image>().color = Color.yellow;
        BotanyControl.Record.list1.Add("选择调查区域为长方形");
    }
    void onbutton555()
    {
        array[2]++;
        if (array[2] % 2 != 0)
        {
            button555.GetComponent<Image>().color = Color.yellow;
            button556.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            array[2]++;
        }
        else
        {
            button555.GetComponent<Image>().color = new Color32(255, 255, 255, 0);

        }
        BotanyControl.Record.list.Add("选择调查方法为五点取样法");
    }
    void onbutton556()
    {
        array[3]++;
        if (array[3] % 2 != 0)
        {
            button556.GetComponent<Image>().color = Color.yellow;
            button555.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            array[3]++;
        }
        else
        {
            button556.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        }
        BotanyControl.Record.list1.Add("选择调查方法为等距取样法");
    }
   public void delete()
    {
        Button58.SetActive(false);       
    }

    private void onbuttonStar()
    {      
        if ((button552.GetComponent<Image>().color==Color.yellow)&&(button555.GetComponent<Image>().color == Color.yellow))
        {
            Image6.SetActive(false);
            BotanyControl.Image2.SetActive(true);
            BotanyControl.Image3.SetActive(true);
            BotanyControl.Record.list.Add("开始(正方形区域的五点取样法)");
        }
        else if ((button553.GetComponent<Image>().color == Color.yellow) && (button556.GetComponent<Image>().color == Color.yellow))
        {
            Image6.SetActive(false);
            BotanyControl.Image4.SetActive(true);
            BotanyControl.Image5.SetActive(true);
            BotanyControl.Record.list1.Add("开始（长方形区域的等距取样法)");
        }  else
        {
            Button58.SetActive(true);
            BotanyControl.Record.list.Add("出现提示：区域和方法搭配错误，请重新选择");
            BotanyControl.Record.list1.Add("出现提示：区域和方法搭配错误，请重新选择");
        }        
    }
    public void buttonback()
    {
        SceneManager.LoadScene(1);
        //BotanyControl.Record.list.Add("返回到实验原理、目的和方法界面");
        //BotanyControl.Record.list1.Add("返回到实验原理、目的和方法界面");
    }

}
