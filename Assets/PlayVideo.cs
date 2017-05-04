using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MovieTexture Movie = (MovieTexture)GetComponent<Renderer>().material.mainTexture;
        Movie.Play();
        Movie.loop = true;
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
