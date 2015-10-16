using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Trofeus : MonoBehaviour {

	public Text msg;
	bool trofeuColisao = false;

	void Start(){
		// subscribe
		Notificador.Colidiu += DarTrofeuColisao;
	}

	void OnDestroy() {
		// unsubscribe
		Notificador.Colidiu -= DarTrofeuColisao;
	}

	void DarTrofeuColisao (string objeto) {
		if (!trofeuColisao) {
			// dar o trofeu
			msg.text = "Trofeu COLISAO com " + objeto;
			StartCoroutine("Limpar");
			trofeuColisao = true;
		}
	}

	IEnumerator Limpar() {
		for(var i = 0; i < 1000; i++){
			Debug.Log ("Aasdasdasd");
			yield return new WaitForEndOfFrame();
		}
		yield return new WaitForSeconds (0.5f);
		msg.text = "";
	}
}
