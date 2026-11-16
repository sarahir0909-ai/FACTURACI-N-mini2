using System;
using System.Collections.Generic;
using System.Text;

namespace 
{
	public class DesgloseFactura
	{
		// Campos privados
		private decimal _subtotalPeso;
		private decimal _recargoZona;
		private decimal _penalizacionPeso;
		private decimal _seguro;
		private decimal _impuesto;
		private decimal _costoFijo;
		private decimal _total;

		// Propiedades públicas
		public decimal SubtotalPeso
		{
			get { return _subtotalPeso; }
			set { _subtotalPeso = value; }
		}

		public decimal RecargoZona
		{
			get { return _recargoZona; }
			set { _recargoZona = value; }
		}

		public decimal PenalizacionPeso
		{
			get { return _penalizacionPeso; }
			set { _penalizacionPeso = value; }
		}

		public decimal Seguro
		{
			get { return _seguro; }
			set { _seguro = value; }
		}

		public decimal Impuesto
		{
			get { return _impuesto; }
			set { _impuesto = value; }
		}

		public decimal CostoFijo
		{
			get { return _costoFijo; }
			set { _costoFijo = value; }
		}

		public decimal Total
		{
			get { return _total; }
			set { _total = value; }
		}
	}
}
