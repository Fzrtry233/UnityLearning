using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisTest : MonoBehaviour
{
    private void Update()
    {
        //虚拟轴
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(horizontal + "   " + vertical);

        //虚拟按键
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("按下跳跃按键");
        }
        if (Input.GetButton("Jump"))
        {
            Debug.Log("持续按下跳跃按键");
        }
        if(Input.GetButtonUp("Jump"))
        {
            Debug.Log("松开了跳跃按键");
        }
    }
}
