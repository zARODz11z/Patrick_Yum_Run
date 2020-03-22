using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CharacterSelect : MonoBehaviour {
	
	private Transform camera;
	public Vector3 offSet;    //stores 3 floats
	private GameObject right;
	private GameObject left;
	private Transform options;
	public AudioClip pop;
	public AudioSource source;
	public float ButtonSpeed;



	public Transform[] characters;
	private int pos = 0;

	// Use this for initialization
	void Start () {
		camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
		right = GameObject.FindGameObjectWithTag("rightBut");
		left = GameObject.FindGameObjectWithTag("leftButt");
		options = GameObject.FindGameObjectWithTag("characters").transform;
		characters = new Transform[options.childCount];
		for(int i=0;i<options.childCount;i++)
			{
			characters[i] = options.GetChild(i);
			}

		camera.position = characters[pos].position + offSet;
		


	}


	public void rightButton()
	{
		pos += 1;
		Debug.Log(pos);
		camera.position = characters[pos].position + offSet;
		source.Play();
		//GameObject.Find("Main Camera").GetComponent<AudioSource>.play();

		

	}

	public void leftButton()
	{
		Debug.Log(pos);

		pos -= 1;
		Debug.Log(pos);
		camera.position = characters[pos].position + offSet;
		source.Play();

		//pop.SetActive(true);

		//pop.SetActive(false);

	}

	public void confirm()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		Debug.Log("confirm");

	}
}
