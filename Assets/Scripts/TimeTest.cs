using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    float timmer = 0;
    private void Start()
    {
        //��Ϸ��ʼ������������ʱ��
        Debug.Log(Time.time);
        //ʱ������
        Debug.Log(Time.timeScale);
        //�̶�ʱ����
        Debug.Log(Time.fixedDeltaTime);
        //��һ֡����һ֡����Ҫ��ʱ��
        Debug.Log(Time.deltaTime);

    }
    //60fps ÿ֡����Ҫ��ʱ���� 1/60 120fps ʱ���� 1/120
    private void Update()
    {
        timmer += Time.deltaTime;

        //Debug.Log(timmer);

        if(timmer > 3)
        {
            Debug.Log("Timer > 3s");
        }
    }
}
