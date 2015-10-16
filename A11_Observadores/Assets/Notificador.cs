using UnityEngine;
using System.Collections;

public delegate void Notificacao (string tipo);

public class Notificador : MonoBehaviour {

	public static event Notificacao Colidiu;

	void OnCollisionEnter2D(Collision2D colisao) {
		if (Colidiu != null) {
			Colidiu (colisao.gameObject.name);
		}
	}
}
