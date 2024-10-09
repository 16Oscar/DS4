namespace Laboratorio_12_3
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
            label5 = new Label();
            btnSemiperimetro = new Button();
            btnArea = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtLadoA = new TextBox();
            txtLadoB = new TextBox();
            txtLadoC = new TextBox();
            txtSemiperimetro = new TextBox();
            txtArea = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 58);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el lado A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 121);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el lado B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 178);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el lado C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 293);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 3;
            label4.Text = "Semiperimetro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 347);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 4;
            label5.Text = "Area:";
            // 
            // btnSemiperimetro
            // 
            btnSemiperimetro.Location = new Point(107, 234);
            btnSemiperimetro.Name = "btnSemiperimetro";
            btnSemiperimetro.Size = new Size(140, 34);
            btnSemiperimetro.TabIndex = 5;
            btnSemiperimetro.Text = "Semiperimetro";
            btnSemiperimetro.UseVisualStyleBackColor = true;
            btnSemiperimetro.Click += btnSemiperimetro_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(291, 234);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(112, 34);
            btnArea.TabIndex = 6;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(440, 234);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(597, 234);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(253, 58);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(150, 31);
            txtLadoA.TabIndex = 9;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(253, 121);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(150, 31);
            txtLadoB.TabIndex = 10;
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(253, 178);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(150, 31);
            txtLadoC.TabIndex = 11;
            // 
            // txtSemiperimetro
            // 
            txtSemiperimetro.Location = new Point(235, 293);
            txtSemiperimetro.Name = "txtSemiperimetro";
            txtSemiperimetro.Size = new Size(150, 31);
            txtSemiperimetro.TabIndex = 12;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(235, 347);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(150, 31);
            txtArea.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 9);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 14;
            label6.Text = "laboratorio 123";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtArea);
            Controls.Add(txtSemiperimetro);
            Controls.Add(txtLadoC);
            Controls.Add(txtLadoB);
            Controls.Add(txtLadoA);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnArea);
            Controls.Add(btnSemiperimetro);
            Controls.Add(label5);
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
        private Label label5;
        private Button btnSemiperimetro;
        private Button btnArea;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtLadoA;
        private TextBox txtLadoB;
        private TextBox txtLadoC;
        private TextBox txtSemiperimetro;
        private TextBox txtArea;
        private Label label6;
    }
}
