using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
    
    public DoorCollide doorcol;
    public Animator anim;
    
    
    // Use this for initialization
    void Start () {
        
        doorcol = transform.FindChild("DoorCol").GetComponent<DoorCollide>();
        anim = transform.GetComponent<Animator>();

    } 
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
            {
            Debug.Log(anim.transform.name + "와 " + anim.transform.name + "확인");
            if (transform.name == anim.transform.name)
            {               
                doorcol.transform.parent.GetComponent<Animator>().Play("Open");
                Debug.Log(transform.name + "열림");
            }
        }
               
    }
}
