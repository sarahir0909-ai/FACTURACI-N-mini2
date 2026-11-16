using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using M2.Modelos;

namespace FacturacionApp.Persistencia
{
	public class ConfiguracionArchivo
	{
		private Etiquetas _etiquetas;

		public ConfiguracionArchivo(Etiquetas etiquetas)
		{
			_etiquetas = etiquetas;
		}

		public Configuracion CargarConfiguracion()
		{
			string ruta = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

			if (!File.Exists(ruta))
			{
				throw new FileNotFoundException(_etiquetas.MensajeConfiguracionNoEncontrada, ruta);
			}

			try
			{
				string contenido = File.ReadAllText(ruta);

				using JsonDocument documento = JsonDocument.Parse(contenido);

				JsonElement seccion = documento.RootElement.GetProperty("Facturacion");

				Configuracion configuracion = JsonSerializer.Deserialize<Configuracion>(seccion.GetRawText()) ?? throw new InvalidOperationException(
						_etiquetas.MensajeConfiguracionNoCargada);

				if (configuracion.PrecioBaseKilogramo <= 0)
				{
					throw new InvalidOperationException(_etiquetas.MensajePrecioBaseInvalido);
				}

				if (configuracion.TasaIVA < 0 || configuracion.TasaIVA > 1)
				{
					throw new InvalidOperationException(_etiquetas.MensajeIVAInvalido);
				}

				if (configuracion.CostoFijoEnvio < 0)
				{
					throw new InvalidOperationException(_etiquetas.MensajeCostoFijoInvalido);
				}

				return configuracion;
			}
			catch (JsonException ex)
			{
				throw new InvalidOperationException(_etiquetas.MensajeConfiguracionInvalida, ex);
			}
			catch (KeyNotFoundException ex)
			{
				throw new InvalidOperationException(_etiquetas.MensajeSeccionFacturacionNoEncontrada, ex);
			}
		}
	}
}
