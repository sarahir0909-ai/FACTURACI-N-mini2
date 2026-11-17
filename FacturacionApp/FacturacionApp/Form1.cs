using System.Configuration;
using FacturacionApp.Modelos;
using FacturacionApp.Servicios;
using FacturacionApp.Persistencia;

namespace FacturacionApp
{
    public partial class Form1 : Form
    {
        private Idiomas _gestorIdiomas = null!;
        private List<Etiquetas> _listaIdiomas = new List<Etiquetas>();
        private Etiquetas _etiquetasActuales = new Etiquetas();

        private Procesamiento _procesamiento = null!;
        private FacturacionApp.Servicios.CalculoTarifas _calculoTarifas = null!;
        private List<ResultadoPaquete> _resultados = new List<ResultadoPaquete>();
        private List<ResultadoPaquete> _resultadosLoteActual = new List<ResultadoPaquete>();
        private Configuracion _configuracion = null!;
        private FacturacionApp.Persistencia.ManejoBaseDatos _manejoBaseDatos = null!;
        private decimal _totalLoteActual = 0;


        public Form1()
        {
            InitializeComponent();
            ConfigurarTabla();

            btnProcesar.Click += btnProcesar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnExportar.Click += btnExportar_Click;

            dgvPaquetes.SelectionChanged += dgvPaquetes_SelectionChanged;

            _resultados = new List<ResultadoPaquete>();

            // 1. Cargar los idiomas primero
            _gestorIdiomas = new Idiomas();

            try
            {
                _listaIdiomas = _gestorIdiomas.CargarIdiomas();
                cmbIdioma.DataSource = _listaIdiomas;
                cmbIdioma.DisplayMember = "Idioma";
                cmbIdioma.SelectedIndex = 0;
                _etiquetasActuales = _gestorIdiomas.ObtenerEtiquetas(_listaIdiomas, cmbIdioma.SelectedIndex);
                cmbIdioma.SelectedIndexChanged += cmbIdioma_SelectedIndexChanged;
                AplicarIdioma();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar idiomas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnProcesar.Enabled = false;
                return;
            }

            // 2. Cargar la configuración con el idioma seleccionado
            try
            {
                ConfiguracionArchivo archivo = new ConfiguracionArchivo(_etiquetasActuales);

                _configuracion = archivo.CargarConfiguracion();

                _calculoTarifas = new FacturacionApp.Servicios.CalculoTarifas(_configuracion
                );
                // 3. Inicializar el procesamiento
                _procesamiento = new Procesamiento(_calculoTarifas, _etiquetasActuales
                );
                // 4. Inicializar la base de datos
                _manejoBaseDatos = new ManejoBaseDatos();
                _manejoBaseDatos.CrearBaseDatos();
                _resultados = _manejoBaseDatos.ObtenerPaquetes();

                // 5. Ordenar y mostrar los paquetes
                _procesamiento.OrdenarResultados(_resultados);

                dgvPaquetes.DataSource = null;
                dgvPaquetes.DataSource = _resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnProcesar.Enabled = false;
            }
        }


