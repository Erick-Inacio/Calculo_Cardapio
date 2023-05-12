namespace Cálculo_Cardápio
{
    partial class frmTesteExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAttPlanilha = new System.Windows.Forms.Button();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAttPlanilha
            // 
            this.btnAttPlanilha.Location = new System.Drawing.Point(15, 15);
            this.btnAttPlanilha.Margin = new System.Windows.Forms.Padding(6);
            this.btnAttPlanilha.Name = "btnAttPlanilha";
            this.btnAttPlanilha.Size = new System.Drawing.Size(138, 42);
            this.btnAttPlanilha.TabIndex = 0;
            this.btnAttPlanilha.Text = "Puxar Dados";
            this.btnAttPlanilha.UseVisualStyleBackColor = true;
            this.btnAttPlanilha.Click += new System.EventHandler(this.btnAttPlanilha_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(15, 88);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(63, 24);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(15, 126);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(58, 24);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(84, 85);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 29);
            this.txtAltura.TabIndex = 4;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(84, 126);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 29);
            this.txtPeso.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(19, 249);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(313, 29);
            this.txtStatus.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(265, 15);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 42);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar Planilha";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmTesteExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 749);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.btnAttPlanilha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTesteExcel";
            this.Text = "frmTesteExcel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTesteExcel_FormClosing);
            this.Load += new System.EventHandler(this.frmTesteExcel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttPlanilha;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnSalvar;
    }
}