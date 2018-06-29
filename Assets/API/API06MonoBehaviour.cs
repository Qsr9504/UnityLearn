using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API06MonoBehaviour : MonoBehaviour {
    public Cube cube;

	// Use this for initialization
	void Start () {
        Debug.Log(this.isActiveAndEnabled);
        Debug.Log(this.enabled);
        enabled = false;
        Debug.Log(this.name);
        Debug.Log(this.tag);
        Debug.Log(this.gameObject);
        Debug.Log(this.transform);

        print("haha");

        Debug.Log(cube.isActiveAndEnabled);
        Debug.Log(cube.enabled);
        enabled = false;
        Debug.Log(cube.name);
        Debug.Log(cube.tag);
        Debug.Log(cube.gameObject);
        Debug.Log(cube.transform);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
