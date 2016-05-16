using UnityEngine;
using System.Collections;

public class smallsize : MonoBehaviour {
	public Vector3 spawnPoint;
	private Transform camPos;
	//public float speed = 0.5f;
	private int ranXPos = Random.Range (-5,6);

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