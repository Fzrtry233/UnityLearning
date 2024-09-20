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

        //������������֮��ļн�
        Debug.Log(Vector3.Angle(v, v2));
        //������������֮��ľ���
        Debug.Log(Vector3.Distance(v, v2));
        //���
        Debug.Log(Vector3.Dot(v, v2));
        //���
        Debug.Log(Vector3.Cross(v, v2));
        //��ֵ
        Debug.Log(Vector3.Lerp(Vector3.zero, Vector3.one, 0.5f));
        //������ģ
        Vector3 v3 = new Vector3(100, 100, 50);
        Debug.Log(v3.magnitude);
        //�淶��������
        Debug.Log(v3.normalized);
    }
}
