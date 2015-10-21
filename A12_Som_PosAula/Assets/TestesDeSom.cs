using UnityEngine;
using System.Collections;

public class TestesDeSom : MonoBehaviour {

	public AudioSource audio;

	void Start () {
			
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) {
			audio.Play ();
		}	
	}
}
