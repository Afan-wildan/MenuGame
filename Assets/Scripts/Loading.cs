using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

	//waktu delay untuk load scene
	[SerializeField] private float delayLoading = 3f;

	//nama scene untuk pindah scene yang di inputkan pada inspector
	[SerializeField] private string nameScene;

	private float timElapsed;

	private void Update () {
		timElapsed += Time.deltaTime;

		if (timElapsed > delayLoading) {
		}
	}
}
