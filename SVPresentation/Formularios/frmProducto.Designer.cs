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
            label6 = new Label();
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            cbbMedidaEditar = new ComboBox();
            label4 = new Label();
            txbNombreEditar = new TextBox();
            btnGuardaNuevo = new Button();
            btnVolverNuevo = new Button();
            cbbCategoriaNuevo = new ComboBox();
            label3 = new Label();
            cbbHabilitado = new ComboBox();
            tabEditar = new TabPage();
            label5 = new Label();
            txbCodigoNuevo = new TextBox();
            tabNuevo = new TabPage();
            label2 = new Label();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            txbBuscar = new TextBox();
            btnNuevoLista = new Button();
            tabLista = new TabPage();
            tabControlMain = new TabControl();
            txbDescripcionNuevo = new TextBox();
            label7 = new Label();
            txbPrecioCompraNuevo = new TextBox();
            label8 = new Label();
            txbPrecioVentaNuevo = new TextBox();
            label9 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtCantidadNuevo = new Label();
            tabEditar.SuspendLayout();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabLista.SuspendLayout();
            tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 140);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 14;
            label6.Text = "Habilitado:";
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Cursor = Cursors.Hand;
            btnGuardarEditar.FlatStyle = FlatStyle.Flat;
            btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarEditar.Location = new Point(644, 280);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(75, 23);
            btnGuardarEditar.TabIndex = 13;
            btnGuardarEditar.Text = "Guardar";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.FlatStyle = FlatStyle.Flat;
            btnVolverEditar.Location = new Point(14, 280);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(75, 23);
            btnVolverEditar.TabIndex = 12;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = true;
            // 
            // cbbMedidaEditar
            // 
            cbbMedidaEditar.Cursor = Cursors.Hand;
            cbbMedidaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMedidaEditar.FormattingEnabled = true;
            cbbMedidaEditar.Location = new Point(15, 93);
            cbbMedidaEditar.Name = "cbbMedidaEditar";
            cbbMedidaEditar.Size = new Size(704, 23);
            cbbMedidaEditar.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 78);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 10;
            label4.Text = "Medida:";
            // 
            // txbNombreEditar
            // 
            txbNombreEditar.Location = new Point(15, 31);
            txbNombreEditar.Name = "txbNombreEditar";
            txbNombreEditar.Size = new Size(704, 23);
            txbNombreEditar.TabIndex = 9;
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
            // cbbHabilitado
            // 
            cbbHabilitado.Cursor = Cursors.Hand;
            cbbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitado.FormattingEnabled = true;
            cbbHabilitado.Location = new Point(14, 155);
            cbbHabilitado.Name = "cbbHabilitado";
            cbbHabilitado.Size = new Size(704, 23);
            cbbHabilitado.TabIndex = 15;
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cbbHabilitado);
            tabEditar.Controls.Add(label6);
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Controls.Add(cbbMedidaEditar);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(txbNombreEditar);
            tabEditar.Controls.Add(label5);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(732, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 16);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Nombre:";
            // 
            // txbCodigoNuevo
            // 
            txbCodigoNuevo.Location = new Point(22, 85);
            txbCodigoNuevo.Name = "txbCodigoNuevo";
            txbCodigoNuevo.Size = new Size(307, 23);
            txbCodigoNuevo.TabIndex = 1;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txtCantidadNuevo);
            tabNuevo.Controls.Add(numericUpDown1);
            tabNuevo.Controls.Add(txbPrecioVentaNuevo);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(txbPrecioCompraNuevo);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(txbDescripcionNuevo);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(btnGuardaNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cbbCategoriaNuevo);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(txbCodigoNuevo);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
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
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Location = new Point(639, 11);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(19, 40);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(695, 266);
            dgvProductos.TabIndex = 8;
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
            // txbDescripcionNuevo
            // 
            txbDescripcionNuevo.Location = new Point(22, 144);
            txbDescripcionNuevo.Name = "txbDescripcionNuevo";
            txbDescripcionNuevo.Size = new Size(307, 23);
            txbDescripcionNuevo.TabIndex = 9;
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
            // txbPrecioCompraNuevo
            // 
            txbPrecioCompraNuevo.Location = new Point(22, 203);
            txbPrecioCompraNuevo.Name = "txbPrecioCompraNuevo";
            txbPrecioCompraNuevo.Size = new Size(307, 23);
            txbPrecioCompraNuevo.TabIndex = 11;
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
            // txbPrecioVentaNuevo
            // 
            txbPrecioVentaNuevo.Location = new Point(22, 253);
            txbPrecioVentaNuevo.Name = "txbPrecioVentaNuevo";
            txbPrecioVentaNuevo.Size = new Size(307, 23);
            txbPrecioVentaNuevo.TabIndex = 13;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(487, 29);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(230, 23);
            numericUpDown1.TabIndex = 14;
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
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private ComboBox cbbMedidaEditar;
        private Label label4;
        private TextBox txbNombreEditar;
        private Button btnGuardaNuevo;
        private Button btnVolverNuevo;
        private ComboBox cbbCategoriaNuevo;
        private Label label3;
        private ComboBox cbbHabilitado;
        private TabPage tabEditar;
        private Label label5;
        private TextBox txbCodigoNuevo;
        private TabPage tabNuevo;
        private TextBox txbDescripcionNuevo;
        private Label label7;
        private Label label2;
        private Button btnBuscar;
        private DataGridView dgvProductos;
        private TextBox txbBuscar;
        private Button btnNuevoLista;
        private TabPage tabLista;
        private TabControl tabControlMain;
        private TextBox txbPrecioVentaNuevo;
        private Label label9;
        private TextBox txbPrecioCompraNuevo;
        private Label label8;
        private Label txtCantidadNuevo;
        private NumericUpDown numericUpDown1;
    }
}