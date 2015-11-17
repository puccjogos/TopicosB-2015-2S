using UnityEngine;
using System.Collections;

public class Jogo : MonoBehaviour
{
	public static Jogo instancia;
	
	public float tempo;
	
	public Bola prefabBola;
	
	void Awake()
	{
		if (instancia == null)
		{
			instancia = this;
			DontDestroyOnLoad(this.gameObject);
		} else
		{
			Destroy(this.gameObject);
		}
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			if (Application.loadedLevel == 0)
			{
				Application.LoadLevel("Gameplay");
			} else
			{
				Application.LoadLevel("MenuInicial");
			}
				
		}
		
		if (Input.GetKeyDown(KeyCode.Q))
		{
			Instantiate(prefabBola, (Vector3)(Random.insideUnitCircle * 3f) + transform.position, Quaternion.identity);
		}
		
		if (Input.GetKeyDown(KeyCode.E))
		{
			Bola.Destruir(1);
		}
	}
}









