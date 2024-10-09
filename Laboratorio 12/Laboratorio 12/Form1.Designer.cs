namespace Laboratorio_12
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
            label1 = new Label();
            label2 = new Label();
            txtVelocidad = new TextBox();
            txtTiempo = new TextBox();
            btnCalcular = new Button();
            lblDistancia = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label3 = new Label();
            txtDistancia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 82);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Velocidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 156);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "Tiempo";
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(238, 82);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(150, 31);
            txtVelocidad.TabIndex = 2;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(238, 156);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(150, 31);
            txtTiempo.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(132, 235);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(132, 315);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(83, 25);
            lblDistancia.TabIndex = 5;
            lblDistancia.Text = "Distancia";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(276, 235);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(421, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 9);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 8;
            label3.Text = "Laboratorio121";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(238, 315);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(150, 31);
            txtDistancia.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDistancia);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(lblDistancia);
            Controls.Add(btnCalcular);
            Controls.Add(txtTiempo);
            Controls.Add(txtVelocidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVelocidad;
        private TextBox txtTiempo;
        private Button btnCalcular;
        private Label lblDistancia;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label3;
        private TextBox txtDistancia;
    }
}
