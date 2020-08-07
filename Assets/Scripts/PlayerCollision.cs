
using UnityEngine;
using UnityEngine.UI;//need to import the UI package to access text component

public class PlayerCollision : MonoBehaviour {
	
	public Player movement;
	public  GameObject pattyScore;
	private int pattyNum = 0;
	public AudioClip ohhBoy;
	public AudioClip zap;
	public static bool collidedWithPatty = false;
	public AudioSource audioSource;

	void Start(){

	}
	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle") 
		{
			audioSource.PlayOneShot (zap, 1);
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}


	}
	void OnTriggerEnter(Collider colliderInfo){
	{
		if (colliderInfo.GetComponent<Collider>().tag == "Patty"&&!collidedWithPatty) {
			collidedWithPatty = true;
			pattyScore.GetComponent<Text> ().text = pattyNum++.ToString();
			Debug.Log ("Hit a patty");
				audioSource.PlayOneShot (ohhBoy, 1);
		}


	}

}
}
