using UnityEngine;
using System.Collections;

public class environmentManager3 : MonoBehaviour {
	public int spawnTimeEnvTree1;
	private int timer1;

	public int spawnTimeEnvTree2;
	private int timer2;

	public int spawnTimeCloud;
	private int timer3;


	void Start () {
		envtree1Generator ();
		envtree2Generator ();
	}


	void Update () {
		timer1++;
		if (timer1 >= spawnTimeEnvTree1) {
			envtree1Generator();
			timer1 = 2;
		}

		timer2++;
		if (timer2 >= spawnTimeEnvTree2) {
			envtree2Generator();
			timer2 = 2;
		}

		timer3++;
		if (timer3 >= spawnTimeCloud) {
			cloudGenerator ();
			timer3 = 0;
		}

	}

	void envtree1Generator (){
		Instantiate (Resources.Load ("envtree1")); 	
	}

	void envtree2Generator (){
		Instantiate (Resources.Load ("envtree2")); 	
	}
	void cloudGenerator(){
		Instantiate (Resources.Load ("cloud")); 	
	}
}