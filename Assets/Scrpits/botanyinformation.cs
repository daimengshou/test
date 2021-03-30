using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botanyinformation : MonoBehaviour
{
    public GameObject buttonphoto;
    public Button buttoninfor;
    public botanyControl BotanyCon;
    // Start is called before the first frame update
    void Start()
    {
        buttonphoto.SetActive(false);
        buttoninfor.onClick.AddListener(onbuttoninfor);
    }

    private void onbuttoninfor()
    {
        BotanyCon.Image3.SetActive(false);
        buttonphoto.SetActive(true);
    }

    void Update()
    {
        
    }
}
