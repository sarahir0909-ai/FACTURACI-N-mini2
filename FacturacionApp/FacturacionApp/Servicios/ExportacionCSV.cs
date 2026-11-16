using FacturacionApp.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FacturacionApp.Servicios
{
    public class ExportacionCSV
    {
        // Exportar los resultados a un archivo CSV
        public void Exportar(List<ResultadoPaquete> resultados, string ruta)
        {
            if (resultados == null || resultados.Count == 0)
                throw new InvalidOperationException("No hay paquetes para exportar.");

            using (StreamWriter escritor = new StreamWriter(ruta, false, new UTF8Encoding(true)))
            {
                escritor.WriteLine("Codigo,Cliente,Zona,Peso,ValorDeclarado," + "SubtotalPeso,RecargoZona,PenalizacionPeso," + "Seguro,IVA,CostoFijo,Total"
                );

                foreach (ResultadoPaquete resultado in resultados)
                {
                    Paquete paquete = resultado.Paquete;
                    DesgloseFactura factura = resultado.Factura;

                    string linea = string.Join(",",
                        EscaparCampo(paquete.Codigo),
                        EscaparCampo(paquete.Cliente),
                        EscaparCampo(paquete.Zona),
                        FormatearNumero(paquete.Peso),
                        FormatearNumero(paquete.ValorDeclarado),
                        FormatearNumero(factura.SubtotalPeso),
                        FormatearNumero(factura.RecargoZona),
                        FormatearNumero(factura.PenalizacionPeso),
                        FormatearNumero(factura.Seguro),
                        FormatearNumero(factura.Impuesto),
                        FormatearNumero(factura.CostoFijo),
                        FormatearNumero(factura.Total)
                    );
                    escritor.WriteLine(linea);
                }
            }
        }

        // Preparar los textos para evitar problemas con comillas
        private string EscaparCampo(string valor)
        {
            return "\"" + valor.Replace("\"", "\"\"") + "\"";
        }

        // Utilizar punto decimal en el archivo CSV
        private string FormatearNumero(decimal valor)
        {
            return valor.ToString("0.00", CultureInfo.InvariantCulture);
        }
    }
}
