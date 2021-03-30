using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomcount : MonoBehaviour
{
    //随机生成count个从小到大的0-14的数
    public static Randomcount Instance = null;
    public List<int> list1 = new List<int>();
    int count;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        count = Random.Range(8, 10);
        random();
    }

    public void random()
    {
        for (int i = 0; i < count; i++)
        {
            list1.Add(Random.Range(0, 15));

            for (int j = i - 1; j >= 0; j--)
            {
                if (list1[i] == list1[j])
                {
                    list1.RemoveAt(i);
                    i--;
                    break;
                }
            }
        }
        list1.Sort();

        int[] array = new int[count];
        for (int i = 0; i < count; i++)
        {
            array[i] = list1[i];
        }
    }

}
