using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour {

	// Use this for initialization
	public void GameStartActive(){
		SceneManager.LoadScene (1);	
	}
	public void ExitActive()
	{
		Application.Quit ();
	}
}
