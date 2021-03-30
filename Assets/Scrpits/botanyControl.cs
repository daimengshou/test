using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using System.Text;
using NPOI.XWPF.UserModel;
using NPOI.OpenXmlFormats.Wordprocessing;

public class botanyControl : MonoBehaviour {

    //记录操作过程
    private string path1;
    private string path2;
    private string filePath1;
    private string filePath2;
    string[,] stringRecord = new string[8, 7];

    public Record Record;
    public GameObject[] doubleBotany;
    public GameObject[] singleBotany;
    GameObject SingleBotany;
    GameObject DoubleBotany;

    //控制输出
    bool isput1=false;
    bool isput2=false;

    //bool isOutWord = false;
  
    //存放所有的植物
    List<GameObject> AllBotany = new List<GameObject>();

    private GameObject button2;
    private GameObject button3;
    private GameObject button4;

    public Test5control test5Control;

    private Text Texttime5;
    private Text Texttime3;

    private GameObject buttonphoto2;
    private Button buttoninfor2;
    private Button inforback2;
    private GameObject text2;

    private GameObject buttonphoto4;
    private Button buttoninfor4;
    private Button inforback4;
    private GameObject text4;

    int count2 = 8;
    int count4 = 9;

    float[,] Demo1 = new float[10, 2];
    float[,] Demo4 = new float[12, 2];

    int[] Demo3 = new int[] { 0, 1, 3, 4, 5, 7, 8, 9 };
    int[] Demo6 = new int[] { 0, 1, 3, 4, 5, 6, 9, 10, 11 };
   
    //存储用户输入植物的株数
    float botany5211;
    float botany5212;
    float botany5213;

    float botany5221;
    float botany5222;
    float botany5223;

    float botany5231;
    float botany5232;
    float botany5233;

    float botany5241;
    float botany5242;
    float botany5243;

    float botany5251;
    float botany5252;
    float botany5253;

    float botany5411;
    float botany5412;
    float botany5413;

    float botany5421;
    float botany5422;
    float botany5423;

    float botany5431;
    float botany5432;
    float botany5433;

    float botany5441;
    float botany5442;
    float botany5443;

    float botany5451;
    float botany5452;
    float botany5453;

    float a521 = 0;
    float a522 = 0;
    float a523 = 0;
    float a524 = 0;
    float a525 = 0;

    float a541 = 0;
    float a542 = 0;
    float a543 = 0;
    float a544 = 0;
    float a545 = 0;

    //用户输入的样本植物株树
    private InputField inputField5211;
    private InputField inputField5212;
    private InputField inputField5213;

    private InputField inputField5221;
    private InputField inputField5222;
    private InputField inputField5223;

    private InputField inputField5231;
    private InputField inputField5232;
    private InputField inputField5233;

    private InputField inputField5241;
    private InputField inputField5242;
    private InputField inputField5243;

    private InputField inputField5251;
    private InputField inputField5252;
    private InputField inputField5253;

    private InputField inputField5411;
    private InputField inputField5412;
    private InputField inputField5413;

    private InputField inputField5421;
    private InputField inputField5422;
    private InputField inputField5423;

    private InputField inputField5431;
    private InputField inputField5432;
    private InputField inputField5433;

    private InputField inputField5441;
    private InputField inputField5442;
    private InputField inputField5443;

    private InputField inputField5451;
    private InputField inputField5452;
    private InputField inputField5453;
    
    //样本实际出现植物的株树
    private Text txtScore5211;
    private Text txtScore5212;
    private Text txtScore5213;

    private Text txtScore5221;
    private Text txtScore5222;
    private Text txtScore5223;

    private Text txtScore5231;
    private Text txtScore5232;
    private Text txtScore5233;

    private Text txtScore5241;
    private Text txtScore5242;
    private Text txtScore5243;

    private Text txtScore5251;
    private Text txtScore5252;
    private Text txtScore5253;

    private Text txtScore5411;
    private Text txtScore5412;
    private Text txtScore5413;

    private Text txtScore5421;
    private Text txtScore5422;
    private Text txtScore5423;

    private Text txtScore5431;
    private Text txtScore5432;
    private Text txtScore5433;

    private Text txtScore5441;
    private Text txtScore5442;
    private Text txtScore5443;

    private Text txtScore5451;
    private Text txtScore5452;
    private Text txtScore5453;

    private Text tetScore31;
    private Text tetScore32;
    private Text tetScore33;

    private Text tetScore51;
    private Text tetScore52;
    private Text tetScore53;

    float botany1;
    float botany2;
    float botany3;

    //五点取样对应的样地
    private GameObject Button521;
    private GameObject Button522;
    private GameObject Button523;
    private GameObject Button524;
    private GameObject Button525;

    private GameObject ButtonBack521;
    private GameObject ButtonBack522;
    private GameObject ButtonBack523;
    private GameObject ButtonBack524;
    private GameObject ButtonBack525;

    //等距取样对应的样地
    private GameObject Button541;
    private GameObject Button542;
    private GameObject Button543;
    private GameObject Button544;
    private GameObject Button545;

    private GameObject ButtonBack541;
    private GameObject ButtonBack542;
    private GameObject ButtonBack543;
    private GameObject ButtonBack544;
    private GameObject ButtonBack545;

    private Button ButtonCount3;
    private Button buttonback21;

    private Button ButtonCount5;
    private Button buttonback41;
   
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    public GameObject Image5;

    private XWPFDocument doc = new XWPFDocument();

    void Start () {
      
        path1 = Application.dataPath + "\\五点取样法操作过程.txt";
        path2 = Application.dataPath + "\\等距取样法操作过程.txt";
        filePath1 = Application.dataPath + "\\中学生生物实验报告(正方形区域的五点取样法).docx";
        filePath2 = Application.dataPath + "\\中学生生物实验报告(长方形区域的等距取样法).docx";
        Link();
        
        buttonphoto2.SetActive(false);
        text2.SetActive(false);
        buttonphoto4.SetActive(false);
        text4.SetActive(false);
       
        buttoninfor2.onClick.AddListener(onbuttoninfor2);
        inforback2.onClick.AddListener(oninforback2);
        buttoninfor4.onClick.AddListener(onbuttoninfor4);
        inforback4.onClick.AddListener(oninforback4);

        score();
        position52();

        ButtonBack521.GetComponent<Button>().onClick.AddListener(onButtonBack521);
        ButtonBack522.GetComponent<Button>().onClick.AddListener(onButtonBack522);
        ButtonBack523.GetComponent<Button>().onClick.AddListener(onButtonBack523);
        ButtonBack524.GetComponent<Button>().onClick.AddListener(onButtonBack524);
        ButtonBack525.GetComponent<Button>().onClick.AddListener(onButtonBack525);

        ButtonBack541.GetComponent<Button>().onClick.AddListener(onButtonBack541);
        ButtonBack542.GetComponent<Button>().onClick.AddListener(onButtonBack542);
        ButtonBack543.GetComponent<Button>().onClick.AddListener(onButtonBack543);
        ButtonBack544.GetComponent<Button>().onClick.AddListener(onButtonBack544);
        ButtonBack545.GetComponent<Button>().onClick.AddListener(onButtonBack545);

        buttonback21.onClick.AddListener(onbuttonback21);
        buttonback41.onClick.AddListener(onbuttonback41);

        ButtonCount3.onClick.AddListener(buttonCount3);
        ButtonCount5.onClick.AddListener(buttonCount5);
        
    }

    public XWPFParagraph SetCellText(XWPFDocument doc, XWPFTable table, string setText)
    {
        //table中的文字格式设置  
        CT_P para = new CT_P();
        XWPFParagraph pCell = new XWPFParagraph(para, table.Body);
        pCell.Alignment = ParagraphAlignment.LEFT;//字体居中  
        pCell.VerticalAlignment = NPOI.XWPF.UserModel.TextAlignment.CENTER;//字体居中  

        XWPFRun r1c1 = pCell.CreateRun();
        r1c1.SetText(setText);
        r1c1.FontSize = 10;
        r1c1.FontFamily = "华文楷体";
        //r1c1.SetTextPosition(20);//设置高度  
        return pCell;
    }

