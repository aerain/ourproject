using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletDoor : MonoBehaviour {

    public DoorCollide doorcol;
    public Animator anim;

    // Use this for initialization
    void Start()
    {
        doorcol = GameObject.Find("Player").GetComponent<DoorCollide>();
        anim = transform.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (doorcol.doco)
            {
                
                anim.SetBool("open", true);
            }

        }

    }


}
