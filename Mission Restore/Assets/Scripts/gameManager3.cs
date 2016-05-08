using UnityEngine;
using System.Collections;

public class gameManager3 : MonoBehaviour {
	public int spawnTimeTree;
	private int timertree;

	public int spawnTimeBush;
	private int timerbush;

	public int spawnTimeCan;
	private int timercan;

	public int spawnTimeSupersize;
	private int timersupersize;

	public int spawnTimeMinisize;
	private int timerminisize;

	public int spawnTimeSuperjump;
	private int timersuperjump;

	void Start () {
		treeGenerator ();
		bushGenerator ();
	}
	

	void Update () {
		timertree++;
		if (timertree >= spawnTimeTree) {
			treeGenerator ();
			timertree = 1;
		}

		timerbush++;
		if (timerbush >= spawnTimeBush) {
			bushGenerator ();
			timerbush = 2;
		}


		timercan++;
		if (timercan >= spawnTimeCan) {
			canGenerator ();
			timercan = 2;
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

	void treeGenerator(){
		Instantiate (Resources.Load("tree"));
	}

	void bushGenerator(){
		Instantiate (Resources.Load("bush"));
	}

	void canGenerator(){
		Instantiate(Resources.Load("can"));
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
