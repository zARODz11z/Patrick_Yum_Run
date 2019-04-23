using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	bool gameHasEnded = false;
	public float restartDelay = 1f;
	public GameObject CompleteLevelUI;

	public void EndGame () 
	{
		if (gameHasEnded == false) 
		{
			gameHasEnded = true;
			Debug.Log ("GAME OVER");//restart game
			Invoke("Restart",restartDelay);//Invoke allows you to call a method with a delay as the second parameter
		}								
	}
	public void CompleteLevel()
	{
		CompleteLevelUI.SetActive (true);//enables the disabled level complete UI
	}

	void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
