using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
	private Vector3 MovingDirection = Vector3.up;
	public float Uplimit = 3.0F;
	public float Downlimit = 1.45F;
	public float MovementSpeed = 2.0F;
	public bool goUp;

	void FixedUpdate () {
		gameObject.transform.Translate(MovingDirection *Time.deltaTime* MovementSpeed);

		if(gameObject.transform.position.y >= Uplimit){
			MovingDirection = Vector3.down;
		}else if (gameObject.transform.position.y <= Downlimit) {
			MovingDirection = Vector3.up;
		}
	}
}    
//
//