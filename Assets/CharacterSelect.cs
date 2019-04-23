using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour {
	public Transform pineapple;
	public Transform rock;
	public Transform camera;
	public Vector3 offSet;    //stores 3 floats
	// Use this for initialization
	void Start () {
		camera.position = pineapple.position + offSet;
	}



	public void clickButton ()
	{
		camera.position = rock.position + offSet;
	}
}
