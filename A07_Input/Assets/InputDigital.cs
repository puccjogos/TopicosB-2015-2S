using UnityEngine;
using System.Collections;

public class InputDigital : MonoBehaviour
{

	void Update ()
	{
		/* TECLAS 
		Debug.Log ("Pressionado: " + Input.GetKey (KeyCode.Space));
		Debug.Log ("Pressionou: " + Input.GetKeyDown (KeyCode.Space));
		Debug.Log ("Soltou: " + Input.GetKeyUp (KeyCode.Space));
		*/
		
		if (Input.GetButton ("Acao1")) {
			Camera.main.backgroundColor = Color.red;
		} else {
			Camera.main.backgroundColor = Color.white;
		}
	}
}
