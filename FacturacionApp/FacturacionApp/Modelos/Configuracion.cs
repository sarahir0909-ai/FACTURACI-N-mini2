using System;
using System.Collections.Generic;
using System.Text;

namespace 
{
    public class Configuracion
    {
        // Campos privados
        private decimal _precioBaseKilogramo;
        private decimal _tasaIVA;
        private decimal _costoFijoEnvio;

        // Propiedades públicas
        public decimal PrecioBaseKilogramo
        {
            get { return _precioBaseKilogramo; }
            set { _precioBaseKilogramo = value; }
        }

        public decimal TasaIVA
        {
            get { return _tasaIVA; }
            set { _tasaIVA = value; }
        }

        public decimal CostoFijoEnvio
        {
            get { return _costoFijoEnvio; }
            set { _costoFijoEnvio = value; }
        }
    }
}
