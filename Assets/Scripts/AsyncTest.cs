using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncTest : MonoBehaviour
{
    AsyncOperation AO;
    float time;
    private void Start()
    {
        StartCoroutine(loadScene());
    }

    //Я�������첽����
    IEnumerator loadScene()
    {
        AO = SceneManager.LoadSceneAsync("Default");
        //�����곡��֮��Ҫ�Զ���ת (Activation : ���
        AO.allowSceneActivation = false;
        yield return AO;
    }

    private void Update()
    {
        //������ؽ��� 0-0.9;
        Debug.Log(AO.progress);
        time += Time.deltaTime;
        if( time > 3 )
        {
            AO.allowSceneActivation = true;
        }
    }
}
