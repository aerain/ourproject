using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstDoor : MonoBehaviour {

    public DoorCollide doorcol;
    public Animator anim;
    public Inventory inven;
    public Text HUD;

    // Use this for initialization
    void Start () {
        inven = GameObject.Find("Player").GetComponent<Inventory>();
        doorcol = GameObject.Find("Player").GetComponent<DoorCollide>();
        anim = transform.GetComponent<Animator>();
        HUD = GameObject.Find("HUDCanvas").transform.FindChild("TextHUD").GetComponent<Text>();


    } 
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (doorcol.doco)
            {
                if (inven.firstkey)
                {
                    anim.SetBool("open", true);
                    
                } 
            }

        }

    }


}
