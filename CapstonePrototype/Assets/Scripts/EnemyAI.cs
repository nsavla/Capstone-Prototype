using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public GameObject ThePlayer;
	public float TargetDistance;
	public float AllowedRange = 10;
	public GameObject TheEnemy ;
	public float EnemySpeed;
	public int AttackTrigger;
	public RaycastHit Shot ;
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (ThePlayer.transform);
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Shot)) {
			TargetDistance = Shot.distance;
			if (TargetDistance < AllowedRange) {
				EnemySpeed = 0.06f;
				if (AttackTrigger == 0) {
					TheEnemy.GetComponent<Animator> ().Play ("run");
					transform.position = Vector3.MoveTowards (transform.position, ThePlayer.transform.position, EnemySpeed);
				}
			} else {
				EnemySpeed = 0;
				TheEnemy.GetComponent<Animator> ().Play ("idle");
			}
		}
	
		if (AttackTrigger == 1) {
			TheEnemy.GetComponent<Animator> ().Play ("hit");
		}
	}

	void OnTriggerEnter() {
		AttackTrigger = 1;
	}

	void OnTriggerExit() {
		AttackTrigger = 0;
	}
}