    private void CreateParagraph()
    {
        XWPFParagraph paragraph1 = doc.CreateParagraph();
        paragraph1.Alignment = ParagraphAlignment.LEFT;
        XWPFRun run = paragraph1.CreateRun();
        run.FontSize = 18;
        run.FontFamily = "宋体";
        run.SetText("        中学生生物实验报告");
        run.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run1 = paragraph1.CreateRun();
        run1.FontSize = 14;
        run1.FontFamily = "宋体";
        run1.SetText("一、实验名称");
        run1.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run2 = paragraph1.CreateRun();
        run2.FontSize = 14;
        run2.FontFamily = "宋体";
        run2.SetText("用样方法调查草地中某种双子叶植物的种群密度。");
        run2.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run3 = paragraph1.CreateRun();
        run3.FontSize = 14;
        run3.FontFamily = "宋体";
        run3.SetText("二、实验目的");
        run3.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run4 = paragraph1.CreateRun();
        run4.FontSize = 14;
        run4.FontFamily = "宋体";
        run4.SetText("利用虚拟植物和可视化技术，开发交互式模拟实验尝试用样方法调查植物的种群密度。");
        run4.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run5 = paragraph1.CreateRun();
        run5.FontSize = 14;
        run5.FontFamily = "宋体";
        run5.SetText("三、实验工具");
        run5.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run6 = paragraph1.CreateRun();
        run6.FontSize = 14;
        run6.FontFamily = "宋体";
        run6.SetText("PC端和Android端手机。");
        run6.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run7 = paragraph1.CreateRun();
        run7.FontSize = 14;
        run7.FontFamily = "宋体";
        run7.SetText("四、实验步骤");
        run7.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run8 = paragraph1.CreateRun();
        run8.FontSize = 14;
        run8.FontFamily = "宋体";
        run8.SetText("（1）选择区域和方法。");
        run8.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run9 = paragraph1.CreateRun();
        run9.FontSize = 14;
        run9.FontFamily = "宋体";
        run9.SetText("（2）查看植物信息。");
        run9.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run10 = paragraph1.CreateRun();
        run10.FontSize = 14;
        run10.FontFamily = "宋体";
        run10.SetText("（3）计数样方植物。");
        run10.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run11 = paragraph1.CreateRun();
        run11.FontSize = 14;
        run11.FontFamily = "宋体";
        run11.SetText("（4）计算种群密度。");
        run11.AddBreak(BreakType.TEXTWRAPPING);//换行

        XWPFRun run12 = paragraph1.CreateRun();
        run12.FontSize = 14;
        run12.FontFamily = "宋体";
        run12.SetText("五、实验结果");
        run12.AddBreak(BreakType.TEXTWRAPPING);//换行

        
        //生成表格
        var table1 = doc.CreateTable(4, 7);
        table1.Width = 5500;
        //table1.RemoveRow(0);
        //生成列宽
        table1.SetColumnWidth(0, 600);

        if (Record.isOutWord == false)
        {
            XWPFRun run13 = paragraph1.CreateRun();
            run13.FontSize = 14;
            run13.FontFamily = "宋体";
            run13.SetText("正方形区域的五点取样法。");           

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    table1.GetRow(j).GetCell(i).SetParagraph(SetCellText(doc, table1, stringRecord[j, i]));
                    Debug.Log(stringRecord[j, i]);
                }
            }
            Record.isOutWord = !Record.isOutWord;
            Debug.Log(Record.isOutWord);

