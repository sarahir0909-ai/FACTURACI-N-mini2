using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using FacturacionApp.Modelos;

namespace FacturacionApp.Servicios
{
    public class Idiomas
    {
        public List<Etiquetas> CargarIdiomas()
        {
            string ruta = Path.Combine(AppContext.BaseDirectory, "Recursos", "idiomas.json");

            if (!File.Exists(ruta))
            {
                throw new FileNotFoundException("No se encontró el archivo idiomas.json.", ruta);
            }

            string contenido = File.ReadAllText(ruta);

            List<Etiquetas> idiomas = JsonSerializer.Deserialize<List<Etiquetas>>(contenido) ?? new List<Etiquetas>();

            if (idiomas.Count == 0)
            {
                throw new InvalidOperationException("No se encontraron idiomas en el archivo JSON.");
            }

            return idiomas;
        }

        public Etiquetas ObtenerEtiquetas(List<Etiquetas> idiomas, int indice)
        {
            if (idiomas == null)
            {
                throw new ArgumentNullException(nameof(idiomas));
            }

            if (indice < 0 || indice >= idiomas.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return idiomas[indice];
        }
    }
}