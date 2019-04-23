using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Collections;

public class ButtonManagement : MonoBehaviour {
	
	public float ButtonSpeed;
	//public GameObject cam;
	public GameObject pop;
	public GameObject Bubbles;


	public void Quit()
	{
		Debug.Log ("Quit");
		Invoke ("Quit", ButtonSpeed);
	}

	public void Restart()
	{
		pop.SetActive (false);
		Invoke("LoadStart",ButtonSpeed);//SceneManager.LoadScene ("Level_1");
	}

	public void Help()
	{
		pop.SetActive (true);
		Invoke("LoadHelp",1);

	}

	public void NextLevel()
	{
		Bubbles.SetActive (true);
		Invoke ("LoadNextLevel", ButtonSpeed);

	}



	public void LoadHelp(){
		SceneManager.LoadScene ("Help");
		pop.SetActive (false);
	}

	public void LoadNextLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		Bubbles.SetActive (false);
	}
}

