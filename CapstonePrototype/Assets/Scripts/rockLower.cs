using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class rockLower : MonoBehaviour {

	public Animator rockAnim ;
	public Text helpText;

	// Use this for initialization
	void Start () {
		//rockAnim.Play (0);
		rockAnim.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] Tigers = GameObject.FindGameObjectsWithTag ("Tiger");
		if (Tigers.Length == 1) {
			rockAnim.enabled = true;
			rockAnim.Play (0);
			helpText.text = "Get the Cup";
		}
	}
}
