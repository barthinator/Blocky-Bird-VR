using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MeshPostProcessing : AssetPostprocessor {

	void OnPreprocessModel(){

		ModelImporter modImport = assetImporter as ModelImporter;

		if (modImport.name.Contains ("Test")) {
			modImport.addCollider = true;
		}
	}

	void OnPostprocessModel(GameObject g){

		if (g.name.EndsWith ("Test")) {

			g.AddComponent<Rigidbody> ();
			g.AddComponent<MeshCollider> ();
		}
	}
}