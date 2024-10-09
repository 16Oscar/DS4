namespace Laboratorio_12_2
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
            label3 = new Label();
            label4 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtPromedio = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 87);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 139);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Nota 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 200);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Nota 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 356);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 3;
            label4.Text = "Promedio:";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(201, 87);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(150, 31);
            txtNota1.TabIndex = 4;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(201, 139);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(150, 31);
            txtNota2.TabIndex = 5;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(201, 200);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(150, 31);
            txtNota3.TabIndex = 6;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(201, 356);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(150, 31);
            txtPromedio.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(102, 273);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(251, 273);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(403, 273);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(378, 22);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 11;
            label5.Text = "Laboratorio122";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtPromedio);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtPromedio;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label5;
    }
}
