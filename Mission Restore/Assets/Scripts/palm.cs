using UnityEngine;
using System.Collections;

public class palm : MonoBehaviour {
	public Vector3 spawnPoint;
	private Transform camPos;
	private int ranXPos = Random.Range (-5,6);

	void Start () {
		transform.position = new Vector3(ranXPos, spawnPoint.y, spawnPoint.z);
		camPos = GameObject.Find ("Main Camera").GetComponent<Transform>();
	}

	void Update () {
		transform.position += Vector3.back * 0.3f;
		if (transform.position.z < camPos.position.z) {
			Destroy (gameObject);
		}
	}
}
