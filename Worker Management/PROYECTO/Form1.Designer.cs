namespace PROYECTO
{
    partial class Form1GestionPedidos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxDatosCliente = new System.Windows.Forms.GroupBox();
            this.label3Direccion = new System.Windows.Forms.Label();
            this.label2Nombre = new System.Windows.Forms.Label();
            this.label1NIF = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.label4NumeroPedido = new System.Windows.Forms.Label();
            this.label5FechaPedido = new System.Windows.Forms.Label();
            this.groupBox1DatosProducto = new System.Windows.Forms.GroupBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.nudCanti = new System.Windows.Forms.NumericUpDown();
            this.cmbNomDescrip = new System.Windows.Forms.ComboBox();
            this.label8Cantidad = new System.Windows.Forms.Label();
            this.label7Precio = new System.Windows.Forms.Label();
            this.label6NomDescrip = new System.Windows.Forms.Label();
            this.label9PedidosRecibos = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.btnAnadirProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreyDescripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Import = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Npedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIFcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2Registrar = new System.Windows.Forms.Button();
            this.textBox7ProdPed = new System.Windows.Forms.TextBox();
            this.textBox8Resumen = new System.Windows.Forms.TextBox();
            this.label9Eliminar = new System.Windows.Forms.Label();
            this.button3Guardar = new System.Windows.Forms.Button();
            this.label1Time = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.timerRelojTick = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1PrecioTotal = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.groupBoxDatosCliente.SuspendLayout();
            this.groupBox1DatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatosCliente
            // 
            this.groupBoxDatosCliente.Controls.Add(this.label3Direccion);
            this.groupBoxDatosCliente.Controls.Add(this.label2Nombre);
            this.groupBoxDatosCliente.Controls.Add(this.label1NIF);
            this.groupBoxDatosCliente.Controls.Add(this.txtDireccion);
            this.groupBoxDatosCliente.Controls.Add(this.txtNombre);
            this.groupBoxDatosCliente.Controls.Add(this.txtNIF);
            this.groupBoxDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosCliente.Location = new System.Drawing.Point(37, 34);
            this.groupBoxDatosCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDatosCliente.Name = "groupBoxDatosCliente";
            this.groupBoxDatosCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDatosCliente.Size = new System.Drawing.Size(446, 141);
            this.groupBoxDatosCliente.TabIndex = 0;
            this.groupBoxDatosCliente.TabStop = false;
            this.groupBoxDatosCliente.Text = "Datos de Cliente";
            // 
            // label3Direccion
            // 
            this.label3Direccion.AutoSize = true;
            this.label3Direccion.Location = new System.Drawing.Point(4, 98);
            this.label3Direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3Direccion.Name = "label3Direccion";
            this.label3Direccion.Size = new System.Drawing.Size(89, 20);
            this.label3Direccion.TabIndex = 5;
            this.label3Direccion.Text = "Dirección:";
            // 
            // label2Nombre
            // 
            this.label2Nombre.AutoSize = true;
            this.label2Nombre.Location = new System.Drawing.Point(191, 41);
            this.label2Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2Nombre.Name = "label2Nombre";
            this.label2Nombre.Size = new System.Drawing.Size(76, 20);
            this.label2Nombre.TabIndex = 4;
            this.label2Nombre.Text = "Nombre:";
            // 
            // label1NIF
            // 
            this.label1NIF.AutoSize = true;
            this.label1NIF.Location = new System.Drawing.Point(23, 38);
            this.label1NIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1NIF.Name = "label1NIF";
            this.label1NIF.Size = new System.Drawing.Size(43, 20);
            this.label1NIF.TabIndex = 3;
            this.label1NIF.Text = "NIF:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(106, 95);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(281, 26);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(266, 37);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(77, 39);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(92, 26);
            this.txtNIF.TabIndex = 0;
            // 
            // label4NumeroPedido
            // 
            this.label4NumeroPedido.AutoSize = true;
            this.label4NumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4NumeroPedido.Location = new System.Drawing.Point(34, 215);
            this.label4NumeroPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4NumeroPedido.Name = "label4NumeroPedido";
            this.label4NumeroPedido.Size = new System.Drawing.Size(124, 17);
            this.label4NumeroPedido.TabIndex = 1;
            this.label4NumeroPedido.Text = "Número Pedido:";
            // 
            // label5FechaPedido
            // 
            this.label5FechaPedido.AutoSize = true;
            this.label5FechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5FechaPedido.Location = new System.Drawing.Point(278, 215);
            this.label5FechaPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5FechaPedido.Name = "label5FechaPedido";
            this.label5FechaPedido.Size = new System.Drawing.Size(112, 17);
            this.label5FechaPedido.TabIndex = 2;
            this.label5FechaPedido.Text = "Fecha Pedido:";
            // 
            // groupBox1DatosProducto
            // 
            this.groupBox1DatosProducto.Controls.Add(this.txtPrecioProducto);
            this.groupBox1DatosProducto.Controls.Add(this.nudCanti);
            this.groupBox1DatosProducto.Controls.Add(this.cmbNomDescrip);
            this.groupBox1DatosProducto.Controls.Add(this.label8Cantidad);
            this.groupBox1DatosProducto.Controls.Add(this.label7Precio);
            this.groupBox1DatosProducto.Controls.Add(this.label6NomDescrip);
            this.groupBox1DatosProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1DatosProducto.Location = new System.Drawing.Point(37, 268);
            this.groupBox1DatosProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1DatosProducto.Name = "groupBox1DatosProducto";
            this.groupBox1DatosProducto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1DatosProducto.Size = new System.Drawing.Size(446, 88);
            this.groupBox1DatosProducto.TabIndex = 3;
            this.groupBox1DatosProducto.TabStop = false;
            this.groupBox1DatosProducto.Text = "Datos Producto";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioProducto.Location = new System.Drawing.Point(171, 50);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.ReadOnly = true;
            this.txtPrecioProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioProducto.Size = new System.Drawing.Size(92, 26);
            this.txtPrecioProducto.TabIndex = 7;
            // 
            // nudCanti
            // 
            this.nudCanti.Location = new System.Drawing.Point(330, 50);
            this.nudCanti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCanti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCanti.Name = "nudCanti";
            this.nudCanti.Size = new System.Drawing.Size(80, 26);
            this.nudCanti.TabIndex = 4;
            this.nudCanti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbNomDescrip
            // 
            this.cmbNomDescrip.FormattingEnabled = true;
            this.cmbNomDescrip.Items.AddRange(new object[] {
            "PS4Y2MANDOSDS4",
            "PS4Y1MANDOSDS4",
            "PS3",
            "MANDOPS4DS4",
            "MANDOPS3DS4"});
            this.cmbNomDescrip.Location = new System.Drawing.Point(23, 50);
            this.cmbNomDescrip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNomDescrip.Name = "cmbNomDescrip";
            this.cmbNomDescrip.Size = new System.Drawing.Size(118, 28);
            this.cmbNomDescrip.TabIndex = 3;
            this.cmbNomDescrip.SelectedIndexChanged += new System.EventHandler(this.comboBox1NomDescrip_SelectedIndexChanged_1);
            // 
            // label8Cantidad
            // 
            this.label8Cantidad.AutoSize = true;
            this.label8Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8Cantidad.Location = new System.Drawing.Point(328, 28);
            this.label8Cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8Cantidad.Name = "label8Cantidad";
            this.label8Cantidad.Size = new System.Drawing.Size(64, 15);
            this.label8Cantidad.TabIndex = 2;
            this.label8Cantidad.Text = "Cantidad";
            // 
            // label7Precio
            // 
            this.label7Precio.AutoSize = true;
            this.label7Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7Precio.Location = new System.Drawing.Point(193, 28);
            this.label7Precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7Precio.Name = "label7Precio";
            this.label7Precio.Size = new System.Drawing.Size(48, 15);
            this.label7Precio.TabIndex = 1;
            this.label7Precio.Text = "Precio";
            // 
            // label6NomDescrip
            // 
            this.label6NomDescrip.AutoSize = true;
            this.label6NomDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6NomDescrip.Location = new System.Drawing.Point(21, 28);
            this.label6NomDescrip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6NomDescrip.Name = "label6NomDescrip";
            this.label6NomDescrip.Size = new System.Drawing.Size(138, 15);
            this.label6NomDescrip.TabIndex = 0;
            this.label6NomDescrip.Text = "Nombre/Descripción";
            // 
            // label9PedidosRecibos
            // 
            this.label9PedidosRecibos.AutoSize = true;
            this.label9PedidosRecibos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9PedidosRecibos.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9PedidosRecibos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9PedidosRecibos.Location = new System.Drawing.Point(528, 34);
            this.label9PedidosRecibos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9PedidosRecibos.Name = "label9PedidosRecibos";
            this.label9PedidosRecibos.Size = new System.Drawing.Size(147, 21);
            this.label9PedidosRecibos.TabIndex = 4;
            this.label9PedidosRecibos.Text = "Pedidos y Recibos";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPedido.Location = new System.Drawing.Point(394, 215);
            this.dtpFechaPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(105, 20);
            this.dtpFechaPedido.TabIndex = 5;
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Enabled = false;
            this.txtNumPedido.Location = new System.Drawing.Point(154, 215);
            this.txtNumPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.ReadOnly = true;
            this.txtNumPedido.Size = new System.Drawing.Size(92, 20);
            this.txtNumPedido.TabIndex = 6;
            // 
            // btnAnadirProducto
            // 
            this.btnAnadirProducto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAnadirProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirProducto.Location = new System.Drawing.Point(343, 372);
            this.btnAnadirProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnadirProducto.Name = "btnAnadirProducto";
            this.btnAnadirProducto.Size = new System.Drawing.Size(122, 37);
            this.btnAnadirProducto.TabIndex = 7;
            this.btnAnadirProducto.Text = "Añadir Producto";
            this.btnAnadirProducto.UseVisualStyleBackColor = false;
            this.btnAnadirProducto.Click += new System.EventHandler(this.button1AnadirProducto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.NombreyDescripción,
            this.PrecioUnidad,
            this.Import});
            this.dataGridView1.Location = new System.Drawing.Point(49, 421);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 124);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellClick);
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // NombreyDescripción
            // 
            this.NombreyDescripción.HeaderText = "Nombre/Descripción";
            this.NombreyDescripción.MinimumWidth = 6;
            this.NombreyDescripción.Name = "NombreyDescripción";
            this.NombreyDescripción.ReadOnly = true;
            this.NombreyDescripción.Width = 125;
            // 
            // PrecioUnidad
            // 
            this.PrecioUnidad.HeaderText = "Precio Unitario";
            this.PrecioUnidad.MinimumWidth = 6;
            this.PrecioUnidad.Name = "PrecioUnidad";
            this.PrecioUnidad.ReadOnly = true;
            this.PrecioUnidad.Width = 125;
            // 
            // Import
            // 
            this.Import.HeaderText = "Importe";
            this.Import.MinimumWidth = 6;
            this.Import.Name = "Import";
            this.Import.ReadOnly = true;
            this.Import.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Npedido,
            this.NIFcliente,
            this.Fecha,
            this.TotalProduct,
            this.ImporteTot});
            this.dataGridView2.Location = new System.Drawing.Point(485, 421);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(518, 120);
            this.dataGridView2.TabIndex = 9;
            // 
            // Npedido
            // 
            this.Npedido.HeaderText = " N° Pedido";
            this.Npedido.MinimumWidth = 6;
            this.Npedido.Name = "Npedido";
            this.Npedido.ReadOnly = true;
            this.Npedido.Width = 125;
            // 
            // NIFcliente
            // 
            this.NIFcliente.HeaderText = "NIF_Cliente";
            this.NIFcliente.MinimumWidth = 6;
            this.NIFcliente.Name = "NIFcliente";
            this.NIFcliente.ReadOnly = true;
            this.NIFcliente.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // TotalProduct
            // 
            this.TotalProduct.HeaderText = "Total_Productos";
            this.TotalProduct.MinimumWidth = 6;
            this.TotalProduct.Name = "TotalProduct";
            this.TotalProduct.ReadOnly = true;
            this.TotalProduct.Width = 125;
            // 
            // ImporteTot
            // 
            this.ImporteTot.HeaderText = "Importe_Total";
            this.ImporteTot.MinimumWidth = 6;
            this.ImporteTot.Name = "ImporteTot";
            this.ImporteTot.ReadOnly = true;
            this.ImporteTot.Width = 125;
            // 
            // button2Registrar
            // 
            this.button2Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Registrar.Location = new System.Drawing.Point(854, 372);
            this.button2Registrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2Registrar.Name = "button2Registrar";
            this.button2Registrar.Size = new System.Drawing.Size(149, 37);
            this.button2Registrar.TabIndex = 10;
            this.button2Registrar.Text = "Registrar Pedido";
            this.button2Registrar.UseVisualStyleBackColor = false;
            this.button2Registrar.Click += new System.EventHandler(this.btnRegistrarPedido_Click);
            // 
            // textBox7ProdPed
            // 
            this.textBox7ProdPed.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox7ProdPed.Enabled = false;
            this.textBox7ProdPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7ProdPed.Location = new System.Drawing.Point(49, 385);
            this.textBox7ProdPed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7ProdPed.Name = "textBox7ProdPed";
            this.textBox7ProdPed.Size = new System.Drawing.Size(164, 26);
            this.textBox7ProdPed.TabIndex = 11;
            this.textBox7ProdPed.Text = "Productos del Pedido";
            // 
            // textBox8Resumen
            // 
            this.textBox8Resumen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox8Resumen.Enabled = false;
            this.textBox8Resumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8Resumen.Location = new System.Drawing.Point(493, 385);
            this.textBox8Resumen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox8Resumen.Name = "textBox8Resumen";
            this.textBox8Resumen.Size = new System.Drawing.Size(157, 26);
            this.textBox8Resumen.TabIndex = 12;
            this.textBox8Resumen.Text = "Resumen de Pedidos";
            // 
            // label9Eliminar
            // 
            this.label9Eliminar.AutoSize = true;
            this.label9Eliminar.Location = new System.Drawing.Point(46, 571);
            this.label9Eliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9Eliminar.Name = "label9Eliminar";
            this.label9Eliminar.Size = new System.Drawing.Size(285, 13);
            this.label9Eliminar.TabIndex = 15;
            this.label9Eliminar.Text = "Realiza doble click sobre la línea para eliminar un producto";
            // 
            // button3Guardar
            // 
            this.button3Guardar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Guardar.Location = new System.Drawing.Point(764, 554);
            this.button3Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3Guardar.Name = "button3Guardar";
            this.button3Guardar.Size = new System.Drawing.Size(239, 45);
            this.button3Guardar.TabIndex = 16;
            this.button3Guardar.Text = "Guardar Resumen de Pedidos";
            this.button3Guardar.UseVisualStyleBackColor = false;
            this.button3Guardar.Click += new System.EventHandler(this.button3Guardar_Click);
            // 
            // label1Time
            // 
            this.label1Time.AutoSize = true;
            this.label1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Time.Location = new System.Drawing.Point(770, 42);
            this.label1Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1Time.Name = "label1Time";
            this.label1Time.Size = new System.Drawing.Size(0, 24);
            this.label1Time.TabIndex = 17;
            // 
            // timerRelojTick
            // 
            this.timerRelojTick.Enabled = true;
            this.timerRelojTick.Interval = 1000;
            this.timerRelojTick.Tick += new System.EventHandler(this.timerRelojTick_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PROYECTO.Properties.Resources.Captura_de_pantalla_2024_03_25_140743;
            this.pictureBox1.Location = new System.Drawing.Point(603, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 155);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1PrecioTotal
            // 
            this.label1PrecioTotal.AutoSize = true;
            this.label1PrecioTotal.Location = new System.Drawing.Point(434, 571);
            this.label1PrecioTotal.Name = "label1PrecioTotal";
            this.label1PrecioTotal.Size = new System.Drawing.Size(0, 13);
            this.label1PrecioTotal.TabIndex = 19;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(353, 563);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(76, 24);
            this.labelPrecio.TabIndex = 20;
            this.labelPrecio.Text = "Precio:";
            // 
            // Form1GestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 619);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.label1PrecioTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1Time);
            this.Controls.Add(this.button3Guardar);
            this.Controls.Add(this.label9Eliminar);
            this.Controls.Add(this.textBox8Resumen);
            this.Controls.Add(this.textBox7ProdPed);
            this.Controls.Add(this.button2Registrar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAnadirProducto);
            this.Controls.Add(this.txtNumPedido);
            this.Controls.Add(this.dtpFechaPedido);
            this.Controls.Add(this.label9PedidosRecibos);
            this.Controls.Add(this.groupBox1DatosProducto);
            this.Controls.Add(this.label5FechaPedido);
            this.Controls.Add(this.label4NumeroPedido);
            this.Controls.Add(this.groupBoxDatosCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1GestionPedidos";
            this.Text = "Gestión de Pedidos";
            this.groupBoxDatosCliente.ResumeLayout(false);
            this.groupBoxDatosCliente.PerformLayout();
            this.groupBox1DatosProducto.ResumeLayout(false);
            this.groupBox1DatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatosCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label label1NIF;
        private System.Windows.Forms.Label label2Nombre;
        private System.Windows.Forms.Label label3Direccion;
        private System.Windows.Forms.Label label4NumeroPedido;
        private System.Windows.Forms.Label label5FechaPedido;
        private System.Windows.Forms.GroupBox groupBox1DatosProducto;
        private System.Windows.Forms.Label label6NomDescrip;
        private System.Windows.Forms.Label label7Precio;
        private System.Windows.Forms.Label label8Cantidad;
        private System.Windows.Forms.Label label9PedidosRecibos;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.ComboBox cmbNomDescrip;
        private System.Windows.Forms.NumericUpDown nudCanti;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Button btnAnadirProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreyDescripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Import;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Npedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIFcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteTot;
        private System.Windows.Forms.Button button2Registrar;
        private System.Windows.Forms.TextBox textBox7ProdPed;
        private System.Windows.Forms.TextBox textBox8Resumen;
        private System.Windows.Forms.Label label9Eliminar;
        private System.Windows.Forms.Button button3Guardar;
        private System.Windows.Forms.Label label1Time;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Timer timerRelojTick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1PrecioTotal;
        private System.Windows.Forms.Label labelPrecio;
    }
}

