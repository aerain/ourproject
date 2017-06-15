using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimer : MonoBehaviour {
    
    public float _elapsedTime = 0f;
    public Text HUD;
    
	// Use this for initialization
	void Start () {
        HUD = transform.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (HUD.text != "")
        {
            _elapsedTime += Time.deltaTime;
            HUD.text = "";
            
        }
	}
}