        private void AplicarIdioma()
        {
            this.Text = _etiquetasActuales.Titulo;

            // Encabezado
            lblTitulo.Text = _etiquetasActuales.Titulo;

            // Entrada de paquetes
            lblEntrada.Text = _etiquetasActuales.EtiquetaEntrada;
            btnProcesar.Text = _etiquetasActuales.BotonProcesar;

            lblTituloTabla.Text = _etiquetasActuales.TituloTabla;

            // Encabezados de la tabla
            dgvPaquetes.Columns["colCodigo"]!.HeaderText = _etiquetasActuales.ColumnaCodigo;
            dgvPaquetes.Columns["colCliente"]!.HeaderText = _etiquetasActuales.ColumnaCliente;
            dgvPaquetes.Columns["colZona"]!.HeaderText = _etiquetasActuales.ColumnaZona;
            dgvPaquetes.Columns["colPeso"]!.HeaderText = _etiquetasActuales.ColumnaPeso;
            dgvPaquetes.Columns["colValorDeclarado"]!.HeaderText = _etiquetasActuales.ColumnaValorDeclarado;
            dgvPaquetes.Columns["colTotal"]!.HeaderText = _etiquetasActuales.ColumnaTotal;

            // Desglose de factura
            grpFactura.Text = _etiquetasActuales.TituloFactura;

            lblSubtotalTitulo.Text = _etiquetasActuales.EtiquetaSubtotal;
            lblRecargoTitulo.Text = _etiquetasActuales.EtiquetaRecargo;
            lblPenalizacionTitulo.Text = _etiquetasActuales.EtiquetaPenalizacion;
            lblSeguroTitulo.Text = _etiquetasActuales.EtiquetaSeguro;
            lblIVATitulo.Text = _etiquetasActuales.EtiquetaIVA;
            lblCostoFijoTitulo.Text = _etiquetasActuales.EtiquetaCostoFijo;
            lblTotalTitulo.Text = _etiquetasActuales.EtiquetaTotal;

            // Errores
            grpErrores.Text = _etiquetasActuales.TituloErrores;

            // Botones
            btnGuardar.Text = _etiquetasActuales.BotonGuardar;
            btnExportar.Text = _etiquetasActuales.BotonExportar;

            // Total del lote
            lblTotalLote.Text = _etiquetasActuales.EtiquetaTotalLote + ": " + _totalLoteActual.ToString("C2");
        }


        private void ConfigurarTabla()
        {
            dgvPaquetes.Columns.Clear();
            dgvPaquetes.AutoGenerateColumns = false;

            dgvPaquetes.Columns.Add("colCodigo", "Código");
            dgvPaquetes.Columns.Add("colCliente", "Cliente");
            dgvPaquetes.Columns.Add("colZona", "Zona");
            dgvPaquetes.Columns.Add("colPeso", "Peso (kg)");
            dgvPaquetes.Columns.Add("colValorDeclarado", "Valor declarado");
            dgvPaquetes.Columns.Add("colTotal", "Total");

            dgvPaquetes.Columns["colCodigo"]!.DataPropertyName = "Codigo";
            dgvPaquetes.Columns["colCliente"]!.DataPropertyName = "Cliente";
            dgvPaquetes.Columns["colZona"]!.DataPropertyName = "Zona";
            dgvPaquetes.Columns["colPeso"]!.DataPropertyName = "Peso";
            dgvPaquetes.Columns["colValorDeclarado"]!.DataPropertyName = "ValorDeclarado";
            dgvPaquetes.Columns["colTotal"]!.DataPropertyName = "Total";
            dgvPaquetes.Columns["colTotal"]!.DefaultCellStyle.Format = "C2";
            dgvPaquetes.Columns["colValorDeclarado"]!.DefaultCellStyle.Format = "C2";
            dgvPaquetes.Columns["colPeso"]!.DefaultCellStyle.Format = "N2";
        }


