using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecretChest : MonoBehaviour {
    public Text HUD;
    Animator anim;
    Inventory inv;
    public GameObject Door;
    // Use this for initialization
    void Start()
    {

        HUD = GameObject.Find("HUDCanvas").transform.FindChild("TextHUD").GetComponent<Text>();
        anim = transform.parent.GetComponent<Animator>();
        inv = GameObject.Find("Player").GetComponent<Inventory>();
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
            Debug.Log("비밀 체스터 충돌");
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!inv.secretchest)
            {
                if (other.tag == "Player")
                {
                    PlayerPrefs.SetInt("save", 1);
                    PlayerPrefs.Save();
                    SceneManager.LoadScene(2, LoadSceneMode.Additive);
                                      
                }
            } else
            {
                HUD.text = "체스터에서 뭔가를 발견했다! 사다리 부품인것 같다.";
                
            }
        }

       
    }
    private void OnTriggerExit(Collider other)
    {
        HUD.text = "";
    }
}
