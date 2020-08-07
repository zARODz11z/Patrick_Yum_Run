using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public Rigidbody rb;
	public static float Forwardforce = 2000f;
	public float sideForce = 500f;
	public Animator anim;


	void FixedUpdate () 
	{
		if(PlayerCollision.collidedWithPatty)
		{
			TimeWaiter();
			

		}
		Forwardforce = 3500f;
		anim.SetBool("run", true);		
		rb.AddForce(0, 0, Forwardforce * Time.deltaTime);

		if (Input.GetKey("d"))
		{
			rb.AddForce (sideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
		else if(Input.GetKey("a"))
		{
			rb.AddForce (-sideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
		else if (rb.position.y < -1.0f) {
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}

	IEnumerator TimeWaiter()
	{
		anim.SetBool("eat", true);
		yield return new WaitForSeconds(2f);
		Debug.Log("test");
		//my code here after 3 seconds
	}
}
