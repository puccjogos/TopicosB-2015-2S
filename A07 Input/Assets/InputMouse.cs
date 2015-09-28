using UnityEngine;
using System.Collections;

public class InputMouse : MonoBehaviour
{
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			transform.Translate (0.2f, 0, 0);
		}	
		
		Debug.Log ("PIXELS: " + Input.mousePosition);
		var emPixels = Input.mousePosition;
		print ("MUNDO: " + Camera.main.ScreenToWorldPoint (emPixels));
	}
	
	void OnMouseEnter ()
	{
		GetComponent<SpriteRenderer> ().color = Color.red;
	}
	
	void OnMouseDrag ()
	{
		GetComponent<SpriteRenderer> ().color = Color.green;
	}
	
	void OnMouseExit ()
	{
		GetComponent<SpriteRenderer> ().color = Color.white;
	}
}
