using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kitchenwater : MonoBehaviour {

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
            Debug.Log("정수기 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.tag == "Player")
            {
                HUD.text = "평범해 보이는 정수기이다.";

            }


        }

    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }
}
