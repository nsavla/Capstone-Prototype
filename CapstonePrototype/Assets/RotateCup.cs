using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;
using UnityEngine.SceneManagement;

public class RotateCup : MonoBehaviour {

	public Text helpText;
	public Text replayText;
	public Text gameOverText;

	private bool gameOver = false;

	// Use this for initialization
	void Start () {
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			Debug.Log ("gAME OVER IS TRUE");

			if (Input.GetKey(KeyCode.R)) {
				Debug.Log ("Action button");
				SceneManager.LoadScene (1);
			} else if (Input.GetButtonDown("Cancel")){
				Debug.Log ("Cancel button");
				SceneManager.LoadScene (0);
			}
		}

		this.gameObject.transform.Rotate (0, Time.deltaTime * 10, 0);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			gameOver = true;
			helpText.text = "You Win";
			replayText.text = "Press 'R' to Replay";
			gameOverText.text = "Press 'Esc' to Go Back";
			this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x,-100,this.gameObject.transform.position.z);
		}
	}
}
