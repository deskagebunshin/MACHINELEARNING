using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoParticleEmission : MonoBehaviour {
    private ParticleSystem particleSystem;
	// Use this for initialization
	void Start () {
        particleSystem = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        float time = System.DateTime.Now.Minute;
        if ( time % 5 == 0 && Random.Range (0, 100) > 10)
        {
            particleSystem.Emit(10);
        }
    }
}
