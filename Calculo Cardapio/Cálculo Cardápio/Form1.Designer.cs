namespace Cálculo_Cardápio
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kcalPorRefeiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iMCToolStripMenuItem,
            this.eERToolStripMenuItem,
            this.balanceamentoToolStripMenuItem,
            this.kcalPorRefeiçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iMCToolStripMenuItem
            // 
            this.iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
            this.iMCToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.iMCToolStripMenuItem.Text = "IMC";
            this.iMCToolStripMenuItem.Click += new System.EventHandler(this.iMCToolStripMenuItem_Click);
            // 
            // eERToolStripMenuItem
            // 
            this.eERToolStripMenuItem.Name = "eERToolStripMenuItem";
            this.eERToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.eERToolStripMenuItem.Text = "EER";
            this.eERToolStripMenuItem.Click += new System.EventHandler(this.eERToolStripMenuItem_Click);
            // 
            // balanceamentoToolStripMenuItem
            // 
            this.balanceamentoToolStripMenuItem.Name = "balanceamentoToolStripMenuItem";
            this.balanceamentoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.balanceamentoToolStripMenuItem.Text = "Balanceamento";
            this.balanceamentoToolStripMenuItem.Click += new System.EventHandler(this.balanceamentoToolStripMenuItem_Click);
            // 
            // kcalPorRefeiçãoToolStripMenuItem
            // 
            this.kcalPorRefeiçãoToolStripMenuItem.Name = "kcalPorRefeiçãoToolStripMenuItem";
            this.kcalPorRefeiçãoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.kcalPorRefeiçãoToolStripMenuItem.Text = "Kcal por Refeição";
            this.kcalPorRefeiçãoToolStripMenuItem.Click += new System.EventHandler(this.kcalPorRefeiçãoToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kcalPorRefeiçãoToolStripMenuItem;
    }
}

