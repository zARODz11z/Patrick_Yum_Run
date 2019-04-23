using UnityEngine;
using System.Collections;

public class UpAndDown : MonoBehaviour {

	public float speed = 10.0f;

	public enum whichWayToGo {Up, Down}

	public whichWayToGo way = whichWayToGo.Up;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		switch(way)
		{
		case whichWayToGo.Up:
			transform.Translate(Vector3.up * Time.deltaTime * speed);
			break;
		case whichWayToGo.Down:
			transform.Translate(Vector3.down * Time.deltaTime * speed);
			break;
		
		}	
	}
}