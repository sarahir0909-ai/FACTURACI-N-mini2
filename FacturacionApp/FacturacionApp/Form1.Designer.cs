namespace FacturacionApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloTabla = new Label();
            lblTotalLote = new Label();
            btnExportar = new Button();
            btnGuardar = new Button();
            grpErrores = new GroupBox();
            txtErrores = new TextBox();
            grpFactura = new GroupBox();
            lblTotal = new Label();
            lblTotalTitulo = new Label();
            lblCostoFijo = new Label();
            lblCostoFijoTitulo = new Label();
            lblIVA = new Label();
            lblIVATitulo = new Label();
            lblSeguro = new Label();
            lblSeguroTitulo = new Label();
            lblPenalizacion = new Label();
            lblPenalizacionTitulo = new Label();
            lblRecargo = new Label();
            lblRecargoTitulo = new Label();
            lblSubtotal = new Label();
            lblSubtotalTitulo = new Label();
            dgvPaquetes = new DataGridView();
            btnProcesar = new Button();
            txtPaquetes = new TextBox();
            lblEntrada = new Label();
            lblTitulo = new Label();
            cmbIdioma = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            grpErrores.SuspendLayout();
            grpFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).BeginInit();
            SuspendLayout();
            // 
            // lblTituloTabla
            // 
            lblTituloTabla.AutoSize = true;
            lblTituloTabla.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTabla.ForeColor = Color.MidnightBlue;
            lblTituloTabla.Location = new Point(17, 299);
            lblTituloTabla.Name = "lblTituloTabla";
            lblTituloTabla.Size = new Size(267, 25);
            lblTituloTabla.TabIndex = 25;
            lblTituloTabla.Text = "Resultados del procesamiento";
            // 
            // lblTotalLote
            // 
            lblTotalLote.AutoSize = true;
            lblTotalLote.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLote.ForeColor = Color.Goldenrod;
            lblTotalLote.Location = new Point(39, 578);
            lblTotalLote.Name = "lblTotalLote";
            lblTotalLote.Size = new Size(178, 25);
            lblTotalLote.TabIndex = 26;
            lblTotalLote.Text = "Total del lote: $0.00";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.Goldenrod;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(1037, 940);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(150, 35);
            btnExportar.TabIndex = 24;
            btnExportar.Text = "Exportar CSV";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MidnightBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(827, 940);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(204, 35);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar en base de datos";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // grpErrores
            // 
            grpErrores.Controls.Add(txtErrores);
            grpErrores.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpErrores.Location = new Point(39, 748);
            grpErrores.Name = "grpErrores";
            grpErrores.Size = new Size(1148, 154);
            grpErrores.TabIndex = 22;
            grpErrores.TabStop = false;
            grpErrores.Text = "Errores de procesamiento";
            // 
            // txtErrores
            // 
            txtErrores.BackColor = Color.WhiteSmoke;
            txtErrores.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtErrores.Location = new Point(15, 25);
            txtErrores.Multiline = true;
            txtErrores.Name = "txtErrores";
            txtErrores.ReadOnly = true;
            txtErrores.ScrollBars = ScrollBars.Vertical;
            txtErrores.Size = new Size(1117, 107);
            txtErrores.TabIndex = 0;
            // 
            // grpFactura
            // 
            grpFactura.Controls.Add(lblTotal);
            grpFactura.Controls.Add(lblTotalTitulo);
            grpFactura.Controls.Add(lblCostoFijo);
            grpFactura.Controls.Add(lblCostoFijoTitulo);
            grpFactura.Controls.Add(lblIVA);
            grpFactura.Controls.Add(lblIVATitulo);
            grpFactura.Controls.Add(lblSeguro);
            grpFactura.Controls.Add(lblSeguroTitulo);
            grpFactura.Controls.Add(lblPenalizacion);
            grpFactura.Controls.Add(lblPenalizacionTitulo);
            grpFactura.Controls.Add(lblRecargo);
            grpFactura.Controls.Add(lblRecargoTitulo);
            grpFactura.Controls.Add(lblSubtotal);
            grpFactura.Controls.Add(lblSubtotalTitulo);
            grpFactura.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpFactura.ForeColor = Color.Black;
            grpFactura.Location = new Point(39, 633);
            grpFactura.Name = "grpFactura";
            grpFactura.Size = new Size(1148, 109);
            grpFactura.TabIndex = 21;
            grpFactura.TabStop = false;
            grpFactura.Text = "Desglose de factura";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTotal.Location = new Point(1030, 60);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(55, 23);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "$0.00";
            // 
            // lblTotalTitulo
            // 
            lblTotalTitulo.AutoSize = true;
            lblTotalTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTotalTitulo.Location = new Point(1030, 25);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(61, 23);
            lblTotalTitulo.TabIndex = 12;
            lblTotalTitulo.Text = "TOTAL";
            // 
            // lblCostoFijo
            // 
            lblCostoFijo.AutoSize = true;
            lblCostoFijo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCostoFijo.Location = new Point(852, 58);
            lblCostoFijo.Name = "lblCostoFijo";
            lblCostoFijo.Size = new Size(55, 23);
            lblCostoFijo.TabIndex = 11;
            lblCostoFijo.Text = "$0.00";
            // 
            // lblCostoFijoTitulo
            // 
            lblCostoFijoTitulo.AutoSize = true;
            lblCostoFijoTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCostoFijoTitulo.Location = new Point(837, 25);
            lblCostoFijoTitulo.Name = "lblCostoFijoTitulo";
            lblCostoFijoTitulo.Size = new Size(87, 23);
            lblCostoFijoTitulo.TabIndex = 10;
            lblCostoFijoTitulo.Text = "Costo fijo";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblIVA.Location = new Point(680, 58);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(55, 23);
            lblIVA.TabIndex = 9;
            lblIVA.Text = "$0.00";
            // 
            // lblIVATitulo
            // 
            lblIVATitulo.AutoSize = true;
            lblIVATitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblIVATitulo.Location = new Point(680, 25);
            lblIVATitulo.Name = "lblIVATitulo";
            lblIVATitulo.Size = new Size(37, 23);
            lblIVATitulo.TabIndex = 8;
            lblIVATitulo.Text = "IVA";
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSeguro.Location = new Point(546, 58);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(55, 23);
            lblSeguro.TabIndex = 7;
            lblSeguro.Text = "$0.00";
            // 
            // lblSeguroTitulo
            // 
            lblSeguroTitulo.AutoSize = true;
            lblSeguroTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSeguroTitulo.Location = new Point(546, 25);
            lblSeguroTitulo.Name = "lblSeguroTitulo";
            lblSeguroTitulo.Size = new Size(67, 23);
            lblSeguroTitulo.TabIndex = 6;
            lblSeguroTitulo.Text = "Seguro";
            // 
            // lblPenalizacion
            // 
            lblPenalizacion.AutoSize = true;
            lblPenalizacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPenalizacion.Location = new Point(373, 60);
            lblPenalizacion.Name = "lblPenalizacion";
            lblPenalizacion.Size = new Size(55, 23);
            lblPenalizacion.TabIndex = 5;
            lblPenalizacion.Text = "$0.00";
            // 
            // lblPenalizacionTitulo
            // 
            lblPenalizacionTitulo.AutoSize = true;
            lblPenalizacionTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPenalizacionTitulo.Location = new Point(373, 25);
            lblPenalizacionTitulo.Name = "lblPenalizacionTitulo";
            lblPenalizacionTitulo.Size = new Size(107, 23);
            lblPenalizacionTitulo.TabIndex = 4;
            lblPenalizacionTitulo.Text = "Penalización";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblRecargo.Location = new Point(190, 60);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(55, 23);
            lblRecargo.TabIndex = 3;
            lblRecargo.Text = "$0.00";
            // 
            // lblRecargoTitulo
            // 
            lblRecargoTitulo.AutoSize = true;
            lblRecargoTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblRecargoTitulo.Location = new Point(190, 25);
            lblRecargoTitulo.Name = "lblRecargoTitulo";
            lblRecargoTitulo.Size = new Size(150, 23);
            lblRecargoTitulo.TabIndex = 2;
            lblRecargoTitulo.Text = "Recargo por zona";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSubtotal.Location = new Point(10, 60);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(55, 23);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "$0.00";
            // 
            // lblSubtotalTitulo
            // 
            lblSubtotalTitulo.AutoSize = true;
            lblSubtotalTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSubtotalTitulo.Location = new Point(10, 25);
            lblSubtotalTitulo.Name = "lblSubtotalTitulo";
            lblSubtotalTitulo.Size = new Size(154, 23);
            lblSubtotalTitulo.TabIndex = 0;
            lblSubtotalTitulo.Text = "Subtotal por peso";
            // 
            // dgvPaquetes
            // 
            dgvPaquetes.AllowUserToAddRows = false;
            dgvPaquetes.AllowUserToDeleteRows = false;
            dgvPaquetes.AllowUserToResizeRows = false;
            dgvPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaquetes.BackgroundColor = Color.White;
            dgvPaquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaquetes.Location = new Point(21, 334);
            dgvPaquetes.MultiSelect = false;
            dgvPaquetes.Name = "dgvPaquetes";
            dgvPaquetes.ReadOnly = true;
            dgvPaquetes.RowHeadersWidth = 51;
            dgvPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaquetes.Size = new Size(1166, 232);
            dgvPaquetes.TabIndex = 20;
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.FromArgb(47, 111, 159);
            btnProcesar.Cursor = Cursors.Hand;
            btnProcesar.FlatStyle = FlatStyle.Flat;
            btnProcesar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcesar.ForeColor = Color.White;
            btnProcesar.Location = new Point(1018, 268);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(169, 40);
            btnProcesar.TabIndex = 19;
            btnProcesar.Text = "Procesar paquetes";
            btnProcesar.UseVisualStyleBackColor = false;
            // 
            // txtPaquetes
            // 
            txtPaquetes.AcceptsReturn = true;
            txtPaquetes.AcceptsTab = true;
            txtPaquetes.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaquetes.Location = new Point(21, 102);
            txtPaquetes.Multiline = true;
            txtPaquetes.Name = "txtPaquetes";
            txtPaquetes.ScrollBars = ScrollBars.Both;
            txtPaquetes.Size = new Size(1166, 146);
            txtPaquetes.TabIndex = 18;
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrada.Location = new Point(23, -66);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(188, 25);
            lblEntrada.TabIndex = 17;
            lblEntrada.Text = "Captura de paquetes";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(23, -131);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(319, 38);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Sistema de Facturación";
            // 
            // cmbIdioma
            // 
            cmbIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.Location = new Point(856, -131);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(168, 28);
            cmbIdioma.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(21, 74);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 28;
            label1.Text = "Captura de paquetes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(23, 50, 77);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 9);
            label2.Name = "label2";
            label2.Size = new Size(319, 38);
            label2.TabIndex = 27;
            label2.Text = "Sistema de Facturación";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1220, 987);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblTituloTabla);
            Controls.Add(lblTotalLote);
            Controls.Add(btnExportar);
            Controls.Add(btnGuardar);
            Controls.Add(grpErrores);
            Controls.Add(grpFactura);
            Controls.Add(dgvPaquetes);
            Controls.Add(btnProcesar);
            Controls.Add(txtPaquetes);
            Controls.Add(lblEntrada);
            Controls.Add(lblTitulo);
            Controls.Add(cmbIdioma);
            Name = "Form1";
            Text = "Form1";
            grpErrores.ResumeLayout(false);
            grpErrores.PerformLayout();
            grpFactura.ResumeLayout(false);
            grpFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloTabla;
        private Label lblTotalLote;
        private Button btnExportar;
        private Button btnGuardar;
        private GroupBox grpErrores;
        private TextBox txtErrores;
        private GroupBox grpFactura;
        private Label lblTotal;
        private Label lblTotalTitulo;
        private Label lblCostoFijo;
        private Label lblCostoFijoTitulo;
        private Label lblIVA;
        private Label lblIVATitulo;
        private Label lblSeguro;
        private Label lblSeguroTitulo;
        private Label lblPenalizacion;
        private Label lblPenalizacionTitulo;
        private Label lblRecargo;
        private Label lblRecargoTitulo;
        private Label lblSubtotal;
        private Label lblSubtotalTitulo;
        private DataGridView dgvPaquetes;
        private Button btnProcesar;
        private TextBox txtPaquetes;
        private Label lblEntrada;
        private Label lblTitulo;
        private ComboBox cmbIdioma;
        private Label label1;
        private Label label2;
    }
}
