using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour {
	public Collider col1;
	public Collider col2;
	public int speed;
	public Transform tran;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.y < 3.1) {
			transform.Translate (Vector3.up * Time.deltaTime * speed);
		}
		if (transform.position.y == 3.1) {
			transform.Translate (Vector3.down * Time.deltaTime * speed);
		}
		//while (tran.position.y < 10 ) {
		//	transform.Translate(Vector3.up * Time.deltaTime );
		//}
	}
}
