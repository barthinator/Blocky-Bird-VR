using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MeshLoadingTesting : MonoBehaviour {

	public string FilePath;
	public string FBXName, AnimatorName, ColliderName;

	void Start () {
		GameObject go = AssetDatabase.LoadAssetAtPath<GameObject> ("Assets/pipe1.blend");

		MeshCollider mc = go.GetComponent<MeshCollider> ();

		if (!mc) {
			Debug.Log ("The mesh collider was not grabbed.");
		}

		Rigidbody rb = go.GetComponent<Rigidbody> ();

		if (!rb) {
			Debug.Log ("The rigid body was not grabbed.");
		}
	}
}