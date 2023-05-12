namespace Cálculo_Cardápio
{
    partial class frmNewUser
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
            this.btnNewSheet = new System.Windows.Forms.Button();
            this.txtNomeSheet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewSheet
            // 
            this.btnNewSheet.Location = new System.Drawing.Point(271, 165);
            this.btnNewSheet.Name = "btnNewSheet";
            this.btnNewSheet.Size = new System.Drawing.Size(224, 96);
            this.btnNewSheet.TabIndex = 0;
            this.btnNewSheet.Text = "NewSheet";
            this.btnNewSheet.UseVisualStyleBackColor = true;
            this.btnNewSheet.Click += new System.EventHandler(this.btnNewSheet_Click);
            // 
            // txtNomeSheet
            // 
            this.txtNomeSheet.Location = new System.Drawing.Point(271, 82);
            this.txtNomeSheet.Name = "txtNomeSheet";
            this.txtNomeSheet.Size = new System.Drawing.Size(224, 20);
            this.txtNomeSheet.TabIndex = 1;
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomeSheet);
            this.Controls.Add(this.btnNewSheet);
            this.Name = "frmNewUser";
            this.Text = "frmNewUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewUser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewSheet;
        private System.Windows.Forms.TextBox txtNomeSheet;
    }
}