            FileStream fs = new FileStream(filePath1, FileMode.Create);
            doc.Write(fs);
            fs.Close();
            fs.Dispose();
            Debug.Log("写入成功");
        }
        else
        {
            XWPFRun run14 = paragraph1.CreateRun();
            run14.FontSize = 14;
            run14.FontFamily = "宋体";
            run14.SetText("长方形区域的等距取样法。");

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    table1.GetRow(j).GetCell(i).SetParagraph(SetCellText(doc, table1, stringRecord[j+4, i]));
                    Debug.Log(stringRecord[j, i]);
                }
            }
           
            Record.isOutWord = !Record.isOutWord;
            Debug.Log(Record.isOutWord);

            FileStream fs = new FileStream(filePath2, FileMode.Create);
            doc.Write(fs);
            fs.Close();
            fs.Dispose();
            Debug.Log("写入成功");
        }
        
    }

    private void addstring()
    {
        stringRecord[0, 0] = "植物";       
        stringRecord[0, 1] = "样本1";
        stringRecord[0, 2] = "样本2";
        stringRecord[0, 3] = "样本3";
        stringRecord[0, 4] = "样本4";
        stringRecord[0, 5] = "样本5";
        stringRecord[0, 6] = "种群密度";

        stringRecord[1, 0] = "女菀";
        stringRecord[1, 1] = botany5211.ToString();
        stringRecord[1, 2] = botany5221.ToString();
        stringRecord[1, 3] = botany5231.ToString();
        stringRecord[1, 4] = botany5241.ToString();
        stringRecord[1, 5] = botany5251.ToString();
        stringRecord[1, 6] = ((float.Parse(txtScore5211.text) + float.Parse(txtScore5221.text) + float.Parse(txtScore5231.text) + float.Parse(txtScore5241.text) + float.Parse(txtScore5251.text)) / 5).ToString();

        stringRecord[2, 0] = "薰衣草";
        stringRecord[2, 1] = botany5212.ToString();
        stringRecord[2, 2] = botany5222.ToString();
        stringRecord[2, 3] = botany5232.ToString();
        stringRecord[2, 4] = botany5242.ToString();
        stringRecord[2, 5] = botany5252.ToString();
        stringRecord[2, 6] = ((float.Parse(txtScore5212.text) + float.Parse(txtScore5222.text) + float.Parse(txtScore5232.text) + float.Parse(txtScore5242.text) + float.Parse(txtScore5252.text)) / 5).ToString();

        stringRecord[3, 0] = "万寿菊";
        stringRecord[3, 1] = botany5213.ToString();
        stringRecord[3, 2] = botany5223.ToString();
        stringRecord[3, 3] = botany5233.ToString();
        stringRecord[3, 4] = botany5243.ToString();
        stringRecord[3, 5] = botany5253.ToString();
        stringRecord[3, 6] = ((float.Parse(txtScore5213.text) + float.Parse(txtScore5223.text) + float.Parse(txtScore5233.text) + float.Parse(txtScore5243.text) + float.Parse(txtScore5253.text)) / 5).ToString();

        stringRecord[4, 0] = "植物";
        stringRecord[4, 1] = "样本1";
        stringRecord[4, 2] = "样本2";
        stringRecord[4, 3] = "样本3";
        stringRecord[4, 4] = "样本4";
        stringRecord[4, 5] = "样本5";
        stringRecord[4, 6] = "种群密度";

        stringRecord[5, 0] = "女菀";
        stringRecord[5, 1] = botany5411.ToString();
        stringRecord[5, 2] = botany5421.ToString();
        stringRecord[5, 3] = botany5431.ToString();
        stringRecord[5, 4] = botany5441.ToString();
        stringRecord[5, 5] = botany5451.ToString();
        stringRecord[5, 6] = ((float.Parse(txtScore5411.text) + float.Parse(txtScore5421.text) + float.Parse(txtScore5431.text) + float.Parse(txtScore5441.text) + float.Parse(txtScore5241.text)) / 5).ToString();

        stringRecord[6, 0] = "薰衣草";
        stringRecord[6, 1] = botany5412.ToString();
        stringRecord[6, 2] = botany5422.ToString();
        stringRecord[6, 3] = botany5432.ToString();
        stringRecord[6, 4] = botany5442.ToString();
        stringRecord[6, 5] = botany5452.ToString();
        stringRecord[6, 6] = ((float.Parse(txtScore5412.text) + float.Parse(txtScore5422.text) + float.Parse(txtScore5432.text) + float.Parse(txtScore5442.text) + float.Parse(txtScore5452.text)) / 5).ToString();

        stringRecord[7, 0] = "万寿菊";
        stringRecord[7, 1] = botany5413.ToString();
        stringRecord[7, 2] = botany5423.ToString();
        stringRecord[7, 3] = botany5433.ToString();
        stringRecord[7, 4] = botany5443.ToString();
        stringRecord[7, 5] = botany5453.ToString();
        stringRecord[7, 6] = ((float.Parse(txtScore5413.text) + float.Parse(txtScore5423.text) + float.Parse(txtScore5433.text) + float.Parse(txtScore5443.text) + float.Parse(txtScore5453.text)) / 5).ToString();
    }

    //实时获取当天的时间信息
    private void Update()
    {       
        DateTime NowTime = DateTime.Now.ToLocalTime();
        Texttime5.text = NowTime.ToString("yyyy-MM-dd HH:mm:ss");
        Texttime3.text = NowTime.ToString("yyyy-MM-dd HH:mm:ss");
    }

    //将脚本中的定义控件与Unity3D中的控件一一对应
    private void Link()
    {

        Button521 = GameObject.Find("Button521");
        Button522 = GameObject.Find("Button522");
        Button523 = GameObject.Find("Button523");
        Button524 = GameObject.Find("Button524");
        Button525 = GameObject.Find("Button525");

        ButtonBack521 = GameObject.Find("buttonBack521");
        ButtonBack522 = GameObject.Find("buttonBack522");
        ButtonBack523 = GameObject.Find("buttonBack523");
        ButtonBack524 = GameObject.Find("buttonBack524");
        ButtonBack525 = GameObject.Find("buttonBack525");

        Button541 = GameObject.Find("Button541");
        Button542 = GameObject.Find("Button542");
        Button543 = GameObject.Find("Button543");
        Button544 = GameObject.Find("Button544");
        Button545 = GameObject.Find("Button545");

        ButtonBack541 = GameObject.Find("buttonBack541");
        ButtonBack542 = GameObject.Find("buttonBack542");
        ButtonBack543 = GameObject.Find("buttonBack543");
        ButtonBack544 = GameObject.Find("buttonBack544");
        ButtonBack545 = GameObject.Find("buttonBack545");

        button2 = GameObject.Find("Button2");
        button3 = GameObject.Find("Button3");
        button4 = GameObject.Find("Button4");

        txtScore5211 = GameObject.Find("txtScore5211").GetComponent<Text>();
        txtScore5212 = GameObject.Find("txtScore5212").GetComponent<Text>();
        txtScore5213 = GameObject.Find("txtScore5213").GetComponent<Text>();

        txtScore5221 = GameObject.Find("txtScore5221").GetComponent<Text>();
        txtScore5222 = GameObject.Find("txtScore5222").GetComponent<Text>();
        txtScore5223 = GameObject.Find("txtScore5223").GetComponent<Text>();

        txtScore5231 = GameObject.Find("txtScore5231").GetComponent<Text>();
        txtScore5232 = GameObject.Find("txtScore5232").GetComponent<Text>();
        txtScore5233 = GameObject.Find("txtScore5233").GetComponent<Text>();

        txtScore5241 = GameObject.Find("txtScore5241").GetComponent<Text>();
        txtScore5242 = GameObject.Find("txtScore5242").GetComponent<Text>();
        txtScore5243 = GameObject.Find("txtScore5243").GetComponent<Text>();

        txtScore5251 = GameObject.Find("txtScore5251").GetComponent<Text>();
        txtScore5252 = GameObject.Find("txtScore5252").GetComponent<Text>();
        txtScore5253 = GameObject.Find("txtScore5253").GetComponent<Text>();

        txtScore5411 = GameObject.Find("txtScore5411").GetComponent<Text>();
        txtScore5412 = GameObject.Find("txtScore5412").GetComponent<Text>();
        txtScore5413 = GameObject.Find("txtScore5413").GetComponent<Text>();

        txtScore5421 = GameObject.Find("txtScore5421").GetComponent<Text>();
        txtScore5422 = GameObject.Find("txtScore5422").GetComponent<Text>();
        txtScore5423 = GameObject.Find("txtScore5423").GetComponent<Text>();

        txtScore5431 = GameObject.Find("txtScore5431").GetComponent<Text>();
        txtScore5432 = GameObject.Find("txtScore5432").GetComponent<Text>();
        txtScore5433 = GameObject.Find("txtScore5433").GetComponent<Text>();

        txtScore5441 = GameObject.Find("txtScore5441").GetComponent<Text>();
        txtScore5442 = GameObject.Find("txtScore5442").GetComponent<Text>();
        txtScore5443 = GameObject.Find("txtScore5443").GetComponent<Text>();

        txtScore5451 = GameObject.Find("txtScore5451").GetComponent<Text>();
        txtScore5452 = GameObject.Find("txtScore5452").GetComponent<Text>();
        txtScore5453 = GameObject.Find("txtScore5453").GetComponent<Text>();

        tetScore31 = GameObject.Find("txtScore31").GetComponent<Text>();
        tetScore32 = GameObject.Find("txtScore32").GetComponent<Text>();
        tetScore33 = GameObject.Find("txtScore33").GetComponent<Text>();

        tetScore51 = GameObject.Find("txtScore51").GetComponent<Text>();
        tetScore52 = GameObject.Find("txtScore52").GetComponent<Text>();
        tetScore53 = GameObject.Find("txtScore53").GetComponent<Text>();

        ButtonCount3 = GameObject.Find("ButtonCount3").GetComponent<Button>();
        ButtonCount5 = GameObject.Find("ButtonCount5").GetComponent<Button>();
        buttonback21 = GameObject.Find("buttonBack21").GetComponent<Button>();
        buttonback41 = GameObject.Find("buttonBack41").GetComponent<Button>();

        Image2 = GameObject.Find("Image2");
        Image3 = GameObject.Find("Image3");
        Image4 = GameObject.Find("Image4");
        Image5 = GameObject.Find("Image5");

        buttonphoto2 = GameObject.Find("buttonPhoto2");
        buttoninfor2=GameObject.Find("botanyinfor2").GetComponent<Button>();
        inforback2=GameObject.Find("inforback2").GetComponent<Button>();
        text2=GameObject.Find("Text2");

        buttonphoto4 = GameObject.Find("buttonPhoto4");
        buttoninfor4 = GameObject.Find("botanyinfor4").GetComponent<Button>();
        inforback4 = GameObject.Find("inforback4").GetComponent<Button>();
        text4 = GameObject.Find("Text4");

        Texttime3 = GameObject.Find("Texttime3").GetComponent<Text>();
        Texttime5 = GameObject.Find("Texttime5").GetComponent<Text>();
       
        inputField5211 = GameObject.Find("InputField5211").GetComponent<InputField>();
        inputField5212 = GameObject.Find("InputField5212").GetComponent<InputField>();
        inputField5213 = GameObject.Find("InputField5213").GetComponent<InputField>();

        inputField5221 = GameObject.Find("InputField5221").GetComponent<InputField>();
        inputField5222 = GameObject.Find("InputField5222").GetComponent<InputField>();
        inputField5223 = GameObject.Find("InputField5223").GetComponent<InputField>();

        inputField5231 = GameObject.Find("InputField5231").GetComponent<InputField>();
        inputField5232 = GameObject.Find("InputField5232").GetComponent<InputField>();
        inputField5233 = GameObject.Find("InputField5233").GetComponent<InputField>();

        inputField5241 = GameObject.Find("InputField5241").GetComponent<InputField>();
        inputField5242 = GameObject.Find("InputField5242").GetComponent<InputField>();
        inputField5243 = GameObject.Find("InputField5243").GetComponent<InputField>();

        inputField5251 = GameObject.Find("InputField5251").GetComponent<InputField>();
        inputField5252 = GameObject.Find("InputField5252").GetComponent<InputField>();
        inputField5253 = GameObject.Find("InputField5253").GetComponent<InputField>();

        inputField5411 = GameObject.Find("InputField5411").GetComponent<InputField>();
        inputField5412 = GameObject.Find("InputField5412").GetComponent<InputField>();
        inputField5413 = GameObject.Find("InputField5413").GetComponent<InputField>();

        inputField5421 = GameObject.Find("InputField5421").GetComponent<InputField>();
        inputField5422 = GameObject.Find("InputField5422").GetComponent<InputField>();
        inputField5423 = GameObject.Find("InputField5423").GetComponent<InputField>();

        inputField5431 = GameObject.Find("InputField5431").GetComponent<InputField>();
        inputField5432 = GameObject.Find("InputField5432").GetComponent<InputField>();
        inputField5433 = GameObject.Find("InputField5433").GetComponent<InputField>();

        inputField5441 = GameObject.Find("InputField5441").GetComponent<InputField>();
        inputField5442 = GameObject.Find("InputField5442").GetComponent<InputField>();
        inputField5443 = GameObject.Find("InputField5443").GetComponent<InputField>();

        inputField5451 = GameObject.Find("InputField5451").GetComponent<InputField>();
        inputField5452 = GameObject.Find("InputField5452").GetComponent<InputField>();
        inputField5453 = GameObject.Find("InputField5453").GetComponent<InputField>();
    }

    void vanish2()
    {
        Button521.SetActive(false);
        Button522.SetActive(false);
        Button523.SetActive(false);
        Button524.SetActive(false);
        Button525.SetActive(false);
    }
    void vanish4()
    {
        Button541.SetActive(false);
        Button542.SetActive(false);
        Button543.SetActive(false);
        Button544.SetActive(false);
        Button545.SetActive(false);
    }

    public void colorVanish()
    {
        test5Control.button1.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        button2.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        button3.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        button4.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    void great2()
    {
        Button521.SetActive(true);
        Button522.SetActive(true);
        Button523.SetActive(true);
        Button524.SetActive(true);
        Button525.SetActive(true);
    }
    void great4()
    {
        Button541.SetActive(true);
        Button542.SetActive(true);
        Button543.SetActive(true);
        Button544.SetActive(true);
        Button545.SetActive(true);
    }
    void score()
    {        
        ButtonBack521.SetActive(false);
        ButtonBack522.SetActive(false);
        ButtonBack523.SetActive(false);
        ButtonBack524.SetActive(false);
        ButtonBack525.SetActive(false);

        ButtonBack541.SetActive(false);
        ButtonBack542.SetActive(false);
        ButtonBack543.SetActive(false);
        ButtonBack544.SetActive(false);
        ButtonBack545.SetActive(false);

        txtScore5211.enabled = false;
        txtScore5212.enabled = false;
        txtScore5213.enabled = false;
        txtScore5221.enabled = false;
        txtScore5222.enabled = false;
        txtScore5223.enabled = false;
        txtScore5231.enabled = false;
        txtScore5232.enabled = false;
        txtScore5233.enabled = false;
        txtScore5241.enabled = false;
        txtScore5242.enabled = false;
        txtScore5243.enabled = false;
        txtScore5251.enabled = false;
        txtScore5252.enabled = false;
        txtScore5253.enabled = false;

        txtScore5411.enabled = false;
        txtScore5412.enabled = false;
        txtScore5413.enabled = false;
        txtScore5421.enabled = false;
        txtScore5422.enabled = false;
        txtScore5423.enabled = false;
        txtScore5431.enabled = false;
        txtScore5432.enabled = false;
        txtScore5433.enabled = false;
        txtScore5441.enabled = false;
        txtScore5442.enabled = false;
        txtScore5443.enabled = false;
        txtScore5451.enabled = false;
        txtScore5452.enabled = false;
        txtScore5453.enabled = false;
    }

    //将样地的空间固定
    void position52()
    {
        Demo1[0, 0] = UnityEngine.Random.Range(290, 300);
        Demo1[1, 0] = UnityEngine.Random.Range(340, 350);
        Demo1[2, 0] = UnityEngine.Random.Range(375, 385);
        Demo1[3, 0] = UnityEngine.Random.Range(420, 425);
        Demo1[4, 0] = UnityEngine.Random.Range(465, 470);

        Demo1[5, 0] = UnityEngine.Random.Range(290, 300);
        Demo1[6, 0] = UnityEngine.Random.Range(340, 350);
        Demo1[7, 0] = UnityEngine.Random.Range(375, 385);
        Demo1[8, 0] = UnityEngine.Random.Range(420, 425);
        Demo1[9, 0] = UnityEngine.Random.Range(465, 470);

        Demo1[0, 1] = UnityEngine.Random.Range(100, 115);
        Demo1[1, 1] = UnityEngine.Random.Range(100, 115);
        Demo1[2, 1] = UnityEngine.Random.Range(100, 115);
        Demo1[3, 1] = UnityEngine.Random.Range(100, 115);
        Demo1[4, 1] = UnityEngine.Random.Range(100, 115);

        Demo1[5, 1] = UnityEngine.Random.Range(10, 30);
        Demo1[6, 1] = UnityEngine.Random.Range(10, 30);
        Demo1[7, 1] = UnityEngine.Random.Range(10, 30);
        Demo1[8, 1] = UnityEngine.Random.Range(10, 30);
        Demo1[9, 1] = UnityEngine.Random.Range(10, 30);

        Demo4[0, 0] = UnityEngine.Random.Range(248, 250);
        Demo4[1, 0] = UnityEngine.Random.Range(295, 300);
        Demo4[2, 0] = UnityEngine.Random.Range(330, 355);
        Demo4[3, 0] = UnityEngine.Random.Range(395, 400);
        Demo4[4, 0] = UnityEngine.Random.Range(440, 450);
        Demo4[5, 0] = UnityEngine.Random.Range(490, 495);

        Demo4[6, 0] = UnityEngine.Random.Range(248, 250);
        Demo4[7, 0] = UnityEngine.Random.Range(295, 300);
        Demo4[8, 0] = UnityEngine.Random.Range(330, 355);
        Demo4[9, 0] = UnityEngine.Random.Range(395, 400);
        Demo4[10, 0] = UnityEngine.Random.Range(440, 450);
        Demo4[11, 0] = UnityEngine.Random.Range(490, 495);

        Demo4[0, 1] = UnityEngine.Random.Range(100, 115);
        Demo4[1, 1] = UnityEngine.Random.Range(100, 115);
        Demo4[2, 1] = UnityEngine.Random.Range(100, 115);
        Demo4[3, 1] = UnityEngine.Random.Range(100, 115);
        Demo4[4, 1] = UnityEngine.Random.Range(100, 115);
        Demo4[5, 1] = UnityEngine.Random.Range(100, 115);

        Demo4[6, 1] = UnityEngine.Random.Range(10, 35);
        Demo4[7, 1] = UnityEngine.Random.Range(10, 35);
        Demo4[8, 1] = UnityEngine.Random.Range(10, 35);
        Demo4[9, 1] = UnityEngine.Random.Range(10, 35);
        Demo4[10, 1] = UnityEngine.Random.Range(10, 35);
        Demo4[11, 1] = UnityEngine.Random.Range(10, 35);
    }

    void onbuttoninfor2()
    {
        buttonphoto2.SetActive(true);
        Image3.SetActive(false);
        buttoninfor2.GetComponent<Image>().color = Color.yellow;
        colorVanish();
        button2.GetComponent<Image>().color = Color.yellow;
        Record.list.Add("点击查看植物信息");
    }
    void oninforback2()
    {
        buttonphoto2.SetActive(false);
        Image3.SetActive(true);
        buttoninfor2.GetComponent<Image>().color = new Color32(0,0,0,40) ;
    }
    void onbuttoninfor4()
    {
        buttonphoto4.SetActive(true);
        Image5.SetActive(false);
        buttoninfor4.GetComponent<Image>().color = Color.yellow;
        colorVanish();
        button2.GetComponent<Image>().color = Color.yellow;
        Record.list1.Add("点击查看植物信息");
    }
    void oninforback4()
    {
        buttonphoto4.SetActive(false);
        Image5.SetActive(true);
        buttoninfor4.GetComponent<Image>().color = new Color32(0,0,0,40);
    }

    void onbuttonback21()
    {
        Record.list.Add("返回到调查区域和方法选择界面");
        if (isput1==false)
        {
            FileStream fileStream1 = new FileStream(path1, FileMode.OpenOrCreate);
            StreamWriter sw1 = new StreamWriter(fileStream1, Encoding.UTF8);
            foreach (var item in Record.list)
            {
                sw1.WriteLine(item);
            }
            sw1.Close();
            fileStream1.Close();
            isput1 = !isput1;
        }
        SceneManager.LoadScene("Test5");
        colorVanish();
        

    }
    void onbuttonback41()
    {
        Record.list.Add("返回到调查区域和方法选择界面");
        if (isput2==false)
        {
            FileStream fileStream2 = new FileStream(path2, FileMode.OpenOrCreate);
            StreamWriter sw2 = new StreamWriter(fileStream2, Encoding.UTF8);
            foreach (var item in Record.list1)
            {
                sw2.WriteLine(item);
            }
            sw2.Close();
            fileStream2.Close();
            isput2 = !isput2;
        }
        SceneManager.LoadScene("Test5");
        colorVanish();
       
    }
    
    /// <summary>
    /// 计算五点取样法的种群密度
    /// </summary>
    void buttonCount3()
    {
        double a1 = (float.Parse(txtScore5211.text) + float.Parse(txtScore5221.text) + float.Parse(txtScore5231.text) + float.Parse(txtScore5241.text) + float.Parse(txtScore5251.text)) / 5;
        double a2 = (float.Parse(txtScore5212.text) + float.Parse(txtScore5222.text) + float.Parse(txtScore5232.text) + float.Parse(txtScore5242.text) + float.Parse(txtScore5252.text)) / 5;
        double a3 = (float.Parse(txtScore5213.text) + float.Parse(txtScore5223.text) + float.Parse(txtScore5233.text) + float.Parse(txtScore5243.text) + float.Parse(txtScore5253.text)) / 5;
        tetScore31.text = System.Math.Round(a1, 2).ToString();
        tetScore32.text = System.Math.Round(a2, 2).ToString();
        tetScore33.text = System.Math.Round(a3, 2).ToString();

        colorVanish();
        button4.GetComponent<Image>().color = Color.yellow;
        Record.list.Add("点击计算种群密度");
        Record.isOutWord = false;
        addstring();
        CreateParagraph();
    }
    /// <summary>
    /// 计算等距取样法的种群密度
    /// </summary>
    void buttonCount5()
    {
        double a1 = (float.Parse(txtScore5411.text) + float.Parse(txtScore5421.text) + float.Parse(txtScore5431.text) + float.Parse(txtScore5441.text) + float.Parse(txtScore5451.text)) / 5;
        double a2 = (float.Parse(txtScore5412.text) + float.Parse(txtScore5422.text) + float.Parse(txtScore5432.text) + float.Parse(txtScore5442.text) + float.Parse(txtScore5452.text)) / 5;
        double a3 = (float.Parse(txtScore5413.text) + float.Parse(txtScore5423.text) + float.Parse(txtScore5433.text) + float.Parse(txtScore5443.text) + float.Parse(txtScore5453.text)) / 5;
        tetScore51.text = System.Math.Round(a1, 2).ToString();
        tetScore52.text = System.Math.Round(a2, 2).ToString();
        tetScore53.text = System.Math.Round(a3, 2).ToString();

        colorVanish();
        button4.GetComponent<Image>().color = Color.yellow;
        Record.list1.Add("点击计算种群密度");
        Record.isOutWord = true;
        addstring();
        CreateParagraph();
    }   
   
    //存储用户输入的植物株数
    public void test5211(string arg0)
    {
        botany5211 = float.Parse(inputField5211.text);       
    }
    public void test5212(string arg0)
    {
        botany5212 = float.Parse(inputField5212.text);

    }
    public void test5213(string arg0)
    {
        botany5213 = float.Parse(inputField5213.text);

    }

    public void test5221(string arg0)
    {
        botany5221 = float.Parse(inputField5221.text);

    }
    public void test5222(string arg0)
    {
        botany5222 = float.Parse(inputField5222.text);

    }
    public void test5223(string arg0)
    {
        botany5223 = float.Parse(inputField5223.text);

    }

    public void test5231(string arg0)
    {
        botany5231 = float.Parse(inputField5231.text);

    }
    public void test5232(string arg0)
    {
        botany5232 = float.Parse(inputField5232.text);

    }
    public void test5233(string arg0)
    {
        botany5233 = float.Parse(inputField5233.text);

    }

    public void test5241(string arg0)
    {
        botany5241 = float.Parse(inputField5241.text);

    }
    public void test5242(string arg0)
    {
        botany5242 = float.Parse(inputField5242.text);

    }
    public void test5243(string arg0)
    {
        botany5243 = float.Parse(inputField5243.text);

    }

    public void test5251(string arg0)
    {
        botany5251 = float.Parse(inputField5251.text);

    }
    public void test5252(string arg0)
    {
        botany5252 = float.Parse(inputField5252.text);

    }
    public void test5253(string arg0)
    {
        botany5253 = float.Parse(inputField5253.text);

    }

    public void test5411(string arg0)
    {
        botany5411 = float.Parse(inputField5411.text);

    }
    public void test5412(string arg0)
    {
        botany5412 = float.Parse(inputField5412.text);

    }
    public void test5413(string arg0)
    {
        botany5413 = float.Parse(inputField5413.text);

    }

    public void test5421(string arg0)
    {
        botany5421 = float.Parse(inputField5421.text);

    }
    public void test5422(string arg0)
    {
        botany5422 = float.Parse(inputField5422.text);

    }
    public void test5423(string arg0)
    {
        botany5423 = float.Parse(inputField5423.text);

    }

    public void test5431(string arg0)
    {
        botany5431 = float.Parse(inputField5431.text);

    }
    public void test5432(string arg0)
    {
        botany5432 = float.Parse(inputField5432.text);

    }
    public void test5433(string arg0)
    {
        botany5433 = float.Parse(inputField5433.text);

    }

    public void test5441(string arg0)
    {
        botany5441 = float.Parse(inputField5441.text);

    }
    public void test5442(string arg0)
    {
        botany5442 = float.Parse(inputField5442.text);

    }
    public void test5443(string arg0)
    {
        botany5443 = float.Parse(inputField5443.text);

    }

    public void test5451(string arg0)
    {
        botany5451 = float.Parse(inputField5451.text);

    }
    public void test5452(string arg0)
    {
        botany5452 = float.Parse(inputField5452.text);

    }
    public void test5453(string arg0)
    {
        botany5453 = float.Parse(inputField5453.text);

    }

    public void onButtonBack521()
    {
        Record.list.Add("计数样方1中的双子叶植物");
        if ((botany1 == botany5211) && (botany2 == botany5212) && (botany3 == botany5213))
        {
            a521 = 0;
        }
        else
        {
            a521++;
        }
        if (a521%2==0)
        {
            text2.SetActive(false);
            Image image2 = Image2.GetComponent<Image>();
            image2.sprite = Resources.Load<Sprite>("Imagephoto/image2");
            foreach (GameObject allBotany in AllBotany)
            {
                Destroy(allBotany);
            }
            text2.GetComponent<Text>().text = "计数植物数量";
            text2.SetActive(false);
            ButtonBack521.SetActive(false);
            great2();
            txtScore5211.enabled = false;
            txtScore5212.enabled = false;
            txtScore5213.enabled = false;
            Button521.GetComponent<Image>().color = new Color32(238,80,83,200);
        }
        else
        {
            txtScore5211.enabled = true;
            txtScore5212.enabled = true;
            txtScore5213.enabled = true;
            a521++;
            text2.GetComponent<Text>().text = "输入错误,请根据提示进行修改";
            text2.SetActive(true);
            Record.list.Add("提示：输入错误,请根据提示进行修改");
        }
       
    }

    public void onButtonBack522()
    {
        Record.list.Add("计数样方2中的双子叶植物");
        if ((botany1 == botany5221) && (botany2 == botany5222) && (botany3 == botany5223))
        {
            a522 = 0;
        }
        else
        {
            a522++;
        }
        if (a522 % 2 == 0)
        {
            text2.SetActive(false);
            Image image2 = Image2.GetComponent<Image>();
            image2.sprite = Resources.Load<Sprite>("Imagephoto/image2");
            foreach (GameObject allBotany in AllBotany)
            {
                Destroy(allBotany);
            }
            text2.GetComponent<Text>().text = "计数植物数量";
            text2.SetActive(false);
            ButtonBack522.SetActive(false);
            great2();
            txtScore5221.enabled = false;
            txtScore5222.enabled = false;
            txtScore5223.enabled = false;
          
            Button522.GetComponent<Image>().color = new Color32(238, 80, 83, 200);
        }
        else
        {
            txtScore5221.enabled = true;
            txtScore5222.enabled = true;
            txtScore5223.enabled = true;
            a522++;
            text2.GetComponent<Text>().text = "输入错误请根据提示进行修改";
            text2.SetActive(true);
            Record.list.Add("提示：输入错误,请根据提示进行修改");
        }

    }

    public void onButtonBack523()
    {
        Record.list.Add("计数样方3中的双子叶植物");
        if ((botany1 == botany5231) && (botany2 == botany5232) && (botany3 == botany5233))
        {
            a523 =0;
        }
        else
        {
            a523++;
        }

        if (a523 % 2 == 0)
        {
            text2.SetActive(false);
            Image image2 = Image2.GetComponent<Image>();
            image2.sprite = Resources.Load<Sprite>("Imagephoto/image2");
            foreach (GameObject allBotany in AllBotany)
            {
                Destroy(allBotany);
            }
            text2.GetComponent<Text>().text = "计数植物数量";
            text2.SetActive(false);
            ButtonBack523.SetActive(false);
            great2();
            txtScore5231.enabled = false;
            txtScore5232.enabled = false;
            txtScore5233.enabled = false;
           
            Button523.GetComponent<Image>().color = new Color32(238, 80, 83, 200);
        }
        else
        {
            txtScore5231.enabled = true;
            txtScore5232.enabled = true;
            txtScore5233.enabled = true;
            a523++;
            text2.GetComponent<Text>().text = "输入错误请根据提示进行修改";
            text2.SetActive(true);
            Record.list.Add("提示：输入错误,请根据提示进行修改");
        }
    }

    public void onButtonBack524()
    {
        Record.list.Add("计数样方4中的双子叶植物");
        if ((botany1 == botany5241) && (botany2 == botany5242) && (botany3 == botany5243))
        {
            a524 = 0;
        }
        else
        {
            a524++;
        }
        if (a524 % 2 == 0)
        {
            text2.SetActive(false);
            Image image2 = Image2.GetComponent<Image>();
            image2.sprite = Resources.Load<Sprite>("Imagephoto/image2");
            foreach (GameObject allBotany in AllBotany)
            {
                Destroy(allBotany);
            }
            text2.GetComponent<Text>().text = "计数植物数量";
            text2.SetActive(false);
            ButtonBack524.SetActive(false);
            great2();
            txtScore5241.enabled = false;
            txtScore5242.enabled = false;
            txtScore5243.enabled = false;
            
            Button524.GetComponent<Image>().color = new Color32(238, 80, 83, 200);
        }
        else
        {
            txtScore5241.enabled = true;
            txtScore5242.enabled = true;
            txtScore5243.enabled = true;
            a524++;
            text2.GetComponent<Text>().text = "输入错误请根据提示进行修改";
            text2.SetActive(true);
            Record.list.Add("提示：输入错误,请根据提示进行修改");
        }
    }

    public void onButtonBack525()
    {
        Record.list.Add("计数样方5中的双子叶植物");
        if ((botany1 == botany5251) && (botany2 == botany5252) && (botany3 == botany5253))
        {
            a525 = 0;
        }
        else
        {
            a525++;
        }

        if (a525 % 2 == 0)
        {            
            text2.SetActive(false);
            Image image2 = Image2.GetComponent<Image>();
            image2.sprite = Resources.Load<Sprite>("Imagephoto/image2");
            foreach (GameObject allBotany in AllBotany)
            {
                Destroy(allBotany);
            }
            text2.GetComponent<Text>().text = "计数植物数量";
            text2.SetActive(false);
            ButtonBack525.SetActive(false);
            great2();
            txtScore5251.enabled = false;
            txtScore5252.enabled = false;
            txtScore5253.enabled = false;
         
            Button525.GetComponent<Image>().color = new Color32(238, 80, 83, 200);
        }
        else
        {
            txtScore5251.enabled = true;
            txtScore5252.enabled = true;
            txtScore5253.enabled = true;
            a525++;
            text2.GetComponent<Text>().text = "输入错误请根据提示进行修改";
            text2.SetActive(true);
            Record.list.Add("提示：输入错误,请根据提示进行修改");
        }
    }

    public void onButtonBack541()
    {
        Record.list1.Add("计数样方1中的双子叶植物");
        if ((botany1 == botany5411) && (botany2 == botany5412) && (botany3 == botany5413))
        {
            a541 = 0;
        }
        else
        {
            a541++;
        }
        if (a541 % 2 == 0)
        {
            text4.SetActive(false);
            Image image4 = Image4.GetComponent<Image>();
            image4.sprite = Resources.Load<Sprite>("Imagephoto/image4");
            foreach (GameObject allBotany in AllBotany)
            {
                Destroy(allBotany);
            }
            text4.GetComponent<Text>().text = "计数植物数量";
            text4.SetActive(false);
            ButtonBack541.SetActive(false);
            great4();
            txtScore5411.enabled = false;
            txtScore5412.enabled = false;
            txtScore5413.enabled = false;
            Button541.GetComponent<Image>().color = new Color32(238, 80, 83, 200);

        }
        else
        {
            txtScore5411.enabled = true;
            txtScore5412.enabled = true;
            txtScore5413.enabled = true;
            a541++;
            text4.GetComponent<Text>().text = "输入错误请根据提示进行修改";
            text4.SetActive(true);
            Record.list1.Add("提示：输入错误,请根据提示进行修改");
        }
    }

    public void onButtonBack542()
    {
        Record.list1.Add("计数样方2中的双子叶植物");
        if ((botany1 == botany5421) && (botany2 == botany5422) && (botany3 == botany5423))
        {
            a542 = 0;
        }
        else
        {
            a542++;
        }

        if (a542 % 2 == 0)
        {
            text4.SetActive(false);
            Image image4 = Image4.GetComponent<Image>();
            image4.sprite = Resources.Load<Sprite>("Imagephoto/image4");
            foreach (GameObject allBotany in AllBotany)
            {
                Destroy(allBotany);
            }
            text4.GetComponent<Text>().text = "计数植物数量";
            text4.SetActive(false);
            ButtonBack542.SetActive(false);
            great4();
            txtScore5421.enabled = false;
            txtScore5422.enabled = false;
            txtScore5423.enabled = false;
            Button542.GetComponent<Image>().color = new Color32(238, 80, 83, 200);

        }
        else
        {
            txtScore5421.enabled = true;
            txtScore5422.enabled = true;
            txtScore5423.enabled = true;
            a542++;
            text4.GetComponent<Text>().text = "输入错误请根据提示进行修改";
            text4.SetActive(true);
            Record.list1.Add("提示：输入错误,请根据提示进行修改");
        }
    }

    public void onButtonBack543()
    {
        Record.list1.Add("计数样方3中的双子叶植物");
        if ((botany1 == botany5431) && (botany2 == botany5432) && (botany3 == botany5433))
        {
            a543 = 0;
        }
        else
        {
            a543++;
        }
        if (a543 % 2 == 0)
        {
            text4.SetActive(false);
            Image image4 = Image4.GetComponent<Image>();
            image4.sprite = Resources.Load<Sprite>("Imagephoto/image4");
            foreach (GameObject allBotany in AllBotany)
            {
                Destroy(allBotany);
            }
            text4.GetComponent<Text>().text = "计数植物数量";
            text4.SetActive(false);
            ButtonBack543.SetActive(false);
            great4();
            txtScore5431.enabled = false;
            txtScore5432.enabled = false;
            txtScore5433.enabled = false;
            Button543.GetComponent<Image>().color = new Color32(238, 80, 83, 200);
        }
        else
        {
            txtScore5431.enabled = true;
            txtScore5432.enabled = true;
            txtScore5433.enabled = true;
            a543++;
            text4.GetComponent<Text>().text = "输入错误请根据提示进行修改";
            text4.SetActive(true);
            Record.list1.Add("提示：输入错误,请根据提示进行修改");
        }
    }

    public void onButtonBack544()
    {
        Record.list1.Add("计数样方4中的双子叶植物");
        if ((botany1 == botany5441) && (botany2 == botany5442) && (botany3 == botany5443))
        {
            a544 = 0;
        }
        else
        {
            a544++;
        }
        if (a544 % 2 == 0)
        {
            text4.SetActive(false);
            Image image4 = Image4.GetComponent<Image>();
            image4.sprite = Resources.Load<Sprite>("Imagephoto/image4");
            foreach (GameObject allBotany in AllBotany)
            {
                Destroy(allBotany);
            }
            text4.GetComponent<Text>().text = "计数植物数量";
            text4.SetActive(false);
            ButtonBack544.SetActive(false);
            great4();
            txtScore5441.enabled = false;
            txtScore5442.enabled = false;
            txtScore5443.enabled = false;
            Button544.GetComponent<Image>().color = new Color32(238, 80, 83, 200);
        }
        else
        {
            txtScore5441.enabled = true;
            txtScore5442.enabled = true;
            txtScore5443.enabled = true;
            a544++;
            text4.GetComponent<Text>().text = "输入错误请根据提示进行修改";
            text4.SetActive(true);
            Record.list1.Add("提示：输入错误,请根据提示进行修改");
        }
    }

    public void onButtonBack545()
    {
        Record.list1.Add("计数样方5中的双子叶植物");
        if ((botany1 == botany5451) && (botany2 == botany5452) && (botany3 == botany5453))
        {
            a545 = 0;
        }
        else
        {
            a545++;
        }
        if (a545 % 2 == 0)
        {
            text4.SetActive(false);
            Image image4 = Image4.GetComponent<Image>();
            image4.sprite = Resources.Load<Sprite>("Imagephoto/image4");
            foreach (GameObject allBotany in AllBotany)
            {
                Destroy(allBotany);
            }
            text4.GetComponent<Text>().text = "计数植物数量";
            text4.SetActive(false);
            ButtonBack545.SetActive(false);
            great4();
            txtScore5451.enabled = false;
            txtScore5452.enabled = false;
            txtScore5453.enabled = false;
            Button545.GetComponent<Image>().color = new Color32(238, 80, 83, 200);
        }
        else
        {
            txtScore5451.enabled = true;
            txtScore5452.enabled = true;
            txtScore5453.enabled = true;
            a545++;
            text4.GetComponent<Text>().text = "输入错误请根据提示进行修改";
            text4.SetActive(true);
            Record.list1.Add("提示：输入错误,请根据提示进行修改");
        }
    }

    /// <summary>
    /// 点击样地随机生成植物的数量
    /// </summary>
   public void onButton521()
    {
        colorVanish();
        button3.GetComponent<Image>().color = Color.yellow;

        vanish2();
        ButtonBack521.SetActive(true);
        text2.SetActive(true);
        text2.GetComponent<Text>().text = "计数植物数量,在样本1中输入";
        Image image2 = Image2.GetComponent<Image>();
        image2.sprite = Resources.Load<Sprite>("Imagephoto/grassland3");
        
        float[,] Demo2 = new float[count2, 2];
        
        botany1 = 0;
        botany2 = 0;
        botany3 = 0;
        for (int i = 0; i < count2; i++)
        {
            Demo2[i, 0] = Demo1[Demo3[i], 0];
            Demo2[i, 1] = Demo1[Demo3[i], 1];

            int a = UnityEngine.Random.Range(0, 2);
            float botanyAngle1 = -90;

            int singleIndex;
            int doubleIndex;

            if (a == 0)
            {
                singleIndex = UnityEngine.Random.Range(0, singleBotany.Length);
                SingleBotany = Instantiate<GameObject>(singleBotany[singleIndex], new Vector3(Demo2[i, 0], Demo2[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(SingleBotany);
            }
            else
            {
                doubleIndex = UnityEngine.Random.Range(0, doubleBotany.Length);

                if ((doubleIndex == 0)|| (doubleIndex==1))
                {
                    botanyAngle1 = 0;
                }
              
                    if (doubleIndex == 0)
                        botany1++;
                    if (doubleIndex == 1)
                        botany2++;
                    if (doubleIndex == 2)
                        botany3++;
                
                DoubleBotany = Instantiate<GameObject>(doubleBotany[doubleIndex], new Vector3(Demo2[i, 0], Demo2[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(DoubleBotany);
            }
        }
        
        txtScore5211.text = botany1.ToString();
        txtScore5212.text = botany2.ToString();
        txtScore5213.text = botany3.ToString();
        Button521.GetComponent<Button>().enabled = false;
        Record.list.Add("点击第1块样地");
    }
   public void onButton522()
    {
        colorVanish();
        button3.GetComponent<Image>().color = Color.yellow;

        vanish2();
        ButtonBack522.SetActive(true);
        text2.SetActive(true);
        text2.GetComponent<Text>().text = "计数植物数量,在样本2中输入";
        Image image2 = Image2.GetComponent<Image>();
        image2.sprite = Resources.Load<Sprite>("Imagephoto/grassland3");
      
        float[,] Demo2 = new float[count2, 2];
       
        botany1 = 0;
        botany2 = 0;
        botany3 = 0;
        for (int i = 0; i < count2; i++)
        {

            Demo2[i, 0] = Demo1[Demo3[i], 0];
            Demo2[i, 1] = Demo1[Demo3[i], 1];

            int a = UnityEngine.Random.Range(0, 2);
            float botanyAngle1 = -90;
         
            int singleIndex;
            int doubleIndex;

            if (a == 0)
            {
                singleIndex = UnityEngine.Random.Range(0, singleBotany.Length);
                SingleBotany = Instantiate<GameObject>(singleBotany[singleIndex], new Vector3(Demo2[i, 0], Demo2[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(SingleBotany);
            }
            else
            {
                doubleIndex = UnityEngine.Random.Range(0, doubleBotany.Length);

                if ((doubleIndex == 0) || (doubleIndex == 1))
                {
                    botanyAngle1 = 0;
                }

                if (doubleIndex == 0)
                        botany1++;
                    if (doubleIndex == 1)
                        botany2++;
                    if (doubleIndex == 2)
                        botany3++;
                
                DoubleBotany = Instantiate<GameObject>(doubleBotany[doubleIndex], new Vector3(Demo2[i, 0], Demo2[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(DoubleBotany);
            }
        }       
        txtScore5221.text = botany1.ToString();
        txtScore5222.text = botany2.ToString();
        txtScore5223.text = botany3.ToString();
        Button522.GetComponent<Button>().enabled = false;
        Record.list.Add("点击第2块样地");
    }
   public void onButton523()
    {
        colorVanish();
        button3.GetComponent<Image>().color = Color.yellow;

        vanish2();
        ButtonBack523.SetActive(true);
        text2.SetActive(true);
        text2.GetComponent<Text>().text = "计数植物数量,在样本3中输入";
        Image image2 = Image2.GetComponent<Image>();
        image2.sprite = Resources.Load<Sprite>("Imagephoto/grassland3");
       
        float[,] Demo2 = new float[count2, 2];
        
        botany1 = 0;
        botany2 = 0;
        botany3 = 0;
        for (int i = 0; i < count2; i++)
        {
            Demo2[i, 0] = Demo1[Demo3[i], 0];
            Demo2[i, 1] = Demo1[Demo3[i], 1];

            int a = UnityEngine.Random.Range(0, 2);
            float botanyAngle1 = -90;
            
            int singleIndex;
            int doubleIndex;

            if (a == 0)
            {
                singleIndex = UnityEngine.Random.Range(0, singleBotany.Length);
                SingleBotany = Instantiate<GameObject>(singleBotany[singleIndex], new Vector3(Demo2[i, 0], Demo2[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(SingleBotany);
            }
            else
            {
                doubleIndex = UnityEngine.Random.Range(0, doubleBotany.Length);

                if ((doubleIndex == 0) || (doubleIndex == 1))
                {
                    botanyAngle1 = 0;
                }

                if (doubleIndex == 0)
                        botany1++;
                    if (doubleIndex == 1)
                        botany2++;
                    if (doubleIndex == 2)
                        botany3++;
                
                DoubleBotany = Instantiate<GameObject>(doubleBotany[doubleIndex], new Vector3(Demo2[i, 0], Demo2[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(DoubleBotany);
            }
        }
       
        txtScore5231.text = botany1.ToString();
        txtScore5232.text = botany2.ToString();
        txtScore5233.text = botany3.ToString();
        Button523.GetComponent<Button>().enabled = false;
        Record.list.Add("点击第3块样地");
    }
   public void onButton524()
    {
        colorVanish();
        button3.GetComponent<Image>().color = Color.yellow;

        vanish2();
        ButtonBack524.SetActive(true);
        text2.SetActive(true);
        text2.GetComponent<Text>().text = "计数植物数量,在样本4中输入";
        Image image2 = Image2.GetComponent<Image>();
        image2.sprite = Resources.Load<Sprite>("Imagephoto/grassland3");
        
        float[,] Demo2 = new float[count2, 2];
       
        botany1 = 0;
        botany2 = 0;
        botany3 = 0;
        for (int i = 0; i < count2; i++)
        {
            Demo2[i, 0] = Demo1[Demo3[i], 0];
            Demo2[i, 1] = Demo1[Demo3[i], 1];

            int a = UnityEngine.Random.Range(0, 2);
            float botanyAngle1 = -90;
       
            int singleIndex;
            int doubleIndex;

            if (a == 0)
            {
                singleIndex = UnityEngine.Random.Range(0, singleBotany.Length);
                SingleBotany = Instantiate<GameObject>(singleBotany[singleIndex], new Vector3(Demo2[i, 0], Demo2[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(SingleBotany);
            }
            else
            {
                doubleIndex = UnityEngine.Random.Range(0, doubleBotany.Length);

                if ((doubleIndex == 0) || (doubleIndex == 1))
                {
                    botanyAngle1 = 0;
                }

                if (doubleIndex == 0)
                        botany1++;
                    if (doubleIndex == 1)
                        botany2++;
                    if (doubleIndex == 2)
                        botany3++;
                
                DoubleBotany = Instantiate<GameObject>(doubleBotany[doubleIndex], new Vector3(Demo2[i, 0], Demo2[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(DoubleBotany);
            }

        }

        txtScore5241.text = botany1.ToString();
        txtScore5242.text = botany2.ToString();
        txtScore5243.text = botany3.ToString();
        Button524.GetComponent<Button>().enabled = false;
        Record.list.Add("点击第4块样地");
    }
   public void onButton525()
    {
        colorVanish();
        button3.GetComponent<Image>().color = Color.yellow;

        vanish2();
        ButtonBack525.SetActive(true);
        text2.SetActive(true);
        text2.GetComponent<Text>().text = "计数植物数量,在样本5中输入";
        Image image2 = Image2.GetComponent<Image>();
        image2.sprite = Resources.Load<Sprite>("Imagephoto/grassland3");
       
        float[,] Demo2 = new float[count2, 2];
       
        botany1 = 0;
        botany2 = 0;
        botany3 = 0;
        for (int i = 0; i < count2; i++)
        {
            Demo2[i, 0] = Demo1[Demo3[i], 0];
            Demo2[i, 1] = Demo1[Demo3[i], 1];

            int a = UnityEngine.Random.Range(0, 2);
            float botanyAngle1 = -90;
           
            int singleIndex;
            int doubleIndex;

            if (a == 0)
            {
                singleIndex = UnityEngine.Random.Range(0, singleBotany.Length);
                SingleBotany = Instantiate<GameObject>(singleBotany[singleIndex], new Vector3(Demo2[i, 0], Demo2[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(SingleBotany);
            }
            else
            {
                doubleIndex = UnityEngine.Random.Range(0, doubleBotany.Length);

                if ((doubleIndex == 0) || (doubleIndex == 1))
                {
                    botanyAngle1 = 0;                   
                }

                if (doubleIndex == 0)
                        botany1++;
                    if (doubleIndex == 1)
                        botany2++;
                    if (doubleIndex == 2)
                        botany3++;
                
                DoubleBotany = Instantiate<GameObject>(doubleBotany[doubleIndex], new Vector3(Demo2[i, 0], Demo2[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(DoubleBotany);
            }
        }       
        txtScore5251.text = botany1.ToString();
        txtScore5252.text = botany2.ToString();
        txtScore5253.text = botany3.ToString();
        Button525.GetComponent<Button>().enabled = false;
        Record.list.Add("点击第5块样地");
    }

   public void onButton541()
    {
        colorVanish();
        button3.GetComponent<Image>().color = Color.yellow;

        vanish4();
        ButtonBack541.SetActive(true);
        text4.SetActive(true);
        text4.GetComponent<Text>().text = "计数植物数量,在样本1中输入";
        Image image4 = Image4.GetComponent<Image>();
        image4.sprite = Resources.Load<Sprite>("Imagephoto/grassland3");

        float[,] Demo5 = new float[count4, 2];
      
        botany1 = 0;
        botany2 = 0;
        botany3 = 0;

        for (int i = 0; i < count4; i++)
        {
            Demo5[i, 0] = Demo4[Demo6[i], 0];
            Demo5[i, 1] = Demo4[Demo6[i], 1];

            int a = UnityEngine.Random.Range(0, 2);
            float botanyAngle1 = -90;
           
            int singleIndex;
            int doubleIndex;

            if (a == 0)
            {
                singleIndex = UnityEngine.Random.Range(0, singleBotany.Length);
                SingleBotany = Instantiate<GameObject>(singleBotany[singleIndex], new Vector3(Demo5[i, 0], Demo5[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(SingleBotany);
            }
            else
            {
                doubleIndex = UnityEngine.Random.Range(0, doubleBotany.Length);
               
                if ((doubleIndex == 0) || (doubleIndex == 1))
                {
                    botanyAngle1 = 0;                  
                }

                if (doubleIndex == 0)
                        botany1++;
                    if (doubleIndex == 1)
                        botany2++;
                    if (doubleIndex == 2)
                        botany3++;
                
                DoubleBotany = Instantiate<GameObject>(doubleBotany[doubleIndex], new Vector3(Demo5[i, 0], Demo5[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(DoubleBotany);
            }
        }
        txtScore5411.text = botany1.ToString();
        txtScore5412.text = botany2.ToString();
        txtScore5413.text = botany3.ToString();
        Button541.GetComponent<Button>().enabled = false;
        Record.list1.Add("点击第1块样地");
    }
   public void onButton542()
    {
        colorVanish();
        button3.GetComponent<Image>().color = Color.yellow;

        vanish4();
        ButtonBack542.SetActive(true);
        text4.SetActive(true);
        text4.GetComponent<Text>().text = "计数植物数量,在样本2中输入";
        Image image4 = Image4.GetComponent<Image>();
        image4.sprite = Resources.Load<Sprite>("Imagephoto/grassland3");
      
        float[,] Demo5 = new float[count4, 2];
        
        botany1 = 0;
        botany2 = 0;
        botany3 = 0;

        for (int i = 0; i < count4; i++)
        {
            Demo5[i, 0] = Demo4[Demo6[i], 0];
            Demo5[i, 1] = Demo4[Demo6[i], 1];

            int a = UnityEngine.Random.Range(0, 2);
            float botanyAngle1 = -90;
           
            int singleIndex;
            int doubleIndex;

            if (a == 0)
            {
                singleIndex = UnityEngine.Random.Range(0, singleBotany.Length);
                SingleBotany = Instantiate<GameObject>(singleBotany[singleIndex], new Vector3(Demo5[i, 0], Demo5[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(SingleBotany);
            }
            else
            {
                doubleIndex = UnityEngine.Random.Range(0, doubleBotany.Length);

                if ((doubleIndex == 0) || (doubleIndex == 1))
                {
                    botanyAngle1 = 0;                    
                }

                if (doubleIndex == 0)
                        botany1++;
                    if (doubleIndex == 1)
                        botany2++;
                    if (doubleIndex == 2)
                        botany3++;
                
                DoubleBotany = Instantiate<GameObject>(doubleBotany[doubleIndex], new Vector3(Demo5[i, 0], Demo5[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(DoubleBotany);
            }
        }
        txtScore5421.text = botany1.ToString();
        txtScore5422.text = botany2.ToString();
        txtScore5423.text = botany3.ToString();
        Button542.GetComponent<Button>().enabled = false;
        Record.list1.Add("点击第2块样地");
    }
   public void onButton543()
    {
        colorVanish();
        button3.GetComponent<Image>().color = Color.yellow;

        vanish4();
        ButtonBack543.SetActive(true);
        text4.SetActive(true);
        text4.GetComponent<Text>().text = "计数植物数量,在样本3中输入";
        Image image4 = Image4.GetComponent<Image>();
        image4.sprite = Resources.Load<Sprite>("Imagephoto/grassland3");
        
        float[,] Demo5 = new float[count4, 2];
      
        botany1 = 0;
        botany2 = 0;
        botany3 = 0;

        for (int i = 0; i < count4; i++)
        {
            Demo5[i, 0] = Demo4[Demo6[i], 0];
            Demo5[i, 1] = Demo4[Demo6[i], 1];

            int a = UnityEngine.Random.Range(0, 2);
            float botanyAngle1 = -90;
          
            int singleIndex;
            int doubleIndex;

            if (a == 0)
            {
                singleIndex = UnityEngine.Random.Range(0, singleBotany.Length);
                SingleBotany = Instantiate<GameObject>(singleBotany[singleIndex], new Vector3(Demo5[i, 0], Demo5[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(SingleBotany);
            }
            else
            {
                doubleIndex = UnityEngine.Random.Range(0, doubleBotany.Length);

                if ((doubleIndex == 0) || (doubleIndex == 1))
                {
                    botanyAngle1 = 0;                  
                }

                if (doubleIndex == 0)
                        botany1++;
                    if (doubleIndex == 1)
                        botany2++;
                    if (doubleIndex == 2)
                        botany3++;
                
                DoubleBotany = Instantiate<GameObject>(doubleBotany[doubleIndex], new Vector3(Demo5[i, 0], Demo5[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(DoubleBotany);
            }
        }
        txtScore5431.text = botany1.ToString();
        txtScore5432.text = botany2.ToString();
        txtScore5433.text = botany3.ToString();
        Button543.GetComponent<Button>().enabled = false;
        Record.list1.Add("点击第3块样地");
    }
   public void onButton544()
    {
        colorVanish();
        button3.GetComponent<Image>().color = Color.yellow;

        vanish4();
        ButtonBack544.SetActive(true);
        text4.SetActive(true);
        text4.GetComponent<Text>().text = "计数植物数量,在样本4中输入";
        Image image4 = Image4.GetComponent<Image>();
        image4.sprite = Resources.Load<Sprite>("Imagephoto/grassland3");
       
        float[,] Demo5 = new float[count4, 2];
       
        botany1 = 0;
        botany2 = 0;
        botany3 = 0;

        for (int i = 0; i < count4; i++)
        {
            Demo5[i, 0] = Demo4[Demo6[i], 0];
            Demo5[i, 1] = Demo4[Demo6[i], 1];

            int a = UnityEngine.Random.Range(0, 2);
            float botanyAngle1 = -90;
          
            int singleIndex;
            int doubleIndex;

            if (a == 0)
            {
                singleIndex = UnityEngine.Random.Range(0, singleBotany.Length);
                SingleBotany = Instantiate<GameObject>(singleBotany[singleIndex], new Vector3(Demo5[i, 0], Demo5[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(SingleBotany);
            }
            else
            {
                doubleIndex = UnityEngine.Random.Range(0, doubleBotany.Length);             

                if ((doubleIndex == 0) || (doubleIndex == 1))
                {
                    botanyAngle1 = 0;                   
                }

                if (doubleIndex == 0)
                        botany1++;
                    if (doubleIndex == 1)
                        botany2++;
                    if (doubleIndex == 2)
                        botany3++;
                
                DoubleBotany = Instantiate<GameObject>(doubleBotany[doubleIndex], new Vector3(Demo5[i, 0], Demo5[i, 1], -200), Quaternion.Euler(botanyAngle1,0, 0));
                AllBotany.Add(DoubleBotany);
            }
        }
        txtScore5441.text = botany1.ToString();
        txtScore5442.text = botany2.ToString();
        txtScore5443.text = botany3.ToString();
        Button544.GetComponent<Button>().enabled = false;
        Record.list1.Add("点击第4块样地");
    }
   public void onButton545()
    {
        colorVanish();
        button3.GetComponent<Image>().color = Color.yellow;

        vanish4();
        ButtonBack545.SetActive(true);
        text4.SetActive(true);
        text4.GetComponent<Text>().text = "计数植物数量,在样本5中输入";
        Image image4 = Image4.GetComponent<Image>();
        image4.sprite = Resources.Load<Sprite>("Imagephoto/grassland3");
      
        float[,] Demo5 = new float[count4, 2];
     
        botany1 = 0;
        botany2 = 0;
        botany3 = 0;

        for (int i = 0; i < count4; i++)
        {
            Demo5[i, 0] = Demo4[Demo6[i], 0];
            Demo5[i, 1] = Demo4[Demo6[i], 1];

            int a = UnityEngine.Random.Range(0, 2);
            float botanyAngle1 = -90;
      
            int singleIndex;
            int doubleIndex;

            if (a == 0)
            {
                singleIndex = UnityEngine.Random.Range(0, singleBotany.Length);
                SingleBotany = Instantiate<GameObject>(singleBotany[singleIndex], new Vector3(Demo5[i, 0], Demo5[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(SingleBotany);
            }
            else
            {
                doubleIndex = UnityEngine.Random.Range(0, doubleBotany.Length);

                if ((doubleIndex == 0) || (doubleIndex == 1))
                {
                    botanyAngle1 = 0;                  
                }

                if (doubleIndex == 0)
                        botany1++;
                    if (doubleIndex == 1)
                        botany2++;
                    if (doubleIndex == 2)
                        botany3++;
                
                DoubleBotany = Instantiate<GameObject>(doubleBotany[doubleIndex], new Vector3(Demo5[i, 0], Demo5[i, 1], -200), Quaternion.Euler(botanyAngle1, 0, 0));
                AllBotany.Add(DoubleBotany);
            }

        }
        txtScore5451.text = botany1.ToString();
        txtScore5452.text = botany2.ToString();
        txtScore5453.text = botany3.ToString();
        Button545.GetComponent<Button>().enabled = false;
        Record.list1.Add("点击第5块样地");
    }

   public void onbutton526()
    {             
        Record.list.Add("进入实验重点、难点讨论问题界面");

        if (isput1 == false)
        {
            FileStream fileStream1 = new FileStream(path1, FileMode.OpenOrCreate);
            StreamWriter sw1 = new StreamWriter(fileStream1, Encoding.UTF8);
            foreach (var item in Record.list)
            {
                sw1.WriteLine(item);
            }
            sw1.Close();
            fileStream1.Close();
            isput1 = !isput1;
        }

        //addstring();
        //CreateParagraph();

        SceneManager.LoadScene("Test4");
    }
   public void onbutton546()
    {
        
        Record.list1.Add("进入实验重点、难点讨论问题界面");

        if (isput2==false)
        {
            FileStream fileStream2 = new FileStream(path2, FileMode.OpenOrCreate);
            StreamWriter sw2 = new StreamWriter(fileStream2, Encoding.UTF8);
            foreach (var item in Record.list1)
            {
                sw2.WriteLine(item);
            }
            sw2.Close();
            fileStream2.Close();
            isput2 = !isput2;
        }

        //addstring();
        //CreateParagraph();

        SceneManager.LoadScene("Test4");
    }
}
