using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using UnityEngine;

public class EmptyTest : MonoBehaviour
{
    public GameObject Cube;
    //��ȡԤ����
    public GameObject Prefab;
    private void Start()
    {
        //�õ���ǰ�ű������ڵ���Ϸ����
        GameObject go = this.gameObject;
        //����
        Debug.Log(go.name);
        //tag
        Debug.Log(go.tag);
        //ͼ��
        Debug.Log(go.layer);
        //�����������
        Debug.Log(Cube.name);
        //�����ļ���״̬��GameObjectδ����ʱΪfalse)
        Debug.Log(Cube.activeInHierarchy);
        //����ļ���״̬ (GameObjectδ����ʱΪtrue)
        Debug.Log(Cube.activeSelf);
        //��ȡTransform���
        Debug.Log(transform.position);
        //��ȡ�������
        BoxCollider bc = GetComponent<BoxCollider>();
        //��ȡ��ǰ�������������ϵ�ĳ�����
        GetComponentInChildren<CapsuleCollider>();
        //��ȡ���������ϵ�ĳ�����
        GetComponentInParent<CapsuleCollider>();
        //������
        gameObject.AddComponent<AudioSource>();
        //ͨ���������ƻ������
        GameObject test = GameObject.Find("Test");
        Debug.Log(test.name);
        //ͨ����ǩ�������
        test = GameObject.FindGameObjectWithTag("Enemy");
        Debug.Log(test.name);
        //ͨ��Ԥ������ʵ����һ����Ϸ����
        GameObject g1 = Instantiate(Prefab, transform);
        GameObject g2 = Instantiate(Prefab, Vector3.zero,Quaternion.identity);
        //����
        Destroy(g1);
    }
}
