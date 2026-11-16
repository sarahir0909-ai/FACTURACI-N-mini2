using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApp.Modelos
{
    public class ResultadoPaquete
    {
        private Paquete _paquete = null!;
        private DesgloseFactura _factura = null!;

        public Paquete Paquete
        {
            get { return _paquete; }
            set { _paquete = value; }
        }

        public DesgloseFactura Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        public string Codigo
        {
            get { return _paquete.Codigo; }
        }

        public string Cliente
        {
            get { return _paquete.Cliente; }
        }

        public string Zona
        {
            get { return _paquete.Zona; }
        }

        public decimal Peso
        {
            get { return _paquete.Peso; }
        }

        public decimal ValorDeclarado
        {
            get { return _paquete.ValorDeclarado; }
        }

        public decimal Total
        {
            get { return _factura.Total; }
        }
    }
}