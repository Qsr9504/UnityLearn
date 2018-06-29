using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API02Time : MonoBehaviour {
    public Transform cube;
    public int runCount = 10000;

    // Use this for initialization
    void Start() {
        //Debug.Log("**************************************************");
        //Debug.Log("Time.deltaTime:" + Time.deltaTime);
        //Debug.Log("Time.fixedDeltaTime:" + Time.fixedDeltaTime);
        //Debug.Log("Time.fixedTime:" + Time.fixedTime);
        //Debug.Log("Time.frameCount:" + Time.frameCount);
        //Debug.Log("Time.realtimeSinceStartup:" + Time.realtimeSinceStartup);
        //Debug.Log("Time.smoothDeltaTime:" + Time.smoothDeltaTime);
        //Debug.Log("Time.time:" + Time.time);
        //Debug.Log("Time.timeScale:" + Time.timeScale);
        //Debug.Log("Time.timeSinceLevelLoad:" + Time.timeSinceLevelLoad);
        //Debug.Log("Time.unscaledTime:" + Time.unscaledTime);
        //Debug.Log("**************************************************");
        cube.Translate(Vector3.forward * Time.deltaTime);//由于每一帧调用的次数不一样，所以同样的一秒会出现运行距离不一样的情况，为避免这样的情况，我们需要乘每一帧的时间间隔，进而保证每一秒运行距离基本相等
        Time.timeScale = 0;//Time.deltaTime获取是每次都要乘以TimeScale
        float time1 = Time.realtimeSinceStartup;
        for (int i = 0; i < runCount; i++) {
            Method1();
        }
        float time2 = Time.realtimeSinceStartup;
        Debug.Log(time2 - time1);
        float time3 = Time.realtimeSinceStartup;
        for (int i = 0; i < runCount; i++) {
            Method2();
        }
        float time4 = Time.realtimeSinceStartup;
        Debug.Log(time3 - time4);
    }

    // Update is called once per frame
    void Update() {
        //cube.Translate(Vector3.forward/50f);//默认运动1M，每秒调用50次，除以50之后相当于每秒移动1M
        //Debug.Log("Time.deltaTime:" + Time.deltaTime);
        //Debug.Log("Time.fixedDeltaTime:" + Time.fixedDeltaTime);
        //Debug.Log("Time.fixedTime:" + Time.fixedTime);
        //Debug.Log("Time.frameCount:" + Time.frameCount);
        //Debug.Log("Time.realtimeSinceStartup:" + Time.realtimeSinceStartup);
        //Debug.Log("Time.smoothDeltaTime:" + Time.smoothDeltaTime);
        //Debug.Log("Time.time:" + Time.time);
        //Debug.Log("Time.timeScale:" + Time.timeScale);
        //Debug.Log("Time.timeSinceLevelLoad:" + Time.timeSinceLevelLoad);
        //Debug.Log("Time.unscaledTime:" + Time.unscaledTime);


       
    }
    void Method1() {
        int i = 1 + 2;
    }
    void Method2() {
        int j = 1 * 2;
    }
}
