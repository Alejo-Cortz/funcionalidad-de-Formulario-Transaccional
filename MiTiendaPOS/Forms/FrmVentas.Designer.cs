namespace MiTiendaPOS.Forms
{
    partial class FrmVentas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpEncabezado = new GroupBox();
            lblCliente = new Label();
            cboCliente = new ComboBox();
            lblUsuario = new Label();
            cboUsuario = new ComboBox();
            lblVenta = new Label();
            grpDetalle = new GroupBox();
            lblProducto = new Label();
            cboProducto = new ComboBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            dgvDetalle = new DataGridView();
            btnQuitar = new Button();
            lblTotal = new Label();
            grpHistorial = new GroupBox();
            dgvVentas = new DataGridView();
            btnNueva = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            grpEncabezado.SuspendLayout();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            //
            // grpEncabezado
            //
            grpEncabezado.Controls.Add(lblCliente);
            grpEncabezado.Controls.Add(cboCliente);
            grpEncabezado.Controls.Add(lblUsuario);
            grpEncabezado.Controls.Add(cboUsuario);
            grpEncabezado.Controls.Add(lblVenta);
            grpEncabezado.Location = new Point(12, 12);
            grpEncabezado.Name = "grpEncabezado";
            grpEncabezado.Size = new Size(560, 110);
            grpEncabezado.TabIndex = 0;
            grpEncabezado.TabStop = false;
            grpEncabezado.Text = "Encabezado de la venta";
            //
            // lblCliente
            //
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCliente.Location = new Point(15, 32);
            lblCliente.Name = "lblCliente";
            lblCliente.Text = "Cliente:";
            //
            // cboCliente
            //
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.Location = new Point(80, 28);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(185, 23);
            cboCliente.TabIndex = 1;
            //
            // lblUsuario
            //
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.Location = new Point(285, 32);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Text = "Usuario:";
            //
            // cboUsuario
            //
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.Location = new Point(350, 28);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(195, 23);
            cboUsuario.TabIndex = 3;
            //
            // lblVenta
            //
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVenta.Location = new Point(15, 72);
            lblVenta.Name = "lblVenta";
            lblVenta.Text = "Venta nueva";
            //
            // grpDetalle
            //
            grpDetalle.Controls.Add(lblProducto);
            grpDetalle.Controls.Add(cboProducto);
            grpDetalle.Controls.Add(lblCantidad);
            grpDetalle.Controls.Add(nudCantidad);
            grpDetalle.Controls.Add(btnAgregar);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(btnQuitar);
            grpDetalle.Controls.Add(lblTotal);
            grpDetalle.Location = new Point(12, 130);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(560, 400);
            grpDetalle.TabIndex = 1;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de productos";
            //
            // lblProducto
            //
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProducto.Location = new Point(15, 32);
            lblProducto.Name = "lblProducto";
            lblProducto.Text = "Producto:";
            //
            // cboProducto
            //
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.Location = new Point(85, 28);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(235, 23);
            cboProducto.TabIndex = 1;
            //
            // lblCantidad
            //
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCantidad.Location = new Point(332, 32);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Text = "Cant.:";
            //
            // nudCantidad
            //
            nudCantidad.Location = new Point(380, 28);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(60, 23);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // btnAgregar
            //
            btnAgregar.Location = new Point(450, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 28);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            //
            // dgvDetalle
            //
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = SystemColors.Window;
            dgvDetalle.Location = new Point(15, 68);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(530, 270);
            dgvDetalle.TabIndex = 5;
            //
            // btnQuitar
            //
            btnQuitar.Location = new Point(15, 350);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(105, 30);
            btnQuitar.TabIndex = 6;
            btnQuitar.Text = "Quitar línea";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(340, 352);
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Total: $0.00";
            //
            // grpHistorial
            //
            grpHistorial.Controls.Add(dgvVentas);
            grpHistorial.Location = new Point(590, 12);
            grpHistorial.Name = "grpHistorial";
            grpHistorial.Size = new Size(405, 573);
            grpHistorial.TabIndex = 2;
            grpHistorial.TabStop = false;
            grpHistorial.Text = "Historial de ventas";
            //
            // dgvVentas
            //
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = SystemColors.Window;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.TabIndex = 0;
            dgvVentas.CellClick += dgvVentas_CellClick;
            //
            // btnNueva
            //
            btnNueva.Location = new Point(12, 545);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(175, 40);
            btnNueva.TabIndex = 3;
            btnNueva.Text = "Nueva venta";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            //
            // btnGuardar
            //
            btnGuardar.Location = new Point(200, 545);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(190, 40);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar venta";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            //
            // btnEliminar
            //
            btnEliminar.Location = new Point(400, 545);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(172, 40);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar venta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            //
            // FrmVentas
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 621);
            Controls.Add(grpEncabezado);
            Controls.Add(grpDetalle);
            Controls.Add(grpHistorial);
            Controls.Add(btnNueva);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Ventas";
            Load += FrmVentas_Load;
            grpEncabezado.ResumeLayout(false);
            grpEncabezado.PerformLayout();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEncabezado;
        private Label lblCliente;
        private ComboBox cboCliente;
        private Label lblUsuario;
        private ComboBox cboUsuario;
        private Label lblVenta;
        private GroupBox grpDetalle;
        private Label lblProducto;
        private ComboBox cboProducto;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private DataGridView dgvDetalle;
        private Button btnQuitar;
        private Label lblTotal;
        private GroupBox grpHistorial;
        private DataGridView dgvVentas;
        private Button btnNueva;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}
