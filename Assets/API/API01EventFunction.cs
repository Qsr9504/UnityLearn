using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API01EventFunction : MonoBehaviour {
    //事件函数（生命周期函数）
	// Use this for initialization
	void Start () {
        Debug.Log("Start");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update");
	}

    void Reset() {
        Debug.Log("Reset");
    }


    private void OnEnable() {
        Debug.Log("设置为可用");
    }

    private void OnDisable() {
        Debug.Log("设置为不可用");
    }
    //跟帧无关，以秒为单位进行刷新
    private void FixedUpdate() {
        Debug.Log("FixedUpdate");
    }
}
