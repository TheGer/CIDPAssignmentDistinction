using UnityEngine;
using System.Collections;

public class environmentManager: MonoBehaviour {
	public int spawnTimeIsland;
	private int timer;

	public int spawnTimeIsland2;
	private int timer2;

	public int spawnTimeCloud;
	private int timer3;

	void Start () {
		islandGenerator();
		island2Generator();
		cloudGenerator ();
	}


	void Update () {
		timer++;
		if (timer >= spawnTimeIsland) {
			islandGenerator();
			timer = 0;
		}
		timer2++;
		if (timer2 >= spawnTimeIsland2) {
			island2Generator();
			timer2 = 0;
		}
		timer3++;
		if (timer3 >= spawnTimeCloud) {
			cloudGenerator ();
			timer3 = 0;
		}
	}

	void islandGenerator(){
		Instantiate (Resources.Load ("island")); 	
	}

	void island2Generator(){
		Instantiate (Resources.Load ("island2")); 	
	}
	void cloudGenerator(){
		Instantiate (Resources.Load ("cloud")); 	
	}
}