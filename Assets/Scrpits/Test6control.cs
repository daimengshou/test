using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test6control : MonoBehaviour
{

    void Start()
    {
        
    }
    public void onbutton()
    {
        SceneManager.LoadScene("Test4");
    }
}
