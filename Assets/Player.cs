using UnityEngine;

public class Player : MonoBehaviour
{
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector2 jumpForce = new Vector3(0, .003f,0);
	private Rigidbody rb; 
	// Update is called once per frame

	void Start (){
		rb = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody>();
	}

	void Update ()
	{
		// Jump
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			rb.velocity = Vector3.zero;
			rb.AddForce(jumpForce);
		}
	}

	void OnCollisionEnter(Collision col){
		Debug.Log(col.collider.name);
	}
}
