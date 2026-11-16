public class Paquete
{
	// Campos privados
	private string _codigo = string.Empty;
	private string _cliente = string.Empty;
	private string _zona = string.Empty;
	private decimal _peso;
	private decimal _valorDeclarado;

	// Propiedades públicas
	public string Codigo
	{
		get { return _codigo; }
		set { _codigo = value; }
	}

	public string Cliente
	{
		get { return _cliente; }
		set { _cliente = value; }
	}

	public string Zona
	{
		get { return _zona; }
		set { _zona = value; }
	}

	public decimal Peso
	{
		get { return _peso; }
		set { _peso = value; }
	}

	public decimal ValorDeclarado
	{
		get { return _valorDeclarado; }
		set { _valorDeclarado = value; }
	}
}
}
