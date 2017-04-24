using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour {

	public Transform target;
	public Transform camera;
	private bool touched = false;


	// Use this for initialization
	void Start () {

		//Camera.main.transform.position  = target.position;
		camera.transform.position = target.position;
	}

	// Update is called once per frame
	void Update () {
		camera.transform.position = target.position;
		if (!touched) {
			target.transform.position += new Vector3 (0, 0, 5) * Time.deltaTime;
		}
	}

	void OnCollisionEnter(Collision col){
		touched = true;
	}
}