        private void cmbIdioma_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbIdioma.SelectedIndex >= 0)
            {
                _etiquetasActuales = _gestorIdiomas.ObtenerEtiquetas(_listaIdiomas, cmbIdioma.SelectedIndex);

                _procesamiento = new Procesamiento(_calculoTarifas, _etiquetasActuales);

                AplicarIdioma();
            }
        }

        private void btnProcesar_Click(object? sender, EventArgs e)
        {
            // Comprobar que se hayan ingresado paquetes
            if (string.IsNullOrWhiteSpace(txtPaquetes.Text))
            {
                MessageBox.Show(_etiquetasActuales.MensajeSinPaquetes, this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Reiniciar el lote actual
            _totalLoteActual = 0;
            _resultadosLoteActual.Clear();

            // Procesar los paquetes
            Paquete[] paquetes = _procesamiento.ProcesarTexto(txtPaquetes.Text, out string[] errores, out int cantidadErrores, out int cantidadPaquetes);

            // Calcular las facturas de los paquetes válidos
            for (int i = 0; i < cantidadPaquetes; i++)
            {
                DesgloseFactura factura = _calculoTarifas.CalcularFactura(paquetes[i]);

                // Acumular el total del lote
                _totalLoteActual += factura.Total;

                // Crear el resultado del paquete
                ResultadoPaquete resultado = new ResultadoPaquete
                {
                    Paquete = paquetes[i],
                    Factura = factura
                };

                // Agregar al lote actual para exportación
                _resultadosLoteActual.Add(resultado);

                // Comprobar si ya existe en el historial
                bool existe = false;

                for (int j = 0; j < _resultados.Count; j++)
                {
                    if (_resultados[j].Codigo.Equals(
                        paquetes[i].Codigo,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        existe = true;
                        break;
                    }
                }

                // Agregar al historial solamente si no existe
                if (!existe)
                {
                    _resultados.Add(resultado);
                }
            }

            // Mostrar el total del lote actual
            lblTotalLote.Text = _etiquetasActuales.EtiquetaTotalLote + ": " + _totalLoteActual.ToString("C2");

            // Ordenar el historial
            _procesamiento.OrdenarResultados(_resultados);

            // Actualizar la tabla
            dgvPaquetes.DataSource = null;
            dgvPaquetes.DataSource = _resultados;

            // Mostrar los errores encontrados
            txtErrores.Text = string.Join(Environment.NewLine, errores, 0, cantidadErrores);

            // Mostrar un solo mensaje al terminar el procesamiento
            MessageBox.Show(
                _etiquetasActuales.MensajeProcesamientoCorrecto +
                "\n" + _etiquetasActuales.EtiquetaPaquetesValidos +
                ": " + cantidadPaquetes +
                "\n" + _etiquetasActuales.EtiquetaErroresEncontrados +
                ": " + cantidadErrores,
                this.Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void dgvPaquetes_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvPaquetes.CurrentRow?.DataBoundItem is not ResultadoPaquete resultado)
            {
                return;
            }

            DesgloseFactura factura = resultado.Factura;

            lblSubtotal.Text = factura.SubtotalPeso.ToString("C2");
            lblRecargo.Text = factura.RecargoZona.ToString("C2");
            lblPenalizacion.Text = factura.PenalizacionPeso.ToString("C2");
            lblSeguro.Text = factura.Seguro.ToString("C2");
            lblIVA.Text = factura.Impuesto.ToString("C2");
            lblCostoFijo.Text = factura.CostoFijo.ToString("C2");
            lblTotal.Text = factura.Total.ToString("C2");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_resultados.Count == 0)
                {
                    MessageBox.Show(
                        _etiquetasActuales.MensajeSinPaquetes,
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                int guardados = 0;
                int existentes = 0;

                foreach (ResultadoPaquete resultado in _resultados)
                {
                    bool guardado = _manejoBaseDatos.GuardarPaquete(resultado);

                    if (guardado)
                        guardados++;
                    else
                        existentes++;
                }

                MessageBox.Show(
                    _etiquetasActuales.EtiquetaPaquetesGuardados + ": " + guardados +
                    "\n" +
                    _etiquetasActuales.EtiquetaPaquetesExistentes + ": " + existentes,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_resultados.Count == 0)
                {
                    MessageBox.Show(
                        _etiquetasActuales.MensajeSinPaquetes,
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                using (SaveFileDialog dialogo = new SaveFileDialog())
                {
                    dialogo.Title = _etiquetasActuales.BotonExportar;
                    dialogo.Filter = "CSV (*.csv)|*.csv";
                    dialogo.FileName = "Facturacion.csv";
                    dialogo.DefaultExt = "csv";
                    dialogo.AddExtension = true;

                    if (dialogo.ShowDialog() == DialogResult.OK)
                    {
                        ExportacionCSV exportador = new ExportacionCSV();

                        exportador.Exportar(
                            _resultados,
                            dialogo.FileName
                        );

                        MessageBox.Show(
                            _etiquetasActuales.MensajeExportacionCorrecta,
                            this.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    _etiquetasActuales.MensajeErrorArchivo + "\n" + ex.Message,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lblSeguro_Click(object sender, EventArgs e)
        {

        }
    }
}
