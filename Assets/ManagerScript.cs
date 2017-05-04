using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour {

    public GameObject glass;
    private bool glassIsOn = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	    if(!glassIsOn && (System.DateTime.Now.Minute == System.DateTime.Now.Second || System.DateTime.Now.Second == System.DateTime.Now.Hour || System.DateTime.Now.Minute == System.DateTime.Now.Hour))
        {
            StartCoroutine(turnOnGlass());
            glassIsOn = true;
            Debug.Log("Glass");
        }
	}

    public IEnumerator turnOnGlass ()
    {
        glass.active = true;
        yield return new WaitForSeconds(System.DateTime.Now.Second);
        glass.active = false;
        glassIsOn = false;
    }
}
