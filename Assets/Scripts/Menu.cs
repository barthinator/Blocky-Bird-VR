using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public Canvas MainCanvas;
	public Canvas OptionsCanvas;
	public Transform spinner;

	//Starts before the unity start method
	void Awake(){
		OptionsCanvas.enabled = false;
	}

	void Update(){
		spinner.Rotate(0,0,40*Time.deltaTime);
	}

	public void OptionsOn(){
		OptionsCanvas.enabled = true;
		MainCanvas.enabled = false;
	}

	public void ReturnOn(){
		OptionsCanvas.enabled = false;
		MainCanvas.enabled = true;
	}

	public void LoadOn(){
		SceneManager.LoadScene(1);
	}
		
}
