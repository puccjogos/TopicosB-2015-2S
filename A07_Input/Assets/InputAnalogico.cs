using UnityEngine;
using System.Collections;

public class InputAnalogico : MonoBehaviour
{
	public float inputX;
	public float velocidadeX;

	void Update ()
	{
		inputX = Input.GetAxis ("Horizontal");	
		transform.Translate (inputX * velocidadeX, 0, 0);
	}
}
