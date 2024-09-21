using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTest : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        //鼠标点击
        //按下鼠标 0左键 1右键 2中键
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("按下了鼠标左键");
        }
        //持续按下鼠标左键
        if(Input.GetMouseButton(0))
        {
            Debug.Log("持续按下鼠标左键");
        }
        //鼠标抬起
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("抬起了鼠标左键");
        }
        
        //按下键盘按键
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("按下了A");
        }
        //持续按下键盘按键
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("持续按下了A");
        }
        //抬起了键盘按键
        if(Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("抬起了A");
        }
    }
}
