using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector2 jumpForce = new Vector3(0, .003f,0);
	private Rigidbody rb;
	Transform player;
	private float lockPos = 0;
	// Update is called once per frame
	private bool touched = false;

	void Start (){
		rb = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody>();
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>();

	}

	void Update ()
	{
		// Jump
		if (Input.GetKeyDown (KeyCode.Space) && !touched) 
		{
			rb.velocity = Vector3.zero;
			rb.AddForce(jumpForce);
		}

		player.rotation = Quaternion.Euler(player.rotation.eulerAngles.x, lockPos, lockPos);

		if (player.position.y <= -15) {
			Die ();
		}
	}

	void OnCollisionEnter(Collision col){
		touched = true;
	}

	void Die() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
