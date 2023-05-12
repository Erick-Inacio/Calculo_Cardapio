namespace Cálculo_Cardápio
{
    partial class frmEER
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
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtEer = new System.Windows.Forms.TextBox();
            this.lblEer = new System.Windows.Forms.Label();
            this.lblGrauAtv = new System.Windows.Forms.Label();
            this.gbxAtividade = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMuitoAtivoD = new System.Windows.Forms.Label();
            this.lblMuitoAtivo = new System.Windows.Forms.Label();
            this.lblAtivoD = new System.Windows.Forms.Label();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblPoucoAtivoD = new System.Windows.Forms.Label();
            this.lblPoucoAtivo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbxGrauAtv = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.txtEerReduzido = new System.Windows.Forms.TextBox();
            this.lblErrReduzido = new System.Windows.Forms.Label();
            this.btnPuxar = new System.Windows.Forms.Button();
            this.gbxAtividade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(24, 21);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(67, 24);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = "Idade: ";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(117, 21);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(154, 29);
            this.txtIdade.TabIndex = 1;
            // 
            // txtEer
            // 
            this.txtEer.Enabled = false;
            this.txtEer.Location = new System.Drawing.Point(117, 165);
            this.txtEer.Name = "txtEer";
            this.txtEer.Size = new System.Drawing.Size(154, 29);
            this.txtEer.TabIndex = 3;
            this.txtEer.TextChanged += new System.EventHandler(this.txtEer_TextChanged);
            // 
            // lblEer
            // 
            this.lblEer.AutoSize = true;
            this.lblEer.Location = new System.Drawing.Point(24, 165);
            this.lblEer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEer.Name = "lblEer";
            this.lblEer.Size = new System.Drawing.Size(54, 24);
            this.lblEer.TabIndex = 2;
            this.lblEer.Text = "EER:";
            // 
            // lblGrauAtv
            // 
            this.lblGrauAtv.AutoSize = true;
            this.lblGrauAtv.Location = new System.Drawing.Point(24, 117);
            this.lblGrauAtv.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGrauAtv.Name = "lblGrauAtv";
            this.lblGrauAtv.Size = new System.Drawing.Size(87, 24);
            this.lblGrauAtv.TabIndex = 4;
            this.lblGrauAtv.Text = "Grau Atv:";
            // 
            // gbxAtividade
            // 
            this.gbxAtividade.Controls.Add(this.label8);
            this.gbxAtividade.Controls.Add(this.label9);
            this.gbxAtividade.Controls.Add(this.lblMuitoAtivoD);
            this.gbxAtividade.Controls.Add(this.lblMuitoAtivo);
            this.gbxAtividade.Controls.Add(this.lblAtivoD);
            this.gbxAtividade.Controls.Add(this.lblAtivo);
            this.gbxAtividade.Controls.Add(this.lblPoucoAtivoD);
            this.gbxAtividade.Controls.Add(this.lblPoucoAtivo);
            this.gbxAtividade.Location = new System.Drawing.Point(28, 249);
            this.gbxAtividade.Name = "gbxAtividade";
            this.gbxAtividade.Size = new System.Drawing.Size(567, 182);
            this.gbxAtividade.TabIndex = 5;
            this.gbxAtividade.TabStop = false;
            this.gbxAtividade.Text = "Grau de Atividade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tarefas Doméstica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sedentário:";
            // 
            // lblMuitoAtivoD
            // 
            this.lblMuitoAtivoD.AutoSize = true;
            this.lblMuitoAtivoD.Location = new System.Drawing.Point(138, 142);
            this.lblMuitoAtivoD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMuitoAtivoD.Name = "lblMuitoAtivoD";
            this.lblMuitoAtivoD.Size = new System.Drawing.Size(416, 24);
            this.lblMuitoAtivoD.TabIndex = 10;
            this.lblMuitoAtivoD.Text = "Atv Típica + ou 60\" atv vigorosa ou 120\" atv mod.";
            // 
            // lblMuitoAtivo
            // 
            this.lblMuitoAtivo.AutoSize = true;
            this.lblMuitoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuitoAtivo.Location = new System.Drawing.Point(9, 142);
            this.lblMuitoAtivo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMuitoAtivo.Name = "lblMuitoAtivo";
            this.lblMuitoAtivo.Size = new System.Drawing.Size(119, 24);
            this.lblMuitoAtivo.TabIndex = 9;
            this.lblMuitoAtivo.Text = "Muito Ativo:";
            // 
            // lblAtivoD
            // 
            this.lblAtivoD.AutoSize = true;
            this.lblAtivoD.Location = new System.Drawing.Point(138, 106);
            this.lblAtivoD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAtivoD.Name = "lblAtivoD";
            this.lblAtivoD.Size = new System.Drawing.Size(310, 24);
            this.lblAtivoD.TabIndex = 8;
            this.lblAtivoD.Text = "Atv Típica + no mínimo 60\" atv mod.";
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtivo.Location = new System.Drawing.Point(9, 106);
            this.lblAtivo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(62, 24);
            this.lblAtivo.TabIndex = 7;
            this.lblAtivo.Text = "Ativo:";
            // 
            // lblPoucoAtivoD
            // 
            this.lblPoucoAtivoD.AutoSize = true;
            this.lblPoucoAtivoD.Location = new System.Drawing.Point(138, 70);
            this.lblPoucoAtivoD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPoucoAtivoD.Name = "lblPoucoAtivoD";
            this.lblPoucoAtivoD.Size = new System.Drawing.Size(419, 24);
            this.lblPoucoAtivoD.TabIndex = 6;
            this.lblPoucoAtivoD.Text = "30 - 60\" atv mod. (ex: caminhadas entre 5-7km/h)";
            // 
            // lblPoucoAtivo
            // 
            this.lblPoucoAtivo.AutoSize = true;
            this.lblPoucoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoucoAtivo.Location = new System.Drawing.Point(9, 70);
            this.lblPoucoAtivo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPoucoAtivo.Name = "lblPoucoAtivo";
            this.lblPoucoAtivo.Size = new System.Drawing.Size(128, 24);
            this.lblPoucoAtivo.TabIndex = 5;
            this.lblPoucoAtivo.Text = "Pouco Ativo:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(313, 21);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 113);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbxGrauAtv
            // 
            this.cbxGrauAtv.FormattingEnabled = true;
            this.cbxGrauAtv.Location = new System.Drawing.Point(117, 116);
            this.cbxGrauAtv.Name = "cbxGrauAtv";
            this.cbxGrauAtv.Size = new System.Drawing.Size(154, 32);
            this.cbxGrauAtv.TabIndex = 8;
            this.cbxGrauAtv.SelectedIndexChanged += new System.EventHandler(this.cbxGrauAtv_SelectedIndexChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(24, 69);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(64, 24);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo: ";
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Location = new System.Drawing.Point(117, 67);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(154, 32);
            this.cbxSexo.TabIndex = 10;
            this.cbxSexo.UseWaitCursor = true;
            // 
            // txtEerReduzido
            // 
            this.txtEerReduzido.Enabled = false;
            this.txtEerReduzido.Location = new System.Drawing.Point(170, 211);
            this.txtEerReduzido.Name = "txtEerReduzido";
            this.txtEerReduzido.Size = new System.Drawing.Size(154, 29);
            this.txtEerReduzido.TabIndex = 12;
            // 
            // lblErrReduzido
            // 
            this.lblErrReduzido.AutoSize = true;
            this.lblErrReduzido.Location = new System.Drawing.Point(24, 214);
            this.lblErrReduzido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblErrReduzido.Name = "lblErrReduzido";
            this.lblErrReduzido.Size = new System.Drawing.Size(140, 24);
            this.lblErrReduzido.TabIndex = 11;
            this.lblErrReduzido.Text = "EER Reduzido:";
            // 
            // btnPuxar
            // 
            this.btnPuxar.Location = new System.Drawing.Point(313, 151);
            this.btnPuxar.Name = "btnPuxar";
            this.btnPuxar.Size = new System.Drawing.Size(139, 53);
            this.btnPuxar.TabIndex = 33;
            this.btnPuxar.Text = "Puxar";
            this.btnPuxar.UseVisualStyleBackColor = true;
            this.btnPuxar.Click += new System.EventHandler(this.btnPuxar_Click);
            // 
            // frmEER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnPuxar);
            this.Controls.Add(this.txtEerReduzido);
            this.Controls.Add(this.lblErrReduzido);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cbxGrauAtv);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbxAtividade);
            this.Controls.Add(this.lblGrauAtv);
            this.Controls.Add(this.txtEer);
            this.Controls.Add(this.lblEer);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEER";
            this.Text = "EER";
            this.Load += new System.EventHandler(this.frmEER_Load);
            this.gbxAtividade.ResumeLayout(false);
            this.gbxAtividade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtEer;
        private System.Windows.Forms.Label lblEer;
        private System.Windows.Forms.Label lblGrauAtv;
        private System.Windows.Forms.GroupBox gbxAtividade;
        private System.Windows.Forms.Label lblPoucoAtivoD;
        private System.Windows.Forms.Label lblPoucoAtivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMuitoAtivoD;
        private System.Windows.Forms.Label lblMuitoAtivo;
        private System.Windows.Forms.Label lblAtivoD;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbxGrauAtv;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.TextBox txtEerReduzido;
        private System.Windows.Forms.Label lblErrReduzido;
        private System.Windows.Forms.Button btnPuxar;
    }
}