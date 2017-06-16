﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToiletDoor : MonoBehaviour {

    public Text HUD;
    Animator anim;
    // Use this for initialization
    void Start()
    {
        
        HUD = GameObject.Find("HUDCanvas").transform.FindChild("TextHUD").GetComponent<Text>();
        anim = transform.parent.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Toilet Door 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                
                    HUD.text = "문이 열렸다!";
                    anim.SetBool("open", true);
                   
                
               
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }


}
