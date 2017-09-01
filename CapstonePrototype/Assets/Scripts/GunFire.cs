using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {

	public Animator gunAnimation ;
	public Animator UpCursorAnim ;
	public Animator DownCursorAnim ;
	public Animator LeftCursorAnim ;
	public Animator RightCursorAnim ;


	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			gunAnimation.Play (0);
			UpCursorAnim.Play (0);
			DownCursorAnim.Play (0);
			LeftCursorAnim.Play (0);
			RightCursorAnim.Play (0);
		}	
	}
}
