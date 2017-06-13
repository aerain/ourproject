using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Anim
{
    public AnimationClip standing;
    public AnimationClip walking;
}
public class PlayerMoving : MonoBehaviour {
    
    public float moveSpeed = 10;
    public Anim anim;
    public Animation _animation;
	// Use this for initialization
	void Start () {
        _animation = GetComponentInChildren<Animation>();
        // _animation.clip = anim.standing;
	}

    // Update is called once per frame
    void Update() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(moveHorizontal, 0, moveVertical) * moveSpeed * Time.fixedDeltaTime);


        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (az) az.Run();
        }
    }
   public ActionZone az;

   void OnTriggerEnter(Collider _col)
   {
         if(_col.gameObject.tag == "ActionZone")
        {
            az = _col.gameObject.GetComponent<ActionZone>();
            
        }
   }

   void OnTriggerExit(Collider _col)
    {
        if(_col.gameObject.tag == "Actionzone")
        {
            az = null;
        }
    }
}

