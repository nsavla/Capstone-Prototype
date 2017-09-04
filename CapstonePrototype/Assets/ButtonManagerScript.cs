using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManagerScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayButton(){
		SceneManager.LoadScene (1);
	}

	public void GoBackButton(){
		SceneManager.LoadScene (0);
	}

	public void ExitButton() {
		Application.Quit();
	}
}
