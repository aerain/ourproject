using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstBed : MonoBehaviour {
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
            Debug.Log("침대 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                
                HUD.text = "침대 밑에서 어딘가의 열쇠를 주웠다!";
                inv.firstbedkey = true;
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }
}
