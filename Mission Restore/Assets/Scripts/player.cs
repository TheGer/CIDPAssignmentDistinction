using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {
	public int score;

	bool supersize = false;
	bool superjump = false;
	bool smallsize = false;
	public bool isFalling;

	Animator mega;
	public GameObject Megatext;

	Animator jump;
	public GameObject Jumptext;

	Animator mini;
	public GameObject Minitext;

	public GUIStyle mystyle;


	public AudioSource cansound;
	public AudioSource jumpsound;
	public AudioSource smallsizeeffect;
	public AudioSource supersizeeffect;
	public AudioSource superjumpeffect;

	void Start () {
		isFalling = false;
		mega = Megatext.GetComponent<Animator>();
		mini = Minitext.GetComponent<Animator>();
		jump = Jumptext.GetComponent<Animator>();

	}




	void Update () {
		
		if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 5 ){
            transform.position += Vector3.right;	
		}

		if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -5 ){
            transform.position += Vector3.left;
        }


		if (Input.GetKeyDown(KeyCode.Space) && isFalling == false){
			if (superjump == true){
				jumpsound.Play ();
				Vector3 jump = new Vector3 (0.0f, 550f, 0.0f);
				GetComponent<Rigidbody> ().AddForce(jump);
				isFalling = true;

			}else{
				jumpsound.Play ();
				Vector3 jump = new Vector3 (0.0f, 350f/*jump height */, 0.0f);
				GetComponent<Rigidbody> ().AddForce(jump);
				isFalling = true;

			}
		} 


		if (Input.GetKeyDown(KeyCode.Mouse2) && isFalling == false){
			if (superjump == true){
				jumpsound.Play ();
				Vector3 jump = new Vector3 (0.0f, 550f, 0.0f);
				GetComponent<Rigidbody> ().AddForce(jump);
				isFalling = true;
			}else{
				jumpsound.Play ();
				Vector3 jump = new Vector3 (0.0f, 350f/*jump height */, 0.0f);
				GetComponent<Rigidbody> ().AddForce(jump);
				isFalling = true;
			}
		} 




    }





	void OnGUI(){
		GUI.color = Color.black;
		GUI.Label (new Rect(0, 0, 100, 25), "Score: "+score, mystyle);

	}




	void OnTriggerEnter (Collider other){
		if (other.tag == "palm1") {
			SceneManager.LoadScene("gameoverlost");
		}
		if (other.tag == "car") {
			SceneManager.LoadScene("gameoverlost");
		}
		if (other.tag == "chest") {
			SceneManager.LoadScene("gameoverlost");
		}
		if (other.tag == "tree") {
			SceneManager.LoadScene("gameoverlost");
		}
		if (other.tag == "bush") {
			SceneManager.LoadScene("gameoverlost");
		}

		if (other.tag == "floor") {
			isFalling = false;
		}

		if (other.tag == "can") {
			score += 1;

			cansound.Play();
			Destroy (other.gameObject);
			if (score >= 20) {
				if (Application.loadedLevelName == "1") {
					SceneManager.LoadScene ("2");
				}
			}
			if (score >= 40) {
				if (Application.loadedLevelName == "2") {
					SceneManager.LoadScene ("3");
				}
			}
			if (score >= 60) {
				if (Application.loadedLevelName == "3") {
					SceneManager.LoadScene ("gameoverwin");
				}
			}
		}



		if (other.tag == "supersize") {
			supersizeeffect.Play ();
			Destroy (other.gameObject);
			StartCoroutine (Supersize ());
			mega.SetTrigger("mega");
		}


		if (other.tag == "superjump") {
			superjumpeffect.Play ();
			jump.SetTrigger("jump");
			Destroy (other.gameObject);
			StartCoroutine (Superjump ());
		}

		if (other.tag == "smallsize") {
			smallsizeeffect.Play ();
			mini.SetTrigger("mini");
			Destroy (other.gameObject);
			StartCoroutine (Smallsize ());
		}

	}





	IEnumerator Supersize (){
		supersize = true;
		if (supersize == true) {
			yield return new WaitForSeconds (1);
			transform.localScale += new Vector3 (0.3F, 0.3F, 0.3F);
			yield return new WaitForSeconds (5);
			transform.localScale += new Vector3 (-0.3F, -0.3F, -0.3F);
			supersize = false;
		}
	}






	IEnumerator Superjump (){
		superjump = true;
		yield return new WaitForSeconds (1);
		if (superjump == true) {
			yield return new WaitForSeconds (10);
			superjump = false;
		}
	}




	public IEnumerator Smallsize (){
		smallsize = true;
		if (smallsize== true) {
			yield return new WaitForSeconds (1);
			transform.localScale += new Vector3 (-0.3F, -0.3F, -0.3F);
			yield return new WaitForSeconds (6);
			transform.localScale += new Vector3 (0.3F, 0.3F, 0.3F);
			smallsize = false;
		}
	}

	public void Jump(){
		if ( isFalling == false){
			if (superjump == true){
				Vector3 jump = new Vector3 (0.0f, 550f, 0.0f);
				GetComponent<Rigidbody> ().AddForce(jump);
				isFalling = true;
				jumpsound.Play ();
			}
			else{
				Vector3 jump = new Vector3 (0.0f, 350f, 0.0f);
				GetComponent<Rigidbody> ().AddForce(jump);
				isFalling = true;
				jumpsound.Play ();
			}
		} 
	}
		
}
