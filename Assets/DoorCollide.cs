using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCollide : MonoBehaviour {
    
    Animator anim;
    public bool doco = false;
    public Text HUD;
    

	// Use this for initialization
	void Start () {
        HUD = GameObject.Find("HUDCanvas").transform.FindChild("TextHUD").GetComponent<Text>();
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
            doco = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.transform.parent.name + " Exit");
        doco = false;
        HUD.text = "";

    }

}
