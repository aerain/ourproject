using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Hint : MonoBehaviour {

	public string text;

	public string path;
	public string textValue;

	public GUIStyle guistyle;


	// Use this for initialization
	void Start () {

		print ("A");

		path = @"/Users/Ddang/New Unity Project/Assets:\Hint.txt";
		textValue = System.IO.File.ReadAllText (path);

		text = "<color=#ffffffff>" + textValue + "</color>";

		GUI.Label(new Rect(265, 117, 580, 285), text, guistyle);



		//Console.WriteLine (text);
		Debug.Log (text);
	}

	public void PressKey(int nKey){

		//전 화면으로 돌아가기.

	}//버튼을 눌렀을 때
		

}
