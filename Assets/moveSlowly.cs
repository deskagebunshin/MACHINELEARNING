using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSlowly : MonoBehaviour {
    public float speed;
    public Vector3 directionXYZ;

	// Use this for initialization
	void Start () {
        directionXYZ = (directionXYZ * speed) / 1000;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += directionXYZ;	
	}
}
