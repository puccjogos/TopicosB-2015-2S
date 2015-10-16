using UnityEngine;
using System.Collections;

public class InverterGravidade : MonoBehaviour
{
	public float velocidadeY;
	private Rigidbody2D _rb;

	void Start ()
	{
		_rb = GetComponent<Rigidbody2D> ();
	}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			_rb.gravityScale *= -1;	
			//velocidadeY *= -1;
			//_rb.velocity = new Vector2 (_rb.velocity.x, velocidadeY);
		}
	}
}
