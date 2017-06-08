using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAction : MonoBehaviour {
    bool up;

    public void Play()
    {
        up = true;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (up)
        {
            transform.Translate(new Vector3(0, 1, 0));
        }
	}
}
