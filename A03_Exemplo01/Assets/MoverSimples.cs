using UnityEngine;
using System.Collections;

public class MoverSimples : MonoBehaviour
{
	[Range(-0.2f, 0.2f)]
	public float
		velocidadeZ;
	
	void Update ()
	{
		Debug.Log ("teste");
		float input = Input.GetAxis ("Vertical");
		transform.position = transform.position + 
			new Vector3 (0, 0, input * velocidadeZ);	
	}
}
