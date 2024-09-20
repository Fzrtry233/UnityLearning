using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationTest : MonoBehaviour
{
    private void Start()
    {
        //游戏数据文件夹路径(只读,加密压缩)
        Debug.Log(Application.dataPath + "/新建文本文档.txt");
        //持久化文件路径
        Debug.Log(Application.persistentDataPath);
        //StreamingAssets文件夹路径(只读，配置文件)
        Debug.Log(Application.streamingAssetsPath);
        //临时文件
        Debug.Log(Application.temporaryCachePath);
        //控制是否在后台运行
        Debug.Log(Application.runInBackground);
        //打开url
        //Application.OpenURL("https://space.bilibili.com/104506895?spm_id_from=333.1007.0.0");
        //退出游戏
        //Application.Quit();
    }
}
