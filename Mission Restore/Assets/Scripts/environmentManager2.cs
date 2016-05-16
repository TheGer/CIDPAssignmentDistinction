using UnityEngine;
using System.Collections;

public class environmentManager2 : MonoBehaviour {
	public int spawnTimeHouses;
	private int timerhouses;
	void Start () {
		housesGenerator ();
	}
	
	// Update is called once per frame
	void Update () {
		timerhouses++;
		if (timerhouses >= spawnTimeHouses) {
			housesGenerator ();
			timerhouses = 2;
		}
	}

	void housesGenerator(){
		Instantiate (Resources.Load ("houses"));
	}
}
