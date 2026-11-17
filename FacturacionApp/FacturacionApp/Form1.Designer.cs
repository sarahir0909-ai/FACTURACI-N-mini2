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
            panel7 = new Panel();
            lblTotalTitulo = new Label();
            lblTotal = new Label();
            panel6 = new Panel();
            lblCostoFijoTitulo = new Label();
            lblCostoFijo = new Label();
            panel5 = new Panel();
            lblIVATitulo = new Label();
            lblIVA = new Label();
            panel4 = new Panel();
            lblSeguroTitulo = new Label();
            lblSeguro = new Label();
            panel3 = new Panel();
            lblPenalizacionTitulo = new Label();
            lblPenalizacion = new Label();
            panel2 = new Panel();
            lblRecargoTitulo = new Label();
            lblRecargo = new Label();
            panel1 = new Panel();
            lblSubtotalTitulo = new Label();
            lblSubtotal = new Label();
            dgvPaquetes = new DataGridView();
            btnProcesar = new Button();
            txtPaquetes = new TextBox();
            lblTitulo = new Label();
            cmbIdioma = new ComboBox();
            lblEntrada = new Label();
            label2 = new Label();
            grpErrores.SuspendLayout();
            grpFactura.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).BeginInit();
            SuspendLayout();
            // 
            // lblTituloTabla
            // 
            lblTituloTabla.AutoSize = true;
            lblTituloTabla.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloTabla.ForeColor = Color.MidnightBlue;
            lblTituloTabla.Location = new Point(17, 299);
            lblTituloTabla.Name = "lblTituloTabla";
            lblTituloTabla.Size = new Size(296, 28);
            lblTituloTabla.TabIndex = 25;
            lblTituloTabla.Text = "Resultados del procesamiento";
            // 
            // lblTotalLote
            // 
            lblTotalLote.AutoSize = true;
            lblTotalLote.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLote.ForeColor = Color.Goldenrod;
            lblTotalLote.Location = new Point(39, 557);
            lblTotalLote.Name = "lblTotalLote";
            lblTotalLote.Size = new Size(178, 25);
            lblTotalLote.TabIndex = 26;
            lblTotalLote.Text = "Total del lote: $0.00";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.Goldenrod;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = Color.Black;
            btnExportar.Location = new Point(904, 881);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(204, 35);
            btnExportar.TabIndex = 24;
            btnExportar.Text = "Exportar CSV";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(23, 50, 77);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(904, 828);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(204, 35);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar en base de datos";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // grpErrores
            // 
            grpErrores.Controls.Add(txtErrores);
            grpErrores.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            grpErrores.ForeColor = Color.FromArgb(0, 0, 64);
            grpErrores.Location = new Point(32, 803);
            grpErrores.Name = "grpErrores";
            grpErrores.Size = new Size(824, 154);
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
            txtErrores.Size = new Size(788, 107);
            txtErrores.TabIndex = 0;
            // 
            // grpFactura
            // 
            grpFactura.Controls.Add(panel7);
            grpFactura.Controls.Add(panel6);
            grpFactura.Controls.Add(panel5);
            grpFactura.Controls.Add(panel4);
            grpFactura.Controls.Add(panel3);
            grpFactura.Controls.Add(panel2);
            grpFactura.Controls.Add(panel1);
            grpFactura.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            grpFactura.ForeColor = Color.FromArgb(0, 0, 64);
            grpFactura.Location = new Point(32, 593);
            grpFactura.Name = "grpFactura";
            grpFactura.Size = new Size(1148, 204);
            grpFactura.TabIndex = 21;
            grpFactura.TabStop = false;
            grpFactura.Text = "Desglose de factura";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 244, 214);
            panel7.Controls.Add(lblTotalTitulo);
            panel7.Controls.Add(lblTotal);
            panel7.ForeColor = Color.FromArgb(214, 166, 46);
            panel7.Location = new Point(830, 147);
            panel7.Name = "panel7";
            panel7.Size = new Size(277, 47);
            panel7.TabIndex = 20;
            // 
            // lblTotalTitulo
            // 
            lblTotalTitulo.AutoSize = true;
            lblTotalTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTotalTitulo.Location = new Point(16, 11);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(61, 23);
            lblTotalTitulo.TabIndex = 12;
            lblTotalTitulo.Text = "TOTAL";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTotal.Location = new Point(107, 11);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(55, 23);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "$0.00";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(234, 242, 248);
            panel6.Controls.Add(lblCostoFijoTitulo);
            panel6.Controls.Add(lblCostoFijo);
            panel6.ForeColor = Color.FromArgb(23, 50, 77);
            panel6.Location = new Point(553, 118);
            panel6.Name = "panel6";
            panel6.Size = new Size(238, 76);
            panel6.TabIndex = 19;
            // 
            // lblCostoFijoTitulo
            // 
            lblCostoFijoTitulo.AutoSize = true;
            lblCostoFijoTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCostoFijoTitulo.Location = new Point(3, 11);
            lblCostoFijoTitulo.Name = "lblCostoFijoTitulo";
            lblCostoFijoTitulo.Size = new Size(87, 23);
            lblCostoFijoTitulo.TabIndex = 10;
            lblCostoFijoTitulo.Text = "Costo fijo";
            // 
            // lblCostoFijo
            // 
            lblCostoFijo.AutoSize = true;
            lblCostoFijo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCostoFijo.Location = new Point(3, 43);
            lblCostoFijo.Name = "lblCostoFijo";
            lblCostoFijo.Size = new Size(55, 23);
            lblCostoFijo.TabIndex = 11;
            lblCostoFijo.Text = "$0.00";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(234, 242, 248);
            panel5.Controls.Add(lblIVATitulo);
            panel5.Controls.Add(lblIVA);
            panel5.ForeColor = Color.FromArgb(23, 50, 77);
            panel5.Location = new Point(297, 121);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 73);
            panel5.TabIndex = 18;
            // 
            // lblIVATitulo
            // 
            lblIVATitulo.AutoSize = true;
            lblIVATitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblIVATitulo.Location = new Point(3, 10);
            lblIVATitulo.Name = "lblIVATitulo";
            lblIVATitulo.Size = new Size(37, 23);
            lblIVATitulo.TabIndex = 8;
            lblIVATitulo.Text = "IVA";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblIVA.Location = new Point(3, 42);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(55, 23);
            lblIVA.TabIndex = 9;
            lblIVA.Text = "$0.00";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(234, 242, 248);
            panel4.Controls.Add(lblSeguroTitulo);
            panel4.Controls.Add(lblSeguro);
            panel4.ForeColor = Color.FromArgb(23, 50, 77);
            panel4.Location = new Point(553, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 76);
            panel4.TabIndex = 17;
            // 
            // lblSeguroTitulo
            // 
            lblSeguroTitulo.AutoSize = true;
            lblSeguroTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSeguroTitulo.Location = new Point(3, 11);
            lblSeguroTitulo.Name = "lblSeguroTitulo";
            lblSeguroTitulo.Size = new Size(67, 23);
            lblSeguroTitulo.TabIndex = 6;
            lblSeguroTitulo.Text = "Seguro";
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSeguro.Location = new Point(3, 43);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(55, 23);
            lblSeguro.TabIndex = 7;
            lblSeguro.Text = "$0.00";
            lblSeguro.Click += lblSeguro_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(234, 242, 248);
            panel3.Controls.Add(lblPenalizacionTitulo);
            panel3.Controls.Add(lblPenalizacion);
            panel3.ForeColor = Color.FromArgb(23, 50, 77);
            panel3.Location = new Point(297, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 73);
            panel3.TabIndex = 16;
            // 
            // lblPenalizacionTitulo
            // 
            lblPenalizacionTitulo.AutoSize = true;
            lblPenalizacionTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPenalizacionTitulo.Location = new Point(3, 10);
            lblPenalizacionTitulo.Name = "lblPenalizacionTitulo";
            lblPenalizacionTitulo.Size = new Size(107, 23);
            lblPenalizacionTitulo.TabIndex = 4;
            lblPenalizacionTitulo.Text = "Penalización";
            // 
            // lblPenalizacion
            // 
            lblPenalizacion.AutoSize = true;
            lblPenalizacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPenalizacion.Location = new Point(3, 42);
            lblPenalizacion.Name = "lblPenalizacion";
            lblPenalizacion.Size = new Size(55, 23);
            lblPenalizacion.TabIndex = 5;
            lblPenalizacion.Text = "$0.00";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(234, 242, 248);
            panel2.Controls.Add(lblRecargoTitulo);
            panel2.Controls.Add(lblRecargo);
            panel2.ForeColor = Color.FromArgb(23, 50, 77);
            panel2.Location = new Point(22, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 76);
            panel2.TabIndex = 15;
            // 
            // lblRecargoTitulo
            // 
            lblRecargoTitulo.AutoSize = true;
            lblRecargoTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblRecargoTitulo.Location = new Point(4, 11);
            lblRecargoTitulo.Name = "lblRecargoTitulo";
            lblRecargoTitulo.Size = new Size(150, 23);
            lblRecargoTitulo.TabIndex = 2;
            lblRecargoTitulo.Text = "Recargo por zona";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblRecargo.Location = new Point(4, 43);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(55, 23);
            lblRecargo.TabIndex = 3;
            lblRecargo.Text = "$0.00";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 242, 248);
            panel1.Controls.Add(lblSubtotalTitulo);
            panel1.Controls.Add(lblSubtotal);
            panel1.ForeColor = Color.FromArgb(23, 50, 77);
            panel1.Location = new Point(22, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 73);
            panel1.TabIndex = 14;
            // 
            // lblSubtotalTitulo
            // 
            lblSubtotalTitulo.AutoSize = true;
            lblSubtotalTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSubtotalTitulo.Location = new Point(3, 10);
            lblSubtotalTitulo.Name = "lblSubtotalTitulo";
            lblSubtotalTitulo.Size = new Size(154, 23);
            lblSubtotalTitulo.TabIndex = 0;
            lblSubtotalTitulo.Text = "Subtotal por peso";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSubtotal.Location = new Point(3, 42);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(55, 23);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "$0.00";
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
            dgvPaquetes.Size = new Size(1166, 207);
            dgvPaquetes.TabIndex = 20;
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.FromArgb(23, 50, 77);
            btnProcesar.Cursor = Cursors.Hand;
            btnProcesar.FlatStyle = FlatStyle.Flat;
            btnProcesar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcesar.ForeColor = Color.White;
            btnProcesar.Location = new Point(976, 268);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(211, 44);
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
            cmbIdioma.Location = new Point(1012, 20);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(168, 28);
            cmbIdioma.TabIndex = 15;
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEntrada.ForeColor = Color.MidnightBlue;
            lblEntrada.Location = new Point(21, 74);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(207, 28);
            lblEntrada.TabIndex = 28;
            lblEntrada.Text = "Captura de paquetes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(244, 247, 250);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
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
            AutoScroll = true;
            BackColor = Color.FromArgb(244, 247, 250);
            ClientSize = new Size(1217, 976);
            Controls.Add(lblEntrada);
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
            Controls.Add(lblTitulo);
            Controls.Add(cmbIdioma);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            grpErrores.ResumeLayout(false);
            grpErrores.PerformLayout();
            grpFactura.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label lblTitulo;
        private ComboBox cmbIdioma;
        private Label lblEntrada;
        private Label label2;
        private Panel panel2;
        private Panel panel1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
    }
}
