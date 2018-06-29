using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API07Invoke : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Attart",3);//3秒后调用Invoke函数 Invoke是说使用时加入进去执行队列
        //InvokeRepeating讲的是一直都放进去了执行队列，isInvoking会一直返回true
        InvokeRepeating("Attart", 4, 2);//4s后执行，每2s执行一次

        CancelInvoke("Attart");//添加参数就移除制定函数，如果不添加参数，就会移除所有的执行函数
    }
	
	// Update is called once per frame
	void Update () {
        bool res = IsInvoking();//查看执行队列有没有，
        
        Debug.Log(res);
	}

    void Attart() {
        Debug.Log("正在攻击");
    }
}
