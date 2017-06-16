﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wartercooler : MonoBehaviour {
    Inventory inv;
    public Text HUD;
    // Use this for initialization
    void Start()
    {
        inv = GameObject.Find("Player").GetComponent<Inventory>();
        HUD = GameObject.Find("HUDCanvas").transform.FindChild("TextHUD").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("정수기 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                HUD.text = "자그마한 키를 주웠다. 맞은편 방의 키인것 같다.";
                inv.kitchenwaterkey = true;
            }


        }

    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }
}