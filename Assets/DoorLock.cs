using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorLock : MonoBehaviour {


    public Inventory inven;
	public string label;
	public GUIStyle guistyle;
	public GUIText guicolor;
    public string answer;
    public string label2;


	// Use this for initialization
	void Start () {
        inven = GameObject.Find("Player").GetComponent<Inventory>();
		this.answer = "<color=#ffffffff>" + inven.kitchentabledoorlock + "</color>";
        this.label = "";
        this.label2 = "";
		this.guistyle.fontSize = 30;
		
	}

	public void PressKey(int nKey){



		if (nKey == 10) {
            if (label == "3071")
            {
                label2 = "<color=#ffffffff>" + "Correct!" + "</color>";
                
                inven.secretchest = true;
                
                SceneManager.LoadScene(1, LoadSceneMode.Single);
                
            } else
            {
                label2 = "<color=#ffffffff>" + "Wrong!" + "</color>";
                OnGUI();
            }
			//비밀번호가 맞는지 확인하는 걸로 바꾸기

		} else {
            if (label2 == "<color=#ffffffff>" + "Wrong!" + "</color>")
            {
                label2 = "";
                label = "";
                
            }else
            {
                label += nKey;
                label2 = "<color=#ffffffff>" + label + "</color>";
            }
		}
	}//버튼을 눌렀을 때

	void OnGUI(){

		GUI.Label(new Rect(200, 30, 160, 50), label2, guistyle); 

	}//출력

}
