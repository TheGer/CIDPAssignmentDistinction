using UnityEngine;
using System.Collections;

public class cloud : MonoBehaviour {
	public Vector3 spawnPoint;
	private Transform camPos;
	private int ranXPos = Random.Range (-10,10);

	void Start () {
		transform.position = new Vector3(ranXPos, spawnPoint.y, spawnPoint.z);
		camPos = GameObject.Find ("Main Camera").GetComponent<Transform>();
	}

	void Update () {
		transform.position += Vector3.back * 0.5f;
		if (transform.position.z < camPos.position.z) {
			Destroy (gameObject);
		}
	}
}
