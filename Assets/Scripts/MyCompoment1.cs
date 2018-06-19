using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCompoment1 : MonoBehaviour {

    // Use this for initialization
    void Start() {
        //动态在代码中挂载一个Compoment
        MyCompoment2 my2 = gameObject.AddComponent<MyCompoment2>();
        //寻找某一个脚本,或者一个组件，需要进行判断是否为空
        Renderer renderer = gameObject.GetComponent<Renderer>();
        //Renderer renderer1 = gameObject.GetComponentInChildren<Renderer>();//找到下属的第一个层级的

        //删除某一个脚本
        Destroy(renderer);//需要先找到这个脚本

        //禁用一个脚本
        my2.enabled = true;
    }

    // Update is called once per frame
    void Update() {

    }

    private void Awake() {
        //相当于构造函数，这个脚本第一次初始化的
    }

    private void OnEnable() {
        //当每次被启用的时候调用的函数

        //onStart之前会调用一下这个函数
    }

    private void OnDisable() {
        //当这个脚本每次被禁用的时候调用的函数
        
        //再被摧毁之前每次都会被调用
    }

     
}
