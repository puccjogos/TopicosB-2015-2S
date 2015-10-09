using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

	private Rigidbody2D _rb;
	public Animator anim;
	private float _inputX;
	public float velocidade;
	public Transform visual;

	void Start () {
		_rb = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		_inputX = Input.GetAxis ("Horizontal");
		anim.SetFloat ("VelocidadeX", Mathf.Abs (_rb.velocity.x));
		if (_inputX != 0) {
			var escala = visual.localScale;
			escala.x = Mathf.Sign(_inputX);
			visual.localScale = escala;
		}
	}

	void FixedUpdate() {
		var velo = _rb.velocity;
		velo.x = _inputX * velocidade;
		_rb.velocity = velo;
	}

}
