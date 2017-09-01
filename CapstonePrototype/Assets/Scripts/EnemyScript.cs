using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	[SerializeField]
	private int EnemyHealth = 10;
	
	// Update is called once per frame
	void Update () {
		if (EnemyHealth <= 0) {
			Destroy (this.gameObject);
		}
	}

	void DeductPoints( int DamageAmount){
		EnemyHealth -= DamageAmount;
	}
}
