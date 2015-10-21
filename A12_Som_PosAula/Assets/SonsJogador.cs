using UnityEngine;
using System.Collections;

public class SonsJogador : MonoBehaviour {
	public bool aleatorizar = true;
	public float variacao = 0.4f;
	public AudioSource audio;
	public AudioClip somPulo;

	void Pulou() {
		var volume = (aleatorizar) ? 
			1 + Random.Range (-variacao, variacao) : 1;
		var pitch = (aleatorizar) ? 
			1 + Random.Range (-variacao, variacao) : 1;
		audio.pitch = pitch;
		audio.PlayOneShot (somPulo, volume);
	}

	public void TocarSom(AudioClip som){
		var volume = (aleatorizar) ? 
			1 + Random.Range (-variacao, variacao) : 1;
		var pitch = (aleatorizar) ? 
			1 + Random.Range (-variacao, variacao) : 1;
		audio.pitch = pitch;
		audio.PlayOneShot (som, volume);
	}
}








