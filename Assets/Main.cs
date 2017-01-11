using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    GameObject obj;
	void Start () {
        obj = GameObject.Find("Cube");
	}
	
	void Update () {
        obj.transform.Rotate(Vector3.up*Time.deltaTime*10f );
	
	}
}
