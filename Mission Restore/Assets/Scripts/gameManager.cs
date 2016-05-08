using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {
	public int spawnTimePalm;
	public int spawnTimeCan;
	public int spawnTimeChest;
	public int spawnTimeSupersize;
	public int spawnTimeSuperjump;
	public int spawnTimeSmallsize;


	private int timer2;
	private int timer3;
	private int timer;
	private int timer4;
	private int timer5;
	private int timer6;
	// Use this for initialization
	void Start() {
		palm1Generator();
		canGenerator();
		chestGenerator();
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
		if (timer >= spawnTimePalm) {
			palm1Generator ();
			timer = 5;
		}

		timer2++;
		if (timer2 >= spawnTimeCan) {
			canGenerator ();
			timer2 = 1;
		}

		timer3++;
		if (timer3 >= spawnTimeChest) {
			chestGenerator ();
			timer3 = 3;
		}
	
		timer4++;
		if (timer4 >= spawnTimeSupersize) {
			supersizeGenerator ();
			timer4 = 4;
		}

		timer5++;
		if (timer5 >= spawnTimeSuperjump) {
			superjumpGenerator ();
			timer5= 5;
		}

		timer6++;
		if (timer6 >= spawnTimeSmallsize) {
			smallsizeGenerator ();
			timer6 = 6;
		}
	}
	void palm1Generator(){
		Instantiate (Resources.Load("palm1")); 	
	}
	void chestGenerator(){
		Instantiate (Resources.Load("chest"));
	}

	void canGenerator(){
		Instantiate (Resources.Load("can")); 	
	}

	void supersizeGenerator(){
		Instantiate (Resources.Load("supersize")); 	
	}

	void superjumpGenerator(){
		Instantiate (Resources.Load("superjump")); 	
	}

	void smallsizeGenerator (){
		Instantiate (Resources.Load("smallsize"));
	}
}
