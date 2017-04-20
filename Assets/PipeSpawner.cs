using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	//private Transform player;
	public GameObject pipe;
	float iterations = 0.0f;
	float centerHeight;
	private Rigidbody player;
	public int triggerPosition = 40;

	private List<GameObject> pipesList = new List<GameObject>();
	//Need to create an array of all the instantiated pipes



	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		//player = GameObject.FindGameObjectWithTag ("Player").transform;
		//Debug.Log (player.position.z);
		while (pipesList.Count < 20) {
			iterations = iterations + 1.0f;
			centerHeight = Random.Range (0, 4);

			Vector3 offset = new Vector3 (0, centerHeight + 4, iterations * 10);
			Vector3 offsetFlip = new Vector3 (0, centerHeight - 4, iterations * 10);

			//Transform offsetLocation = player.transform;
			//offsetLocation.localPosition = offset;
			pipesList.Add ((GameObject)Instantiate (pipe, offset, Quaternion.Euler (new Vector3 (90.0f, 0.0f, 0.0f))));
			pipesList.Add ((GameObject)Instantiate (pipe, offsetFlip, Quaternion.Euler (new Vector3 (-90.0f, 0.0f, 0.0f))));
		} 

		//I do not think that we will be able to despawn the pipes unless we have trigger between the pipes, because
		//simply checking the position to see if it iterated a full pipe by a specific z value is inaccurate because update
		//is only ran once per fram. Meaning that the value of the player could be above 40 but never exactly at 40 to where
		//the condition will return true.

		//jk found out a way to do it XD

		if (player.position.z >= triggerPosition) {
			Destroy(pipesList[0], 1.0f);
			pipesList.RemoveAt (0);
			Destroy(pipesList[0], 1.0f);
			pipesList.RemoveAt (0);
			triggerPosition += 10;
			Debug.Log ("It worked");
		}

	}
}
