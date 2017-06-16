﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secretdoorout : MonoBehaviour {
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
            Debug.Log("secret Door outside 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                HUD.text = "문이 잠겨있다...";
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }
}
