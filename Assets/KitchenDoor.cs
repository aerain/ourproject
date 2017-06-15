using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenDoor : MonoBehaviour {
    public DoorCollide doorcol;
    public Text HUD;
    public Animator anim;
    public Inventory inven;
    // Use this for initialization
    void Start () {
        inven = GameObject.Find("Player").GetComponent<Inventory>();
        doorcol = GameObject.Find("Player").GetComponent<DoorCollide>();
        HUD = GameObject.Find("HUDCanvas").transform.FindChild("TextHUD").GetComponent<Text>();
        anim = transform.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (doorcol.doco)
            {
                if (inven.firstdoor)
                {
                    anim.SetBool("open", true);
                }               
            }

        }
    }
}
