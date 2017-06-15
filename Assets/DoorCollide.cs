using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollide : MonoBehaviour {
    
    Animator anim;
    

	// Use this for initialization
	void Start () {
        
        
       

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        anim = other.transform.parent.GetComponent<Animator>();

        if (other.tag == "ActionZone")
        {

            
            Debug.Log(other.transform.parent.name + " Collide");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "ActionZone")
            {
                Debug.Log(anim.transform.name + "와 " + anim.transform.name + "확인");

                anim.SetBool("open", true);
                Debug.Log(transform.name + "열림");
            }

        }
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.transform.parent.name + " Exit");
    }

}
