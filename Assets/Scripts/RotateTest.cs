using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    private void Start()
    {
        //欧拉角 四元数
        Vector3 rotate = new Vector3(0,30,0);
        Quaternion quaternion = Quaternion.identity;
        //欧拉角转换为四元数
        quaternion = Quaternion.Euler(rotate);
        //四元数转换为欧拉角
        rotate = quaternion.eulerAngles;
        //看向一个物体
        quaternion = Quaternion.LookRotation(new Vector3(0, 0, 0));
    }
}
