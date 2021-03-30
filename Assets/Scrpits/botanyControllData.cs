using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class botanyControllData
{
    public InputField[,,] inputFields = new InputField[2,5,3];
    public Text[,,] txtScore = new Text[2, 5, 3];
    public GameObject[,] Button = new GameObject[2, 5];
    public GameObject[,] ButtonBack = new GameObject[2, 5];
}
