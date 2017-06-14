using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollide : MonoBehaviour {
    GameObject par;
    Animator anim;
    

	// Use this for initialization
	public string Start () {
        par = transform.parent.gameObject;
        anim = par.GetComponent<Animator>();
        string parn = par.name;

        return parn;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {

            anim.SetBool("door", false);
            Debug.Log(Start() + " Collide");
        }
    }
    void OnTriggerExit(Collider other)
    {
        anim.SetBool("door", true);
        Debug.Log(Start() + " Exit");
    }

}
