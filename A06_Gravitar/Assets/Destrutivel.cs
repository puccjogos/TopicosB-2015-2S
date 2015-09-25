using UnityEngine;
using System.Collections;

public class Destrutivel : MonoBehaviour
{
	public bool estaVivo = true;
	public int pontos;
	
	void Update ()
	{
		if (!estaVivo) {
			Nave.pontos += pontos;
			Debug.Log ("Score: " + Nave.pontos);
			Destroy (gameObject);
		}
	}
	
	void OnCollisionEnter2D (Collision2D colisao)
	{
		estaVivo = false;
	} 
}
