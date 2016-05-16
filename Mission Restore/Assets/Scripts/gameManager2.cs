using UnityEngine;
using System.Collections;

public class gameManager2 : MonoBehaviour {
	public int spawnTimeCar;
	private int timercar;

	public int spawnTimeCan;
	private int timercan;


	public int spawnTimeCar2;
	private int timercar2;


	public int spawnTimeSupersize;
	private int timersupersize;

	public int spawnTimeMinisize;
	private int timerminisize;

	public int spawnTimeSuperjump;
	private int timersuperjump;


	void Start () {
		carGenerator ();
	}
	

	void Update () {
		timercar++;
		if (timercar >= spawnTimeCar){
			carGenerator();
			timercar = 1;
		}


		timercan++;
		if (timercan >= spawnTimeCan) {
			canGenerator ();
			timercan = 2;
		}


		timercar2++;
		if (timercar2 >= spawnTimeCar2) {
			car2Generator ();
			timercar2 = 3;
		}


		timersupersize++;
		if (timersupersize >= spawnTimeSupersize) {
			supersizeGenerator ();
			timersupersize = 4;
		}



		timerminisize++;
		if (timerminisize >= spawnTimeMinisize) {
			minisizeGenerator ();
			timerminisize = 5;
		}

		timersuperjump++;
		if (timersuperjump >= spawnTimeSuperjump) {
			superjumpGenerator ();
			timersuperjump = 6;
		}
	}

	void carGenerator(){
		Instantiate(Resources.Load("car"));
	}

	void canGenerator(){
		Instantiate(Resources.Load("can"));
	}

	void car2Generator(){
		Instantiate(Resources.Load("car2"));
	}

	void supersizeGenerator(){
		Instantiate (Resources.Load("supersize")); 	
	}

	void superjumpGenerator(){
		Instantiate (Resources.Load("superjump")); 	
	}

	void minisizeGenerator (){
		Instantiate (Resources.Load("smallsize"));
	}
}
