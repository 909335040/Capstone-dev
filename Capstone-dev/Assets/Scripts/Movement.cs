using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float WalkSpeed = 1f;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        // float value = Input.GetAxis("Left Y");
        //Debug.Log(value);
        transform.Translate(Input.GetAxis("Left X") * 0.05f *WalkSpeed, Input.GetAxis("Left Y") * 0.05f * WalkSpeed, 0);
       


    }
}
