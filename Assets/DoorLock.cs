using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorLock : MonoBehaviour {


		
	public string label;
	public GUIStyle guistyle;
	public GUIText guicolor;


	// Use this for initialization
	void Start () {

		this.label = "";
		this.guistyle.fontSize = 30;
		
	}

	public void PressKey(int nKey){



		if (nKey == 10) {

			label = "<color=#ffffffff>"+ "Correct!" +"</color>";
			OnGUI ();

			//비밀번호가 맞는지 확인하는 걸로 바꾸기

		} else {
				label += "<color=#ffffffff>" + nKey + "</color>";
		}
			
	}//버튼을 눌렀을 때

	void OnGUI(){

		GUI.Label(new Rect(200, 30, 160, 50), label, guistyle);

	}//출력

}
