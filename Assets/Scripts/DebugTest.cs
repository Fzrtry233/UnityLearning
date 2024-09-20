using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    private void Start()
    {
        //��ͨ��Ϣ
        Debug.Log("Test");
        //����
        Debug.LogWarning("Test01");
        //����
        Debug.LogError("Test02");
    }
    private void Update()
    {
        //����һ����
        Debug.DrawLine(Vector3.zero, Vector3.one, Color.blue);
        //����
        Debug.DrawRay(Vector3.zero, Vector3.up, Color.red);
    }
}
