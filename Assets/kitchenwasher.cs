using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kitchenwasher : MonoBehaviour {
  
    public Text HUD;
   
    // Use this for initialization
    void Start()
    {
       
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
            Debug.Log("식기대 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                HUD.text = "더러운 접시들이 아무렇게나 널부러져 있다..";
               
            }


        }

    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }
}
