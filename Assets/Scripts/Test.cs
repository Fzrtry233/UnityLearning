using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    //�̶����ˢ�º�֡���޹� 
    private void FixedUpdate()
    {
        
    }

    //ÿһ֡�������һ��  Update() ֮������ŵ���LateUpdate()
    private void Update()
    {

    }

    private void LateUpdate()
    {
        
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
