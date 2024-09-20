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

    //携程用来异步加载
    IEnumerator loadScene()
    {
        AO = SceneManager.LoadSceneAsync("Default");
        //加载完场景之后不要自动跳转 (Activation : 激活）
        AO.allowSceneActivation = false;
        yield return AO;
    }

    private void Update()
    {
        //输出加载进度 0-0.9;
        Debug.Log(AO.progress);
        time += Time.deltaTime;
        if( time > 3 )
        {
            AO.allowSceneActivation = true;
        }
    }
}
