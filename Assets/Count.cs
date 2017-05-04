using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour {
    private static System.DateTime JanFirst1970 = new System.DateTime(1970, 1, 1);

    private TextMesh myText;
	// Use this for initialization
	void Start () {
        myText = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
        // string stringTime = System.String.Format("{0}", getTime());
        myText.text = System.DateTime.Now.ToString("hh:mm:ss:fff");
	}

    public static long getTime()
    {
        //return (long)((System.DateTime.Now.ToUniversalTime() - JanFirst1970).TotalMilliseconds + 0.5);
        return System.DateTime.Now.Minute;
    }
}
