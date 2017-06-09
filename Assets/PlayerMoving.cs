using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {
    
    public float moveSpeed = 10;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(moveHorizontal, 0, moveVertical) * moveSpeed * Time.fixedDeltaTime);

        
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));
       


    }
}
