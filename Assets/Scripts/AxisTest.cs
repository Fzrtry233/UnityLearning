using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisTest : MonoBehaviour
{
    private void Update()
    {
        //������
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(horizontal + "   " + vertical);

        //���ⰴ��
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("������Ծ����");
        }
        if (Input.GetButton("Jump"))
        {
            Debug.Log("����������Ծ����");
        }
        if(Input.GetButtonUp("Jump"))
        {
            Debug.Log("�ɿ�����Ծ����");
        }
    }
}
