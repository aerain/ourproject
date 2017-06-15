using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kitchentable : MonoBehaviour {
    Inventory inv;
    public Text HUD;
    public GameObject Door;
    // Use this for initialization
    void Start()
    {
        inv = GameObject.Find("Player").GetComponent<Inventory>();
        HUD = GameObject.Find("HUDCanvas").transform.FindChild("TextHUD").GetComponent<Text>();
        Door = GameObject.Find("HUDCanvas").transform.FindChild("DoorLock").gameObject;


    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("체스트 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                HUD.text = "조그마한 쪽지를 얻었다.";
                Door.SetActive(true);
                inv.kitchentabledoorlock = "3071";
            }
            
            
        }

    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }
}
