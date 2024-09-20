using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using UnityEngine;

public class EmptyTest : MonoBehaviour
{
    public GameObject Cube;
    //获取预设体
    public GameObject Prefab;
    private void Start()
    {
        //拿到当前脚本所挂在的游戏物体
        GameObject go = this.gameObject;
        //名称
        Debug.Log(go.name);
        //tag
        Debug.Log(go.tag);
        //图层
        Debug.Log(go.layer);
        //立方体的名称
        Debug.Log(Cube.name);
        //真正的激活状态（GameObject未激活时为false)
        Debug.Log(Cube.activeInHierarchy);
        //自身的激活状态 (GameObject未激活时为true)
        Debug.Log(Cube.activeSelf);
        //获取Transform组件
        Debug.Log(transform.position);
        //获取其他组件
        BoxCollider bc = GetComponent<BoxCollider>();
        //获取当前物体子物体身上的某个组件
        GetComponentInChildren<CapsuleCollider>();
        //获取父物体身上的某个组件
        GetComponentInParent<CapsuleCollider>();
        //添加组件
        gameObject.AddComponent<AudioSource>();
        //通过物体名称获得物体
        GameObject test = GameObject.Find("Test");
        Debug.Log(test.name);
        //通过标签获得物体
        test = GameObject.FindGameObjectWithTag("Enemy");
        Debug.Log(test.name);
        //通过预设体来实例化一个游戏物体
        GameObject g1 = Instantiate(Prefab, transform);
        GameObject g2 = Instantiate(Prefab, Vector3.zero,Quaternion.identity);
        //销毁
        Destroy(g1);
    }
}
