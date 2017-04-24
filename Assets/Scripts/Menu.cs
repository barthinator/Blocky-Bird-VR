using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public Canvas MainCanvas;
	public Canvas OptionsCanvas;

	//Starts before the unity start method
	void Awake(){
		OptionsCanvas.enabled = false;
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
