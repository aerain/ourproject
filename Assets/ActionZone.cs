using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionZone : MonoBehaviour {

    public GameObject Target;

    public void Run()
    {
        Target.SendMessage("Play");
    }
}
