using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    public GameObject RightAimIcon = null;

    // Use this for initialization
    void Start () {
        RightAimIcon = Instantiate(RightAimIcon, transform);
        RightAimIcon.transform.position = transform.position;
        RightAimIcon.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Right X") != 0  || Input.GetAxis("Right Y") != 0 ){
            float tempx = Input.GetAxis("Right X");
            float tempy = Input.GetAxis("Right Y");

            Vector3 tempvector = new Vector3(tempx, tempy, 0);
            tempvector = tempvector.normalized;
            RightAimIcon.transform.localPosition = tempvector;
        }

        Debug.Log(RightAimIcon.transform.position);
    }
}
