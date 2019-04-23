using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrick : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.F)) {
			anim.SetInteger ("AnimPar", 1);
		} else {
			anim.SetInteger ("AnimPar", 0);
		}

	}
}
