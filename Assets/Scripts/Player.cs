using UnityEngine;

public class Player : MonoBehaviour {
	public Rigidbody rb;
	public float Forwardforce = 2000f;
	public float sideForce = 500f;

	void FixedUpdate () 
	{
		rb.AddForce (0,0,Forwardforce*Time.deltaTime);

		if(Input.GetKey("d"))
		{
			rb.AddForce (sideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("a"))
		{
			rb.AddForce (-sideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
		if (rb.position.y < -1.0f) {
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
