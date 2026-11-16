using FacturacionApp.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApp.Servicios
{
    public class ArregloPaquetes
    {
        // Arreglo inicial con capacidad para 5 paquetes
        private Paquete[] _paquetes = new Paquete[5];

        // Cantidad actual de paquetes almacenados
        private int _cantidad = 0;

        // Agregar un paquete al arreglo
        public void Agregar(Paquete paquete)
        {
            if (paquete == null)
            {
                throw new ArgumentNullException(nameof(paquete));
            }

            // Revisar si el arreglo está lleno
            if (_cantidad == _paquetes.Length)
            {
                Redimensionar();
            }

            _paquetes[_cantidad] = paquete;
            _cantidad++;
        }

        // Aumentar manualmente el tamaño del arreglo
        private void Redimensionar()
        {
            Paquete[] nuevoArreglo = new Paquete[_paquetes.Length * 2];

            for (int i = 0; i < _paquetes.Length; i++)
            {
                nuevoArreglo[i] = _paquetes[i];
            }
            _paquetes = nuevoArreglo;
        }

        // Ordenar paquetes de mayor a menor costo total
        public void OrdenarPorCosto(CalculoTarifas calculo)
        {
            if (calculo == null)
            {
                throw new ArgumentNullException(nameof(calculo));
            }

            for (int i = 0; i < _cantidad - 1; i++)
            {
                for (int j = 0; j < _cantidad - 1 - i; j++)
                {
                    decimal totalActual = calculo.CalcularFactura(_paquetes[j]).Total;

                    decimal totalSiguiente = calculo.CalcularFactura(_paquetes[j + 1]).Total;

                    if (totalActual < totalSiguiente)
                    {
                        Paquete temporal = _paquetes[j];
                        _paquetes[j] = _paquetes[j + 1];
                        _paquetes[j + 1] = temporal;
                    }
                }
            }
        }

        // Obtener los paquetes almacenados
        public Paquete[] ObtenerPaquetes()
        {
            Paquete[] resultado = new Paquete[_cantidad];

            for (int i = 0; i < _cantidad; i++)
            {
                resultado[i] = _paquetes[i];
            }
            return resultado;
        }

        // Consultar la cantidad de paquetes
        public int ObtenerCantidad()
        {
            return _cantidad;
        }
    }
}
