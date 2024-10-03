namespace Laboratorio_11
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
            btnClickThis = new Button();
            iblHelloWord = new Label();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(635, 100);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(112, 34);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Click This";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += btnClickThis_Click;
            // 
            // iblHelloWord
            // 
            iblHelloWord.AutoSize = true;
            iblHelloWord.Location = new Point(661, 176);
            iblHelloWord.Name = "iblHelloWord";
            iblHelloWord.Size = new Size(59, 25);
            iblHelloWord.TabIndex = 1;
            iblHelloWord.Text = "label1";
            iblHelloWord.Click += iblHelloWord_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 623);
            Controls.Add(iblHelloWord);
            Controls.Add(btnClickThis);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private Label iblHelloWord;
    }
}
