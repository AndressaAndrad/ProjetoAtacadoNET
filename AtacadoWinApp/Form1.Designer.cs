namespace AtacadoWinApp
{
    partial class PrincipalFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArquivoMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FuncionariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdicionarFuncionarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OiMundoBtn
            // 
            this.OiMundoBtn.Location = new System.Drawing.Point(21, 468);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArquivoMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArquivoMenuItem1
            // 
            this.ArquivoMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FuncionariosMenuItem,
            this.empresasToolStripMenuItem});
            this.ArquivoMenuItem1.Name = "ArquivoMenuItem1";
            this.ArquivoMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.ArquivoMenuItem1.Text = "Arquivo";
            // 
            // FuncionariosMenuItem
            // 
            this.FuncionariosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdicionarFuncionarioMenuItem});
            this.FuncionariosMenuItem.Name = "FuncionariosMenuItem";
            this.FuncionariosMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FuncionariosMenuItem.Text = "Funcionários";
            // 
            // AdicionarFuncionarioMenuItem
            // 
            this.AdicionarFuncionarioMenuItem.Name = "AdicionarFuncionarioMenuItem";
            this.AdicionarFuncionarioMenuItem.Size = new System.Drawing.Size(125, 22);
            this.AdicionarFuncionarioMenuItem.Text = "Adicionar";
            this.AdicionarFuncionarioMenuItem.Click += new System.EventHandler(this.AdicionarFuncionarioMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem});
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 504);
            this.Controls.Add(this.FecharBtn);
            this.Controls.Add(this.OiMundoBtn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PrincipalFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OiMundoBtn;
        private Button FecharBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ArquivoMenuItem1;
        private ToolStripMenuItem FuncionariosMenuItem;
        private ToolStripMenuItem AdicionarFuncionarioMenuItem;
        private ToolStripMenuItem empresasToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
    }
}