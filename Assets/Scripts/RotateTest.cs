using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    private void Start()
    {
        //ŷ���� ��Ԫ��
        Vector3 rotate = new Vector3(0,30,0);
        Quaternion quaternion = Quaternion.identity;
        //ŷ����ת��Ϊ��Ԫ��
        quaternion = Quaternion.Euler(rotate);
        //��Ԫ��ת��Ϊŷ����
        rotate = quaternion.eulerAngles;
        //����һ������
        quaternion = Quaternion.LookRotation(new Vector3(0, 0, 0));
    }
}
