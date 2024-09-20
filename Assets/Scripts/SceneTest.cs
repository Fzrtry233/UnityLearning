using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTest : MonoBehaviour
{
    private void Start()
    {
        //��ת����
        SceneManager.LoadScene("Default");
        //��ȡ��ǰ����
        Scene scene = SceneManager.GetActiveScene();
        //��������
        Debug.Log(scene.name);
        //�����Ƿ��Ѿ�������
        Debug.Log(scene.isLoaded);
        //����·��
        Debug.Log(scene.path);
        //��������
        Debug.Log(scene.buildIndex);
        //��ȡ����������
        GameObject[] gos = scene.GetRootGameObjects();
        Debug.Log(gos.Length);

        //��������
        Debug.Log(SceneManager.sceneCount);
        //�����³���
        Scene newScene = SceneManager.CreateScene("NewScene");
        //ж���³���
        SceneManager.UnloadSceneAsync(newScene);
        //���س���
        SceneManager.LoadScene("Default", LoadSceneMode.Additive);
    }
}
