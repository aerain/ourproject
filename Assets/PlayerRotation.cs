using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour {
   

    public GameObject Player;
    public GameObject MainCamera;

    public float dist = 0f;
    public float width = -10f;
    public float height = 4f;
    public float camera_fix = 3f;

    Vector3 dir;
    
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        MainCamera = GameObject.FindGameObjectWithTag("Camera");

        dist = Mathf.Sqrt(width * width + height * height);

        dir = new Vector3(0, height, width).normalized;
	}
	
    // Update is called once per frame
	void Update () {

        // transform.RotateAround(new Vector3(-(Input.GetAxis("Mouse Y")), 0, 0));

       //  transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime * rot_speed, Space.World);
        transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y"), Space.Self);

        transform.position = Player.transform.position;

        Vector3 ray_target = transform.up * height + transform.forward * width;
        Debug.Log("ray_target : " + ray_target);

        RaycastHit hitinfo;
        Physics.Raycast(transform.position, ray_target, out hitinfo, dist);

        if (hitinfo.point != Vector3.zero)
        {
            MainCamera.transform.position = hitinfo.point;
            MainCamera.transform.Translate(dir * -1 * camera_fix);
        }
        else
        {
            MainCamera.transform.localPosition = Vector3.zero;
            MainCamera.transform.Translate(dir * dist);

            MainCamera.transform.Translate(dir * -1 * camera_fix);
        }


    }
}
