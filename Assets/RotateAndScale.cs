using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndScale : MonoBehaviour {

    public float scaleChange = 10;
    private static System.DateTime JanFirst1970 = new System.DateTime(1970, 1, 1);
    public float seed;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    float time = System.DateTime.Now.Minute;
        float scaleVector;
        if (time % seed >= 1){
            scaleVector = (Mathf.Sin(time) + 1 ) * scaleChange;
        } else
        {
            scaleVector = 1;
        }

        Vector3 scale = new Vector3(scaleVector, scaleVector, scaleVector);
        transform.localScale = Vector3.Lerp(transform.localScale, scale, 0.003f);
    }

    public static long getTime()
    {
        return (long)((System.DateTime.Now.ToUniversalTime() - JanFirst1970).TotalMilliseconds + 0.5);
    }
}
