using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCol : MonoBehaviour {
    public GameObject HUD;
    public GameObject hudtext;
	// Use this for initialization
	void Start () {
        HUD = gameObject.transform.Find("TextHUD").gameObject;
        
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
                HUD.SetActive(true);
            }            
        }
        
    }
}
