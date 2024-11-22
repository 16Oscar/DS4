namespace Laboratorio_14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblId = new Label();
            lblNombre = new Label();
            btnSalir = new Button();
            lblPrecio = new Label();
            lblStock = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            txtBuscar = new Label();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbGuardar = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            tstId = new ToolStripTextBox();
            tsbBuscar = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(38, 148);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 25);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(249, 148);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(38, 374);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 46);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(38, 252);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(249, 252);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 25);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // txtId
            // 
            txtId.Location = new Point(38, 191);
            txtId.Name = "txtId";
            txtId.Size = new Size(118, 31);
            txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(249, 191);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(353, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(38, 291);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(249, 291);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 8;
            // 
            // txtBuscar
            // 
            txtBuscar.AutoSize = true;
            txtBuscar.Location = new Point(223, 9);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(120, 25);
            txtBuscar.TabIndex = 9;
            txtBuscar.Text = "Buscar por id:";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbGuardar, tsbCancelar, tsbEliminar, toolStripLabel1, tstId, tsbBuscar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1641, 33);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(34, 28);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.ImageTransparentColor = Color.Magenta;
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(34, 28);
            tsbGuardar.Text = "Guardar";
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCancelar.Image = (Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.ImageTransparentColor = Color.Magenta;
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(34, 28);
            tsbCancelar.Text = "Cancelar";
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(34, 28);
            tsbEliminar.Text = "Eliminar";
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(120, 28);
            toolStripLabel1.Text = "Buscar por id:";
            // 
            // tstId
            // 
            tstId.Name = "tstId";
            tstId.Size = new Size(100, 33);
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(34, 28);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1641, 643);
            Controls.Add(toolStrip1);
            Controls.Add(txtBuscar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(btnSalir);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "frmProductos";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNombre;
        private Button btnSalir;
        private Label lblPrecio;
        private Label lblStock;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label txtBuscar;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbGuardar;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbEliminar;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox tstId;
        private ToolStripButton tsbBuscar;
    }
}
