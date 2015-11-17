using System;

public class JogoSimples
{
	private static JogoSimples _instancia = null;
	
	public static JogoSimples instancia
	{
		get
		{
			if (_instancia == null)
			{
				_instancia = new JogoSimples();
			}
			return _instancia;
		}
	}
}

