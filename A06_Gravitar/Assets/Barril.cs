using UnityEngine;
using System.Collections;

public class Barril : MonoBehaviour
{
	public float tempoCaptura;
	public float timer;
	public Transform alvo;
	
	void OnTriggerEnter2D (Collider2D outro)
	{
		if (outro.transform == alvo) {
			timer = tempoCaptura;
		}
	}
	
	void OnTriggerStay2D (Collider2D outro)
	{
		if (outro.transform == alvo) {
			timer -= Time.deltaTime;
			if (timer <= 0) {
				alvo.SendMessage ("AlterarCombustivel", 100f);
				Destroy (gameObject);
			}
		}
	}	
}
