using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour {

	[SerializeField]
	private int DamageAmount = 5;
	public float TargetDistance;
	[SerializeField]
	private float AllowedRange = 15;


	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
		
			RaycastHit shot;
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out shot)) {
				TargetDistance = shot.distance;
				if (TargetDistance < AllowedRange) {
					shot.transform.SendMessage ("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
				}
			}
		}	
	}
}
