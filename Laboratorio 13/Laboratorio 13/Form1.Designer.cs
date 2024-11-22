namespace Laboratorio_13
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
            btnConectar = new Button();
            TablaProducts = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 170);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(291, 73);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(213, 94);
            btnConectar.TabIndex = 1;
            btnConectar.Text = "Conectar y Desconectar de SQL";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += button1_Click;
            // 
            // TablaProducts
            // 
            TablaProducts.FormattingEnabled = true;
            TablaProducts.ItemHeight = 25;
            TablaProducts.Location = new Point(276, 198);
            TablaProducts.Name = "TablaProducts";
            TablaProducts.Size = new Size(245, 179);
            TablaProducts.TabIndex = 2;
            TablaProducts.SelectedIndexChanged += TablaProducts_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TablaProducts);
            Controls.Add(btnConectar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConectar;
        private ListBox TablaProducts;
    }
}
