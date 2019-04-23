using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pattyCollison : MonoBehaviour {
	public Animator anim; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider colliderInfo){
		{
			if (colliderInfo.GetComponent<Collider> ().tag == "Player") {
				
				anim.SetInteger ("IntegerPar", 1);
			} else
				anim.SetInteger ("IntegerPar", 0);
		}
}
}
