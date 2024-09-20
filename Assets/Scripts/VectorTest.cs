using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    private void Start()
    {
        Vector3 v = new Vector3(1, 1, 0.5f);

        v = Vector3.zero;

        v = Vector3.right;

        Vector3 v2 = Vector3.forward;

        //计算两个向量之间的夹角
        Debug.Log(Vector3.Angle(v, v2));
        //计算两个向量之间的距离
        Debug.Log(Vector3.Distance(v, v2));
        //点乘
        Debug.Log(Vector3.Dot(v, v2));
        //叉乘
        Debug.Log(Vector3.Cross(v, v2));
        //插值
        Debug.Log(Vector3.Lerp(Vector3.zero, Vector3.one, 0.5f));
        //向量的模
        Vector3 v3 = new Vector3(100, 100, 50);
        Debug.Log(v3.magnitude);
        //规范化的向量
        Debug.Log(v3.normalized);
    }
}
