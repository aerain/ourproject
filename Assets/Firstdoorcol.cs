using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firstdoorcol : MonoBehaviour {
    Inventory inv;
    public Text HUD;
    Animator anim;
    // Use this for initialization
    void Start()
    {
        inv = GameObject.Find("Player").GetComponent<Inventory>();
        HUD = GameObject.Find("HUDCanvas").transform.FindChild("TextHUD").GetComponent<Text>();
        anim = transform.parent.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("First Door 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                if (inv.firstkey)
                {
                    HUD.text = "문이 열린다!";
                    anim.SetBool("open", true);
                    inv.firstdoor = true;
                }
                else
                {
                    HUD.text = "단단히 잠겨있다..";
                }
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }
}
