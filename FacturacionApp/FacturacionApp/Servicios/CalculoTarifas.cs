using FacturacionApp.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApp.Servicios
{
    public class CalculoTarifas
    {
        // Campo privado
        private Configuracion _configuracion;

        // Constructor
        public CalculoTarifas(Configuracion configuracion)
        {
            if (configuracion == null)
            {
                throw new ArgumentNullException(nameof(configuracion));
            }
            _configuracion = configuracion;
        }

        // Método para calcular la factura de un paquete
        public DesgloseFactura CalcularFactura(Paquete paquete)
        {
            if (paquete == null)
            {
                throw new ArgumentNullException(nameof(paquete));
            }

            if (string.IsNullOrWhiteSpace(paquete.Zona))
            {
                throw new ArgumentException("La zona del paquete es obligatoria."
                );
            }

            DesgloseFactura desglose = new DesgloseFactura();

            // 1. Subtotal por peso
            desglose.SubtotalPeso =
                paquete.Peso * _configuracion.PrecioBaseKilogramo;

            // 2. Recargo según la zona
            decimal porcentajeZona;

            string zona = paquete.Zona.Trim().ToUpperInvariant();

            // Eliminar el prefijo ZONA si está presente
            if (zona.StartsWith("ZONA "))
            {
                zona = zona.Substring(5).Trim();
            }

            switch (zona)
            {
                case "A":
                    porcentajeZona = 0.05m;
                    break;

                case "B":
                    porcentajeZona = 0.10m;
                    break;

                case "C":
                    porcentajeZona = 0.18m;
                    break;

                default:
                    throw new ArgumentException("La zona del paquete no es válida.");
            }

            desglose.RecargoZona = desglose.SubtotalPeso * porcentajeZona;

            // 3. Penalización por exceso de 20 kg
            if (paquete.Peso > 20)
            {
                decimal kilosExtra = paquete.Peso - 20;

                desglose.PenalizacionPeso = kilosExtra * _configuracion.PrecioBaseKilogramo * 0.25m;
            }
            else
            {
                desglose.PenalizacionPeso = 0;
            }

            // 4. Seguro obligatorio
            if (paquete.ValorDeclarado > 1000)
            {
                desglose.Seguro =
                    paquete.ValorDeclarado * 0.02m;
            }
            else
            {
                desglose.Seguro = 0;
            }
            // 5. Costo fijo
            desglose.CostoFijo = _configuracion.CostoFijoEnvio;

            // 6. Base gravable
            decimal baseGravable = desglose.SubtotalPeso + desglose.RecargoZona + desglose.PenalizacionPeso + desglose.Seguro + desglose.CostoFijo;

            // 7. IVA
            desglose.Impuesto = baseGravable * _configuracion.TasaIVA;
            // 8. Total
            desglose.Total = baseGravable + desglose.Impuesto;

            return desglose;
        }
    }
}
