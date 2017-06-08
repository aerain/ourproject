using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float MoveSpeed = 10f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0, 0, v) * MoveSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, h, 0));

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (az) az.Run();
        }
    }
        // import 필요없는 객체 선언

    public ActionZone az;

    void OnTriggerEnter(Collider _col)
    {
        if (_col.gameObject.tag == "ActionZone")
        {
            az = _col.gameObject.GetComponent<ActionZone>();
        }
    }

    void OnTriggerExit(Collider _col)
    {
        if (_col.gameObject.tag == "ActionZone")
        {
            az = null;
        }
    }
    
}

