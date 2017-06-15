using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marshall : MonoBehaviour {
    
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
            Debug.Log("Marshall 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {               
                    HUD.text = "앰프를 밀었다!";
                    anim.SetBool("marshall", true);              
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }
}
