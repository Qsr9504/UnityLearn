using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API03GameObject : MonoBehaviour {
    public GameObject prefab;
	// Use this for initialization
	void Start () {
        //1.第一种创建方法
        //GameObject gameObject = new GameObject("Cube");
        //2.第二种创建方法  根据prefab进行创建的
        //根据另外的游戏物体进行克隆
        GameObject.Instantiate(prefab);
        //3.第三种创建方法
        GameObject.CreatePrimitive(PrimitiveType.Plane);
        GameObject game = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
        
        //为已有物体进行添加组件
        game.AddComponent<Rigidbody>();

        //查找gameobject
        Transform[] ts = FindObjectsOfType<Transform>();//不查找未激活的游戏物体
        foreach (Transform t in ts) {
            Debug.Log(t);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
  