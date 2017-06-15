﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestCol : MonoBehaviour {
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
       if(other.tag == "Player")
        {
            Debug.Log("서랍장 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {

                HUD.text = "서랍장에는 별 것이 없어 보인다..";

                
               
            }            
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }
}
