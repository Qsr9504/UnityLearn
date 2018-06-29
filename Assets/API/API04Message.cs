using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API04Message : MonoBehaviour {

    public GameObject target;

	// Use this for initialization
	void Start () {
        target.BroadcastMessage("Attart",null,SendMessageOptions.DontRequireReceiver);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
