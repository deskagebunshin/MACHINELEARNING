using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetTiling : MonoBehaviour {

    Material thisMaterial;
    public float speed;
	// Use this for initialization
	void Start () {
        thisMaterial = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        float offset = speed * Time.time;
        thisMaterial.SetTextureOffset("_BumpMap", new Vector2 (0, offset));
	}
}
