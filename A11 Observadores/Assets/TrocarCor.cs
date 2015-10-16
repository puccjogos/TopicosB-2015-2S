using UnityEngine;
using System.Collections;

public class TrocarCor : MonoBehaviour {

	void Start () {
		Notificador.Colidiu += TratarColidiu;
	}

	void OnDestroy() {
		Notificador.Colidiu -= TratarColidiu;
	}

	void TratarColidiu (string tipo)
	{
		if (tipo == "Chao") {
			Camera.main.backgroundColor = Color.red;
		} else {
			Camera.main.backgroundColor = Color.yellow;
		}
	}
}
