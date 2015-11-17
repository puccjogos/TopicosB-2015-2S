using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bola : MonoBehaviour
{
	static List<Bola> todas = null;
	
	void Start()
	{
		if (todas == null)
		{
			todas = new List<Bola>();
		}
		todas.Add(this);
		Debug.Log("Bolas na cena: " + todas.Count);
	}
	
	public static void Destruir(int qtos)
	{
		for (var i = 0; i < qtos; i++)
		{
			if (todas.Count > 0)
			{
				Destroy(todas [0].gameObject);
				todas.RemoveAt(0);
			} else
			{
				return;
			}
		}
	}
}
