namespace Cálculo_Cardápio
{
    partial class frmLogin
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCriarAcc = new System.Windows.Forms.Button();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnPuxar = new System.Windows.Forms.Button();
            this.gpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(11, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 24);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Usuário:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(92, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 29);
            this.txtUsername.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(92, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 29);
            this.textBox2.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(11, 75);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 24);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(260, 258);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 47);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCriarAcc
            // 
            this.btnCriarAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarAcc.Location = new System.Drawing.Point(399, 258);
            this.btnCriarAcc.Name = "btnCriarAcc";
            this.btnCriarAcc.Size = new System.Drawing.Size(129, 47);
            this.btnCriarAcc.TabIndex = 5;
            this.btnCriarAcc.Text = "Criar conta";
            this.btnCriarAcc.UseVisualStyleBackColor = true;
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.textBox2);
            this.gpbLogin.Controls.Add(this.lblSenha);
            this.gpbLogin.Controls.Add(this.txtUsername);
            this.gpbLogin.Controls.Add(this.lblUsername);
            this.gpbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLogin.Location = new System.Drawing.Point(249, 135);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(293, 182);
            this.gpbLogin.TabIndex = 6;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Login";
            this.gpbLogin.Enter += new System.EventHandler(this.gpbLogin_Enter);
            // 
            // btnPuxar
            // 
            this.btnPuxar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuxar.Location = new System.Drawing.Point(659, 391);
            this.btnPuxar.Name = "btnPuxar";
            this.btnPuxar.Size = new System.Drawing.Size(129, 47);
            this.btnPuxar.TabIndex = 7;
            this.btnPuxar.Text = "Puxar";
            this.btnPuxar.UseVisualStyleBackColor = true;
            this.btnPuxar.Click += new System.EventHandler(this.btnPuxar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPuxar);
            this.Controls.Add(this.btnCriarAcc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gpbLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCriarAcc;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.Button btnPuxar;
    }
}