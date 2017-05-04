using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresInstantiator : MonoBehaviour {
    public Material[] sphereMaterials;
    public int numberOfSpheres = 10;
    public GameObject sphere;
    private GameObject[] spheres;
	// Use this for initialization
	void Start () {
        spheres = new GameObject[numberOfSpheres];
        for (int i = 0; i < numberOfSpheres; i++)
        {
            GameObject sphereInt = Instantiate(sphere, transform);
            spheres[i] = sphereInt;
            sphereInt.GetComponent<MeshRenderer>().material = sphereMaterials[Random.Range(0, sphereMaterials.Length)];
        }
    }
	
	// Update is called once per frame
	void Update () {
        float time = System.DateTime.Now.Millisecond / 100;
        for (int i = 0; i < spheres.Length;  i++)
        {
            Vector3 newPosition = new Vector3(Mathf.Sin(time), Mathf.Cos(time), Mathf.Sin(time + 2)) * 50;
            spheres[i].transform.position = Vector3.Lerp(transform.position, newPosition , 0.1f);
            
        }
	}
}
