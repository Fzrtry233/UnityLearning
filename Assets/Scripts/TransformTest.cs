using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    private void Start()
    {
        ////获取位置
        //Debug.Log(transform.position);
        //Debug.Log(transform.localPosition);
        ////获取旋转
        //Debug.Log(transform.rotation);
        //Debug.Log(transform.localRotation);
        //Debug.Log(transform.eulerAngles);
        //Debug.Log(transform.localEulerAngles);
        ////获取缩放
        //Debug.Log(transform.localScale);
        ////向量
        //Debug.Log(transform.forward);
        //Debug.Log(transform.right);
        //Debug.Log(transform.up);

        //父子关系
        //GameObject parent = transform.parent.gameObject;
        //子物体个数
        //int num = transform.childCount;
        //解除与子物体的父子关系
        //transform.DetachChildren();
        //获取子物体
        Transform trans = transform.Find("Child");
        trans = trans.GetChild(0);
        //判断一个子物体是否是一个物体的子物体
        bool res = trans.IsChildOf(transform);
        Debug.Log(res);
        //设置为父物体
        trans.SetParent(transform);
    }
    private void Update()
    {
        //时刻看向原点
        //transform.LookAt(Vector3.zero);
        //旋转
        //transform.Rotate(Vector3.up,1);
        //绕某个点旋转
        //transform.RotateAround(Vector3.zero, Vector3.up, 5);
        //移动
        //transform.Translate(Vector3.forward);
    }
}
