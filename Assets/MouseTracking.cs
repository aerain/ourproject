using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracking : MonoBehaviour {

    public float sensitivity = 3.70f;
    
    
    
	// Use this for initialization
	void Start () {
        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;

        }
	}
	
	// Update is called once per frame
	void Update () {
       // transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
       
        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        float rotationY = transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * sensitivity;
        

        transform.localEulerAngles = new Vector3(rotationY, rotationX, 0);
	}
}
