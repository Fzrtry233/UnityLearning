using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    private void Start()
    {
        //普通信息
        Debug.Log("Test");
        //警告
        Debug.LogWarning("Test01");
        //错误
        Debug.LogError("Test02");
    }
    private void Update()
    {
        //绘制一条线
        Debug.DrawLine(Vector3.zero, Vector3.one, Color.blue);
        //射线
        Debug.DrawRay(Vector3.zero, Vector3.up, Color.red);
    }
}
