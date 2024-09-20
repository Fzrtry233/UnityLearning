using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTest : MonoBehaviour
{
    private void Start()
    {
        //跳转场景
        SceneManager.LoadScene("Default");
        //获取当前场景
        Scene scene = SceneManager.GetActiveScene();
        //场景名称
        Debug.Log(scene.name);
        //场景是否已经加载了
        Debug.Log(scene.isLoaded);
        //场景路径
        Debug.Log(scene.path);
        //场景索引
        Debug.Log(scene.buildIndex);
        //获取场景根物体
        GameObject[] gos = scene.GetRootGameObjects();
        Debug.Log(gos.Length);

        //场景管理
        Debug.Log(SceneManager.sceneCount);
        //创建新场景
        Scene newScene = SceneManager.CreateScene("NewScene");
        //卸载新场景
        SceneManager.UnloadSceneAsync(newScene);
        //加载场景
        SceneManager.LoadScene("Default", LoadSceneMode.Additive);
    }
}
