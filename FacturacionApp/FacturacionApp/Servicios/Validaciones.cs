using FacturacionApp.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApp.Servicios
{
    public class Validaciones
    {
        private Etiquetas _etiquetas;

        public Validaciones(Etiquetas etiquetas)
        {
            _etiquetas = etiquetas;
        }

        // Método para validar los datos de un paquete
        public bool ValidarPaquete(Paquete paquete, out string error)
        {
            error = "";

            if (paquete == null)
            {
                error = _etiquetas.MensajePaqueteNulo;
                return false;
            }

            if (string.IsNullOrWhiteSpace(paquete.Codigo))
            {
                error = _etiquetas.MensajeCodigoObligatorio;
                return false;
            }

            if (string.IsNullOrWhiteSpace(paquete.Cliente))
            {
                error = _etiquetas.MensajeClienteObligatorio;
                return false;
            }

            if (string.IsNullOrWhiteSpace(paquete.Zona))
            {
                error = _etiquetas.MensajeZonaObligatoria;
                return false;
            }

            string zona = paquete.Zona.Trim().ToUpperInvariant();

            if (zona.StartsWith("ZONA "))
            {
                zona = zona.Substring(5).Trim();
            }

            if (zona != "A" && zona != "B" && zona != "C")
            {
                error = _etiquetas.MensajeZonaInvalida;
                return false;
            }

            if (paquete.Peso <= 0)
            {
                error = _etiquetas.MensajePesoMayorCero;
                return false;
            }

            if (paquete.ValorDeclarado < 0)
            {
                error = _etiquetas.MensajeValorNegativo;
                return false;
            }

            return true;
        }
    }
}
