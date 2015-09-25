using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour
{
	public static int pontos = 0;
	
	public float velocidadeAngular;
	public float forcaFoguete;
	public float combustivel;
	public float taxaConsumo;
	
	private Rigidbody2D _rb;
	private float _inputX;
	private bool _fogueteLigado = false;

	void Start ()
	{
		_rb = GetComponent<Rigidbody2D> ();
	}
	
	void Update ()
	{
		_inputX = -Input.GetAxis ("Horizontal");
		_fogueteLigado = Input.GetKey (KeyCode.Z);
	}
	
	void FixedUpdate ()
	{
		_rb.angularVelocity = velocidadeAngular * _inputX;
		if (_fogueteLigado && combustivel > 0) {
			_rb.AddForce (transform.right * forcaFoguete);
			combustivel -= taxaConsumo * Time.fixedDeltaTime;
		}
		combustivel = Mathf.Max (0, combustivel);
	}
	
	void AlterarCombustivel (float novo)
	{
		combustivel += novo;
	}
}








