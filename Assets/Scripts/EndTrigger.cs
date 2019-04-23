
using UnityEngine;

public class EndTrigger : MonoBehaviour {
	public GameManager gameManager;

	void OnTriggerEnter (Collider colliderInfo)
	{
		if (colliderInfo.GetComponent<Collider> ().tag == "Player") {
			gameManager.CompleteLevel ();
		}

	}
}
