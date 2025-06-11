namespace SVPresentation.Formularios
{
    partial class frmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabEditar = new TabPage();
            cbbHabilitado = new ComboBox();
            label13 = new Label();
            label4 = new Label();
            txbCantidadEditar = new NumericUpDown();
            txbPrecioVentaEditar = new TextBox();
            txbPrecioCompraEditar = new TextBox();
            txbDescripcionEditar = new TextBox();
            txbCodigoEditar = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label10 = new Label();
            cbbCategoriaEditar = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            tabNuevo = new TabPage();
            txtCantidadNuevo = new Label();
            txbCantidadNuevo = new NumericUpDown();
            txbPrecioVentaNuevo = new TextBox();
            txbPrecioCompraNuevo = new TextBox();
            txbDescripcionNuevo = new TextBox();
            txbCodigoNuevo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnGuardaNuevo = new Button();
            btnVolverNuevo = new Button();
            cbbCategoriaNuevo = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            tabLista = new TabPage();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            txbBuscar = new TextBox();
            btnNuevoLista = new Button();
            tabControlMain = new TabControl();
            tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).BeginInit();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).BeginInit();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Inventario / Producto";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cbbHabilitado);
            tabEditar.Controls.Add(label13);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(txbCantidadEditar);
            tabEditar.Controls.Add(txbPrecioVentaEditar);
            tabEditar.Controls.Add(txbPrecioCompraEditar);
            tabEditar.Controls.Add(txbDescripcionEditar);
            tabEditar.Controls.Add(txbCodigoEditar);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(label6);
            tabEditar.Controls.Add(label10);
            tabEditar.Controls.Add(cbbCategoriaEditar);
            tabEditar.Controls.Add(label11);
            tabEditar.Controls.Add(label12);
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(732, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // cbbHabilitado
            // 
            cbbHabilitado.Cursor = Cursors.Hand;
            cbbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitado.FormattingEnabled = true;
            cbbHabilitado.Location = new Point(478, 81);
            cbbHabilitado.Name = "cbbHabilitado";
            cbbHabilitado.Size = new Size(233, 23);
            cbbHabilitado.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(478, 63);
            label13.Name = "label13";
            label13.Size = new Size(65, 15);
            label13.TabIndex = 28;
            label13.Text = "Habilitado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 7);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 27;
            label4.Text = "Cantidad:";
            // 
            // txbCantidadEditar
            // 
            txbCantidadEditar.Location = new Point(481, 25);
            txbCantidadEditar.Name = "txbCantidadEditar";
            txbCantidadEditar.Size = new Size(230, 23);
            txbCantidadEditar.TabIndex = 26;
            // 
            // txbPrecioVentaEditar
            // 
            txbPrecioVentaEditar.Location = new Point(16, 249);
            txbPrecioVentaEditar.Name = "txbPrecioVentaEditar";
            txbPrecioVentaEditar.Size = new Size(307, 23);
            txbPrecioVentaEditar.TabIndex = 25;
            // 
            // txbPrecioCompraEditar
            // 
            txbPrecioCompraEditar.Location = new Point(16, 199);
            txbPrecioCompraEditar.Name = "txbPrecioCompraEditar";
            txbPrecioCompraEditar.Size = new Size(307, 23);
            txbPrecioCompraEditar.TabIndex = 23;
            // 
            // txbDescripcionEditar
            // 
            txbDescripcionEditar.Location = new Point(16, 140);
            txbDescripcionEditar.Name = "txbDescripcionEditar";
            txbDescripcionEditar.Size = new Size(307, 23);
            txbDescripcionEditar.TabIndex = 21;
            // 
            // txbCodigoEditar
            // 
            txbCodigoEditar.Location = new Point(16, 81);
            txbCodigoEditar.Name = "txbCodigoEditar";
            txbCodigoEditar.Size = new Size(307, 23);
            txbCodigoEditar.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 234);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 24;
            label5.Text = "Precio Venta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 184);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 22;
            label6.Text = "Precio Compra:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 125);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 20;
            label10.Text = "Descripción:";
            // 
            // cbbCategoriaEditar
            // 
            cbbCategoriaEditar.Cursor = Cursors.Hand;
            cbbCategoriaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoriaEditar.FormattingEnabled = true;
            cbbCategoriaEditar.Location = new Point(15, 25);
            cbbCategoriaEditar.Name = "cbbCategoriaEditar";
            cbbCategoriaEditar.Size = new Size(307, 23);
            cbbCategoriaEditar.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 10);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 18;
            label11.Text = "Categoría:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 66);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 16;
            label12.Text = "Código:";
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.BackColor = Color.White;
            btnGuardarEditar.Cursor = Cursors.Hand;
            btnGuardarEditar.FlatStyle = FlatStyle.Flat;
            btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarEditar.Location = new Point(644, 280);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(75, 23);
            btnGuardarEditar.TabIndex = 13;
            btnGuardarEditar.Text = "Guardar";
            btnGuardarEditar.UseVisualStyleBackColor = false;
            btnGuardarEditar.Click += btnGuardarEditar_Click;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.BackColor = Color.White;
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.FlatStyle = FlatStyle.Flat;
            btnVolverEditar.Location = new Point(14, 280);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(75, 23);
            btnVolverEditar.TabIndex = 12;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = false;
            btnVolverEditar.Click += btnVolverEditar_Click;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txtCantidadNuevo);
            tabNuevo.Controls.Add(txbCantidadNuevo);
            tabNuevo.Controls.Add(txbPrecioVentaNuevo);
            tabNuevo.Controls.Add(txbPrecioCompraNuevo);
            tabNuevo.Controls.Add(txbDescripcionNuevo);
            tabNuevo.Controls.Add(txbCodigoNuevo);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(btnGuardaNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cbbCategoriaNuevo);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // txtCantidadNuevo
            // 
            txtCantidadNuevo.AutoSize = true;
            txtCantidadNuevo.Location = new Point(487, 12);
            txtCantidadNuevo.Name = "txtCantidadNuevo";
            txtCantidadNuevo.Size = new Size(58, 15);
            txtCantidadNuevo.TabIndex = 15;
            txtCantidadNuevo.Text = "Cantidad:";
            // 
            // txbCantidadNuevo
            // 
            txbCantidadNuevo.Location = new Point(487, 29);
            txbCantidadNuevo.Name = "txbCantidadNuevo";
            txbCantidadNuevo.Size = new Size(230, 23);
            txbCantidadNuevo.TabIndex = 14;
            // 
            // txbPrecioVentaNuevo
            // 
            txbPrecioVentaNuevo.Location = new Point(22, 253);
            txbPrecioVentaNuevo.Name = "txbPrecioVentaNuevo";
            txbPrecioVentaNuevo.Size = new Size(307, 23);
            txbPrecioVentaNuevo.TabIndex = 13;
            // 
            // txbPrecioCompraNuevo
            // 
            txbPrecioCompraNuevo.Location = new Point(22, 203);
            txbPrecioCompraNuevo.Name = "txbPrecioCompraNuevo";
            txbPrecioCompraNuevo.Size = new Size(307, 23);
            txbPrecioCompraNuevo.TabIndex = 11;
            // 
            // txbDescripcionNuevo
            // 
            txbDescripcionNuevo.Location = new Point(22, 144);
            txbDescripcionNuevo.Name = "txbDescripcionNuevo";
            txbDescripcionNuevo.Size = new Size(307, 23);
            txbDescripcionNuevo.TabIndex = 9;
            // 
            // txbCodigoNuevo
            // 
            txbCodigoNuevo.Location = new Point(22, 85);
            txbCodigoNuevo.Name = "txbCodigoNuevo";
            txbCodigoNuevo.Size = new Size(307, 23);
            txbCodigoNuevo.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 238);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 12;
            label9.Text = "Precio Venta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 188);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 10;
            label8.Text = "Precio Compra:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 129);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 8;
            label7.Text = "Descripción:";
            // 
            // btnGuardaNuevo
            // 
            btnGuardaNuevo.BackColor = Color.White;
            btnGuardaNuevo.Cursor = Cursors.Hand;
            btnGuardaNuevo.FlatStyle = FlatStyle.Flat;
            btnGuardaNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardaNuevo.Location = new Point(642, 281);
            btnGuardaNuevo.Name = "btnGuardaNuevo";
            btnGuardaNuevo.Size = new Size(75, 23);
            btnGuardaNuevo.TabIndex = 7;
            btnGuardaNuevo.Text = "Guardar";
            btnGuardaNuevo.UseVisualStyleBackColor = false;
            btnGuardaNuevo.Click += btnGuardaNuevo_Click;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.BackColor = Color.White;
            btnVolverNuevo.Cursor = Cursors.Hand;
            btnVolverNuevo.FlatStyle = FlatStyle.Flat;
            btnVolverNuevo.Location = new Point(21, 287);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(75, 23);
            btnVolverNuevo.TabIndex = 6;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = false;
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // cbbCategoriaNuevo
            // 
            cbbCategoriaNuevo.Cursor = Cursors.Hand;
            cbbCategoriaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoriaNuevo.FormattingEnabled = true;
            cbbCategoriaNuevo.Location = new Point(21, 29);
            cbbCategoriaNuevo.Name = "cbbCategoriaNuevo";
            cbbCategoriaNuevo.Size = new Size(307, 23);
            cbbCategoriaNuevo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 14);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Categoría:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 0;
            label2.Text = "Código:";
            // 
            // tabLista
            // 
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(dgvProductos);
            tabLista.Controls.Add(txbBuscar);
            tabLista.Controls.Add(btnNuevoLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(732, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Location = new Point(639, 11);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(19, 40);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(695, 266);
            dgvProductos.TabIndex = 8;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(453, 10);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(171, 23);
            txbBuscar.TabIndex = 6;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.BackColor = Color.White;
            btnNuevoLista.Cursor = Cursors.Hand;
            btnNuevoLista.FlatStyle = FlatStyle.Flat;
            btnNuevoLista.Location = new Point(19, 11);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(75, 23);
            btnNuevoLista.TabIndex = 5;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = false;
            btnNuevoLista.Click += btnNuevoLista_Click;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 48);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 2;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProducto";
            Load += frmProducto_Load;
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).EndInit();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabPage tabEditar;
        private ComboBox cbbHabilitado;
        private Label label13;
        private Label label4;
        private NumericUpDown txbCantidadEditar;
        private TextBox txbPrecioVentaEditar;
        private TextBox txbPrecioCompraEditar;
        private TextBox txbDescripcionEditar;
        private TextBox txbCodigoEditar;
        private Label label5;
        private Label label6;
        private Label label10;
        private ComboBox cbbCategoriaEditar;
        private Label label11;
        private Label label12;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private TabPage tabNuevo;
        private Label txtCantidadNuevo;
        private NumericUpDown txbCantidadNuevo;
        private TextBox txbPrecioVentaNuevo;
        private TextBox txbPrecioCompraNuevo;
        private TextBox txbDescripcionNuevo;
        private TextBox txbCodigoNuevo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnGuardaNuevo;
        private Button btnVolverNuevo;
        private ComboBox cbbCategoriaNuevo;
        private Label label3;
        private Label label2;
        private TabPage tabLista;
        private Button btnBuscar;
        private DataGridView dgvProductos;
        private TextBox txbBuscar;
        private Button btnNuevoLista;
        private TabControl tabControlMain;
    }
}