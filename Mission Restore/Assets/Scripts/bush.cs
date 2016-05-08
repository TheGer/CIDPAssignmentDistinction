using UnityEngine;
using System.Collections;

public class bush : MonoBehaviour {
	public Vector3 spawnPoint;
	private Transform camPos;
	//public int speed = 1;
	private int ranXPos = Random.Range (-5,6);

	void Start () {
		transform.position = new Vector3(ranXPos, spawnPoint.y, spawnPoint.z);
		//transform.Rotate (Vector3 * Time.deltaTime);
		camPos = GameObject.Find ("Main Camera").GetComponent<Transform>();
	}

	void Update () {
		transform.position += Vector3.back * 0.8f;
		if (transform.position.z < camPos.position.z) {
			Destroy (gameObject);
		}
	}
}