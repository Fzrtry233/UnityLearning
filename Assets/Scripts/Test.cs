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

    //固定间隔刷新和帧率无关 
    private void FixedUpdate()
    {
        
    }

    //每一帧都会调用一次  Update() 之后紧接着调用LateUpdate()
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
