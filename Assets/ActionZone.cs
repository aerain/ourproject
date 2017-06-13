using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionZone : MonoBehaviour {

    public GameObject Target;

    public void Run()
    {
        Target.SendMessage("Play");
        Vector3 rot = transform.eulerAngles;
        rot.y += 1f;
        transform.eulerAngles = rot;
    }
}
