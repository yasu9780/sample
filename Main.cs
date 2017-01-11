using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    GameObject obj;
    GameObject obj2;
    void Start () {
        obj = GameObject.Find("Cube");
        obj2 = GameObject.Find("Cube2");
    }

    void Update () {
        obj.transform.Rotate(Vector3.up*Time.deltaTime*20f );
        obj2.transform.Rotate(Vector3.right * Time.deltaTime * 20f);
    }
}
