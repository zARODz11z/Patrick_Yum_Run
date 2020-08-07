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
		if (Input.GetKey(KeyCode.E)) {
			anim.SetBool("run", false);
			anim.SetBool("idle", false);
			anim.SetBool("eat",true);
			
		} 
		else if (Input.GetKey(KeyCode.I))
		{
			anim.SetBool("eat", false);
			anim.SetBool("run", false);
			anim.SetBool("idle", true);
		}
		else if (Input.GetKey(KeyCode.R))
		{
			anim.SetBool("eat", false);
			anim.SetBool("idle", false);
			anim.SetBool("run", true);
		}



	}
}
