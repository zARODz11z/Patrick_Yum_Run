
using UnityEngine;

public class followPlayer : MonoBehaviour {

	public Transform player;
	public Vector3 offSet;    //stores 3 floats
	// Update is called once per frame
	void Update () { //little t transform is the transform of the object that the script is on
		transform.position = player.position + offSet;
	}
}
