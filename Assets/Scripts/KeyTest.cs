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
        //�����
        //������� 0��� 1�Ҽ� 2�м�
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("������������");
        }
        //��������������
        if(Input.GetMouseButton(0))
        {
            Debug.Log("��������������");
        }
        //���̧��
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("̧����������");
        }
        
        //���¼��̰���
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("������A");
        }
        //�������¼��̰���
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("����������A");
        }
        //̧���˼��̰���
        if(Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("̧����A");
        }
    }
}
