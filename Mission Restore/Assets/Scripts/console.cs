using UnityEngine;
using System.Collections;

public class console : MonoBehaviour {
	
	public GameObject playerobj;
	public player script;



	//public AudioSource jumpsound;
	void Start () {

	}
	

	void Update () {

	}

	public void right(){
		if(playerobj.transform.position.x < 5 ){
			playerobj.transform.position += Vector3.right;	
		}
	}

	public void left(){
		if(playerobj.transform.position.x < 5 ){
			playerobj.transform.position += Vector3.left;	
		}
	}

	public void up(){
		Debug.Log ("up");
	
		/*player otherscript = GetComponent<player> ();
		otherscript.Jump();*/
		//jumpsound.Play ();
		script.Jump ();

	}
}
