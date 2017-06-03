using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {

    public enum playerState
    {
        idle = 0,
        walk,
        attack,
        dead

    }

    public Animator _anim;
    public playerState _state = playerState.walk;
    public float _speed = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(_speed * Time.deltaTime, 0.0f, 0.0f);

        if (_anim != null)
        {
            _anim.SetInteger("playerState", (int)_state);
        }
	}
}
