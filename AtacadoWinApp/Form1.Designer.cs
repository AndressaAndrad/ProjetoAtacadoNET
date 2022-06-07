namespace AtacadoWinApp
{
    partial class form1
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
            this.OiMundoBtn = new System.Windows.Forms.Button();
            this.FecharBtn = new System.Windows.Forms.Button();
            this.CpfLbl = new System.Windows.Forms.Label();
            this.CpfTxt = new System.Windows.Forms.TextBox();
            this.ValidarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OiMundoBtn
            // 
            this.OiMundoBtn.Location = new System.Drawing.Point(12, 12);
            this.OiMundoBtn.Name = "OiMundoBtn";
            this.OiMundoBtn.Size = new System.Drawing.Size(103, 24);
            this.OiMundoBtn.TabIndex = 0;
            this.OiMundoBtn.Text = "Clique Aqui!!!";
            this.OiMundoBtn.UseVisualStyleBackColor = true;
            this.OiMundoBtn.Click += new System.EventHandler(this.OiMundoBtn_Click);
            // 
            // FecharBtn
            // 
            this.FecharBtn.Location = new System.Drawing.Point(766, 469);
            this.FecharBtn.Name = "FecharBtn";
            this.FecharBtn.Size = new System.Drawing.Size(75, 23);
            this.FecharBtn.TabIndex = 1;
            this.FecharBtn.Text = "Fechar";
            this.FecharBtn.UseVisualStyleBackColor = true;
            this.FecharBtn.Click += new System.EventHandler(this.FecharBtn_Click);
            // 
            // CpfLbl
            // 
            this.CpfLbl.AutoSize = true;
            this.CpfLbl.Location = new System.Drawing.Point(21, 112);
            this.CpfLbl.Name = "CpfLbl";
            this.CpfLbl.Size = new System.Drawing.Size(94, 15);
            this.CpfLbl.TabIndex = 2;
            this.CpfLbl.Text = "CPF Funcionário";
            // 
            // CpfTxt
            // 
            this.CpfTxt.Location = new System.Drawing.Point(121, 109);
            this.CpfTxt.Name = "CpfTxt";
            this.CpfTxt.Size = new System.Drawing.Size(150, 23);
            this.CpfTxt.TabIndex = 3;
            
            // 
            // ValidarBtn
            // 
            this.ValidarBtn.Location = new System.Drawing.Point(196, 138);
            this.ValidarBtn.Name = "ValidarBtn";
            this.ValidarBtn.Size = new System.Drawing.Size(75, 23);
            this.ValidarBtn.TabIndex = 4;
            this.ValidarBtn.Text = "Validar";
            this.ValidarBtn.UseVisualStyleBackColor = true;
            this.ValidarBtn.Click += new System.EventHandler(this.ValidarBtn_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 504);
            this.Controls.Add(this.ValidarBtn);
            this.Controls.Add(this.CpfTxt);
            this.Controls.Add(this.CpfLbl);
            this.Controls.Add(this.FecharBtn);
            this.Controls.Add(this.OiMundoBtn);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OiMundoBtn;
        private Button FecharBtn;
        private Label CpfLbl;
        private TextBox CpfTxt;
        private Button ValidarBtn;
    }
}