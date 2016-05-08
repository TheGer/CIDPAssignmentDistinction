using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void playButtonPressed(){
		SceneManager.LoadScene ("1");
	}

	public void instrButtonPressed(){
		SceneManager.LoadScene ("instructions");
	}
	public void exitButtonPressed(){
		Application.Quit ();
	}

	public void mainmenuButtonPressed(){
		SceneManager.LoadScene ("mainmenu");
	}


}
