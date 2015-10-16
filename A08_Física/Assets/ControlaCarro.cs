using UnityEngine;
using System.Collections;

public class ControlaCarro : MonoBehaviour
{
	public float velocidade;
	public WheelJoint2D[] rodas;
	
	void Update ()
	{
		foreach (var roda in rodas) {
			var motor = roda.motor;
			motor.motorSpeed = velocidade * Input.GetAxis ("Horizontal");
			roda.motor = motor;
		}	
	}
}
