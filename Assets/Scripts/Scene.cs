using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

	//pindah scene ke menu
	public void MenuScene(){
		SceneManager.LoadScene ("Menu");
	}

	//pindah scene loading
	public void LoadingScene(){
		SceneManager.LoadScene ("Loading");
	}

	//keluar dari game
	public void KeluarScene(){
		Application.Quit ();
	}
	// Use this for initialization
	void Start (){ 
	}
	
	// Update is called once per frame
	void Update () {
	
}
}