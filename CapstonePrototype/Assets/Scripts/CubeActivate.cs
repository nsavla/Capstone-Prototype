using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeActivate : MonoBehaviour {

	float TheDistance = PlayerCasting.DistanceFromTarget;
	private Animator myAnimator;
	private bool isActive = false;
	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;	
		if (isActive && Input.GetButtonDown ("Fire1")) {
			myAnimator.enabled = true;
			myAnimator.Play (0);
		}
	}

	void OnTriggerEnter(Collider other) {
		isActive = true;
	}
	void OnTriggerExit(Collider other) {
		isActive = false;
	}
}
