using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    private void Start()
    {
        ////��ȡλ��
        //Debug.Log(transform.position);
        //Debug.Log(transform.localPosition);
        ////��ȡ��ת
        //Debug.Log(transform.rotation);
        //Debug.Log(transform.localRotation);
        //Debug.Log(transform.eulerAngles);
        //Debug.Log(transform.localEulerAngles);
        ////��ȡ����
        //Debug.Log(transform.localScale);
        ////����
        //Debug.Log(transform.forward);
        //Debug.Log(transform.right);
        //Debug.Log(transform.up);

        //���ӹ�ϵ
        //GameObject parent = transform.parent.gameObject;
        //���������
        //int num = transform.childCount;
        //�����������ĸ��ӹ�ϵ
        //transform.DetachChildren();
        //��ȡ������
        Transform trans = transform.Find("Child");
        trans = trans.GetChild(0);
        //�ж�һ���������Ƿ���һ�������������
        bool res = trans.IsChildOf(transform);
        Debug.Log(res);
        //����Ϊ������
        trans.SetParent(transform);
    }
    private void Update()
    {
        //ʱ�̿���ԭ��
        //transform.LookAt(Vector3.zero);
        //��ת
        //transform.Rotate(Vector3.up,1);
        //��ĳ������ת
        //transform.RotateAround(Vector3.zero, Vector3.up, 5);
        //�ƶ�
        //transform.Translate(Vector3.forward);
    }
}
