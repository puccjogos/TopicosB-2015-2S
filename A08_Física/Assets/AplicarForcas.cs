using UnityEngine;
using System.Collections;

public class AplicarForcas : MonoBehaviour
{
	public Vector2 forca;
	private Rigidbody2D _rb;
	
	void Start ()
	{
		_rb = GetComponent<Rigidbody2D> ();
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			//_rb.AddForce (forca, ForceMode2D.Impulse);
			_rb.AddTorque (forca.magnitude, ForceMode2D.Impulse);
		}
	}
}
