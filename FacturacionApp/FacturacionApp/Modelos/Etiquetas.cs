using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApp.Modelos
{
    public class Etiquetas
    {
        public string Idioma { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;

        public string EtiquetaCodigo { get; set; } = string.Empty;
        public string EtiquetaCliente { get; set; } = string.Empty;
        public string EtiquetaZona { get; set; } = string.Empty;
        public string EtiquetaPeso { get; set; } = string.Empty;
        public string EtiquetaValorDeclarado { get; set; } = string.Empty;

        public string BotonProcesar { get; set; } = string.Empty;
        public string BotonExportar { get; set; } = string.Empty;
        public string BotonGuardar { get; set; } = string.Empty;
        public string BotonCancelar { get; set; } = string.Empty;

        public string EtiquetaSubtotal { get; set; } = string.Empty;
        public string EtiquetaRecargo { get; set; } = string.Empty;
        public string EtiquetaPenalizacion { get; set; } = string.Empty;
        public string EtiquetaSeguro { get; set; } = string.Empty;
        public string EtiquetaIVA { get; set; } = string.Empty;
        public string EtiquetaCostoFijo { get; set; } = string.Empty;
        public string EtiquetaTotal { get; set; } = string.Empty;
        public string EtiquetaErrores { get; set; } = string.Empty;

        public string MensajeSinPaquetes { get; set; } = string.Empty;
        public string MensajeProcesamientoCorrecto { get; set; } = string.Empty;
        public string MensajeErrorArchivo { get; set; } = string.Empty;
        public string MensajeExportacionCorrecta { get; set; } = string.Empty;
        public string MensajePaqueteNoSeleccionado { get; set; } = string.Empty;

        public string EtiquetaEntrada { get; set; } = string.Empty;
        public string TituloTabla { get; set; } = string.Empty;

        public string ColumnaCodigo { get; set; } = string.Empty;
        public string ColumnaCliente { get; set; } = string.Empty;
        public string ColumnaZona { get; set; } = string.Empty;
        public string ColumnaPeso { get; set; } = string.Empty;
        public string ColumnaValorDeclarado { get; set; } = string.Empty;
        public string ColumnaTotal { get; set; } = string.Empty;

        public string TituloFactura { get; set; } = string.Empty;
        public string TituloErrores { get; set; } = string.Empty;

        public string MensajeErrorConfiguracion { get; set; } = string.Empty;
        public string MensajeGuardarCorrecto { get; set; } = string.Empty;
        public string EtiquetaPaquetesGuardados { get; set; } = string.Empty;
        public string EtiquetaPaquetesExistentes { get; set; } = string.Empty;
        public string EtiquetaTotalLote { get; set; } = string.Empty;
        public string EtiquetaPaquetesValidos { get; set; } = string.Empty;
        public string EtiquetaErroresEncontrados { get; set; } = string.Empty;
        public string MensajePesoMayorCero { get; set; } = string.Empty;
        public string MensajePaqueteNulo { get; set; } = string.Empty;
        public string MensajeCodigoObligatorio { get; set; } = string.Empty;
        public string MensajeClienteObligatorio { get; set; } = string.Empty;
        public string MensajeZonaObligatoria { get; set; } = string.Empty;
        public string MensajeZonaInvalida { get; set; } = string.Empty;
        public string MensajeValorNegativo { get; set; } = string.Empty;
        public string MensajeLineaVacia { get; set; } = string.Empty;
        public string MensajeCamposIncorrectos { get; set; } = string.Empty;
        public string MensajePesoInvalido { get; set; } = string.Empty;
        public string MensajeValorInvalido { get; set; } = string.Empty;
        public string EtiquetaLinea { get; set; } = string.Empty;

        public string MensajeConfiguracionNoEncontrada { get; set; } = string.Empty;
        public string MensajeConfiguracionInvalida { get; set; } = string.Empty;
        public string MensajeConfiguracionNoCargada { get; set; } = string.Empty;
        public string MensajePrecioBaseInvalido { get; set; } = string.Empty;
        public string MensajeIVAInvalido { get; set; } = string.Empty;
        public string MensajeCostoFijoInvalido { get; set; } = string.Empty;
        public string MensajeSeccionFacturacionNoEncontrada { get; set; } = string.Empty;
    }
}
