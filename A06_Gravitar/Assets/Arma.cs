using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour
{
	public int municao;
	public float velocidadeTiro;	
	public Rigidbody2D prefabBala;
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.X)) {
			var bala = Instantiate (
				prefabBala,
				transform.position,
				transform.rotation) as Rigidbody2D;
			bala.velocity = transform.right * velocidadeTiro;
			Destroy (bala.gameObject, 4f);
		}
	}
}
