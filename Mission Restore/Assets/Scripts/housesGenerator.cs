using UnityEngine;
using System.Collections;

public class housesGenerator : MonoBehaviour {
	public Vector3 spawnPoint;
	private Transform camPos;
	void Start () {
		transform.position = new Vector3(spawnPoint.x, spawnPoint.y, spawnPoint.z);
		//transform.Rotate (Vector3 * Time.deltaTime);
		camPos = GameObject.Find ("Main Camera").GetComponent<Transform>();
	}

	void Update () {
		transform.position += Vector3.back * 0.5f;
		if (transform.position.z < ((camPos.position.z)-200) ){
			Destroy (gameObject);
		}
	}
}