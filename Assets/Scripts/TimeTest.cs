using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    float timmer = 0;
    private void Start()
    {
        //游戏开始到现在所花的时间
        Debug.Log(Time.time);
        //时间缩放
        Debug.Log(Time.timeScale);
        //固定时间间隔
        Debug.Log(Time.fixedDeltaTime);
        //上一帧到这一帧所需要的时间
        Debug.Log(Time.deltaTime);

    }
    //60fps 每帧所需要的时间是 1/60 120fps 时间是 1/120
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
