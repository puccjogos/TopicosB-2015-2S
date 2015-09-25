using UnityEngine;
using System.Collections;

public class ArmaAutomatica : MonoBehaviour
{
	public float taxaTiro;
	public Transform alvo;
	public float timer;
	public float velocidadeTiro;	
	public Rigidbody2D prefabBala;

	void Start ()
	{
		timer = taxaTiro;
	}
	
	void Update ()
	{
		if (alvo == null) {
			return;
		}
		
		transform.right = alvo.position - transform.position;
		timer -= Time.deltaTime;
		if (timer <= 0) {
			timer = taxaTiro;
			// disparar
			var bala = Instantiate (
				prefabBala,
				transform.position,
				transform.rotation) as Rigidbody2D;
			bala.velocity = transform.right * velocidadeTiro;
			Destroy (bala.gameObject, 4f);
		}
	}
}






