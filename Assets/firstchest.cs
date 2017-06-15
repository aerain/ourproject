using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firstchest : MonoBehaviour {
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
            Debug.Log("체스트 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                if (inv.firstbedkey)
                {
                    HUD.text = "방을 나가는 문의 열쇠다!";
                    inv.firstkey = true;
                } else
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
