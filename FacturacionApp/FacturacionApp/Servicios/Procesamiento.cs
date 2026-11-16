using FacturacionApp.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApp.Servicios
{
    public class Procesamiento
    {
        private Validaciones _validaciones;
        private CalculoTarifas _calculoTarifas;
        private Etiquetas _etiquetas;

        public Procesamiento(CalculoTarifas calculoTarifas, Etiquetas etiquetas)
        {
            _etiquetas = etiquetas;
            _validaciones = new Validaciones(etiquetas);
            _calculoTarifas = calculoTarifas;
        }

        // Procesar los registros escritos por el usuario
        public Paquete[] ProcesarTexto(string texto, out string[] errores, out int cantidadErrores, out int cantidadPaquetes)
        {
            errores = new string[0];
            cantidadErrores = 0;
            cantidadPaquetes = 0;

            if (string.IsNullOrWhiteSpace(texto))
            {
                return new Paquete[0];
            }

            string textoNormalizado = texto.Replace("\r\n", "\n").Replace('\r', '\n');

            string[] lineas = textoNormalizado.Split('\n');

            // Quitar únicamente el último elemento vacío
            // causado por un salto de línea al final.
            if (lineas.Length > 0 &&
                string.IsNullOrWhiteSpace(lineas[lineas.Length - 1]))
            {
                Array.Resize(ref lineas, lineas.Length - 1);
            }

            ArregloPaquetes arreglo = new ArregloPaquetes();
            errores = new string[lineas.Length];

            for (int i = 0; i < lineas.Length; i++)
            {
                string linea = lineas[i].Trim();

                // Detectar líneas vacías
                if (string.IsNullOrWhiteSpace(linea))
                {
                    errores[cantidadErrores] = _etiquetas.EtiquetaLinea + " " + (i + 1) + ": " + _etiquetas.MensajeLineaVacia;
                    cantidadErrores++;
                    continue;
                }

                string[] campos = linea.Split(';');

                // Verificar que existan exactamente 5 campos
                if (campos.Length != 5)
                {
                    errores[cantidadErrores] = _etiquetas.EtiquetaLinea + " " + (i + 1) + ": " + _etiquetas.MensajeCamposIncorrectos;
                    cantidadErrores++;
                    continue;
                }

                string codigo = campos[0].Trim();
                string cliente = campos[1].Trim();
                string zona = campos[2].Trim();

                decimal peso;
                decimal valorDeclarado;

                // Convertir el peso
                if (!decimal.TryParse(campos[3].Trim(), out peso))
                {
                    errores[cantidadErrores] = _etiquetas.EtiquetaLinea + " " + (i + 1) + ": " + _etiquetas.MensajePesoInvalido;
                    cantidadErrores++;
                    continue;
                }

                // Convertir el valor declarado
                if (!decimal.TryParse(
                    campos[4].Trim(), out valorDeclarado))
                {
                    errores[cantidadErrores] = _etiquetas.EtiquetaLinea + " " + (i + 1) + ": " + _etiquetas.MensajeValorInvalido;
                    cantidadErrores++;
                    continue;
                }

                Paquete paquete = new Paquete
                {
                    Codigo = codigo,
                    Cliente = cliente,
                    Zona = zona,
                    Peso = peso,
                    ValorDeclarado = valorDeclarado
                };

                // Validar los datos
                if (!_validaciones.ValidarPaquete(
                    paquete, out string error))
                {
                    errores[cantidadErrores] = _etiquetas.EtiquetaLinea + " " + (i + 1) + ": " + error;
                    cantidadErrores++;
                    continue;
                }

                arreglo.Agregar(paquete);
                cantidadPaquetes++;
            }

            // Ordenar los paquetes de mayor a menor costo
            arreglo.OrdenarPorCosto(_calculoTarifas);

            return arreglo.ObtenerPaquetes();
        }

        // Ordenar todos los resultados de mayor a menor costo
        public void OrdenarResultados(
            List<ResultadoPaquete> resultados)
        {
            for (int i = 0; i < resultados.Count - 1; i++)
            {
                for (int j = 0;
                    j < resultados.Count - 1 - i; j++)
                {
                    if (resultados[j].Factura.Total < resultados[j + 1].Factura.Total)
                    {
                        ResultadoPaquete temporal = resultados[j];
                        resultados[j] = resultados[j + 1];
                        resultados[j + 1] = temporal;
                    }
                }
            }
        }
    }
}
