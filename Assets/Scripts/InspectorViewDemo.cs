using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//定义一个类
[System.Serializable]
public class customStruct {
    public int mm;
    public string qsr;
}
public class InspectorViewDemo : MonoBehaviour {
    
    //public属性会被自动暴露在unity里
    //首字母默认会被转化为大写
    //unity中赋值会将代码中的初始值给覆盖掉
    public int ab = 2;//定义一个int型
    public bool[] booldemo;//定义一个布尔型数组，不用担心空指针
    public List<string> ayyayList;//定义一个string数组

    public customStruct custom;


    public Color color;//定义一个颜色
    public AnimationCurve curve;//定义一个曲线

    public Gradient gradient;//是一个渐变（颜色）

    //protected,private 都是不会被暴露出来的
    private int a;
    protected int b;
    
    //将public的隐藏起来
    [HideInInspector]
    public int bb = 2;

    //将private 和 protected 的暴露出来
    [SerializeField]
    private int cc;
    [SerializeField]
    protected int dd;

	void Start () {
        Debug.Log(ab);//打印ab的值
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
