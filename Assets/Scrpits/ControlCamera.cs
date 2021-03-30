using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public float speed;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * speed;//获取到键盘控制的方向*时间*速度，在input里面可以看到     左右
        float v = Input.GetAxis("Vertical") * Time.deltaTime * speed;  //deltaTime是上一帧和下一帧之间的时间      上下
        float z = Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * speed;//中间的滑轮
        Vector3 move = new Vector3(h, v, z);
        transform.Translate(move);
    }
}
