using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationTest : MonoBehaviour
{
    private void Start()
    {
        //��Ϸ�����ļ���·��(ֻ��,����ѹ��)
        Debug.Log(Application.dataPath + "/�½��ı��ĵ�.txt");
        //�־û��ļ�·��
        Debug.Log(Application.persistentDataPath);
        //StreamingAssets�ļ���·��(ֻ���������ļ�)
        Debug.Log(Application.streamingAssetsPath);
        //��ʱ�ļ�
        Debug.Log(Application.temporaryCachePath);
        //�����Ƿ��ں�̨����
        Debug.Log(Application.runInBackground);
        //��url
        //Application.OpenURL("https://space.bilibili.com/104506895?spm_id_from=333.1007.0.0");
        //�˳���Ϸ
        //Application.Quit();
    }
}
