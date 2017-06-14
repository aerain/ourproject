using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunController : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        anim = gameObject.GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.W)) anim.SetTrigger("Active");
        else if (Input.GetKeyUp(KeyCode.W)) anim.SetTrigger("DeActive");
        if (Input.GetKeyDown(KeyCode.S)) anim.SetTrigger("Active");
        else if (Input.GetKeyUp(KeyCode.S)) anim.SetTrigger("DeActive");
        if (Input.GetKeyDown(KeyCode.A)) anim.SetTrigger("Active");
        else if (Input.GetKeyUp(KeyCode.A)) anim.SetTrigger("DeActive");
        if (Input.GetKeyDown(KeyCode.D)) anim.SetTrigger("Active");
        else if (Input.GetKeyUp(KeyCode.D)) anim.SetTrigger("DeActive");
    }
   
    
}
