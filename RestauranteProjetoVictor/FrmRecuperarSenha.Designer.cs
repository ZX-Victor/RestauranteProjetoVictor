namespace RestauranteProjetoVictor
{
    partial class FrmRecuperarSenha
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
            this.lblNovoUsuario = new System.Windows.Forms.Label();
            this.lblRenovaçãoDaSenha = new System.Windows.Forms.Label();
            this.lblConfirmeSuaSenha = new System.Windows.Forms.Label();
            this.txtConfirmaçãoDeUsuario = new System.Windows.Forms.TextBox();
            this.txtRenovaçãoDaSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmeSuaSenha = new System.Windows.Forms.TextBox();
            this.btnRedefinirSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNovoUsuario
            // 
            this.lblNovoUsuario.AutoSize = true;
            this.lblNovoUsuario.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblNovoUsuario.Location = new System.Drawing.Point(216, 81);
            this.lblNovoUsuario.Name = "lblNovoUsuario";
            this.lblNovoUsuario.Size = new System.Drawing.Size(174, 23);
            this.lblNovoUsuario.TabIndex = 0;
            this.lblNovoUsuario.Text = "Confirme seu Usuário";
            this.lblNovoUsuario.Click += new System.EventHandler(this.lblNovoUsuario_Click);
            // 
            // lblRenovaçãoDaSenha
            // 
            this.lblRenovaçãoDaSenha.AutoSize = true;
            this.lblRenovaçãoDaSenha.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblRenovaçãoDaSenha.Location = new System.Drawing.Point(216, 193);
            this.lblRenovaçãoDaSenha.Name = "lblRenovaçãoDaSenha";
            this.lblRenovaçãoDaSenha.Size = new System.Drawing.Size(135, 23);
            this.lblRenovaçãoDaSenha.TabIndex = 1;
            this.lblRenovaçãoDaSenha.Text = "Sua Nova Senha";
            this.lblRenovaçãoDaSenha.Click += new System.EventHandler(this.lblRenovaçãoDaSenha_Click);
            // 
            // lblConfirmeSuaSenha
            // 
            this.lblConfirmeSuaSenha.AutoSize = true;
            this.lblConfirmeSuaSenha.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblConfirmeSuaSenha.Location = new System.Drawing.Point(216, 310);
            this.lblConfirmeSuaSenha.Name = "lblConfirmeSuaSenha";
            this.lblConfirmeSuaSenha.Size = new System.Drawing.Size(165, 23);
            this.lblConfirmeSuaSenha.TabIndex = 2;
            this.lblConfirmeSuaSenha.Text = "Confirme Sua Senha";
            // 
            // txtConfirmaçãoDeUsuario
            // 
            this.txtConfirmaçãoDeUsuario.Location = new System.Drawing.Point(220, 107);
            this.txtConfirmaçãoDeUsuario.Name = "txtConfirmaçãoDeUsuario";
            this.txtConfirmaçãoDeUsuario.Size = new System.Drawing.Size(131, 22);
            this.txtConfirmaçãoDeUsuario.TabIndex = 3;
            // 
            // txtRenovaçãoDaSenha
            // 
            this.txtRenovaçãoDaSenha.Location = new System.Drawing.Point(220, 219);
            this.txtRenovaçãoDaSenha.Name = "txtRenovaçãoDaSenha";
            this.txtRenovaçãoDaSenha.PasswordChar = '*';
            this.txtRenovaçãoDaSenha.Size = new System.Drawing.Size(131, 22);
            this.txtRenovaçãoDaSenha.TabIndex = 4;
            // 
            // txtConfirmeSuaSenha
            // 
            this.txtConfirmeSuaSenha.Location = new System.Drawing.Point(220, 336);
            this.txtConfirmeSuaSenha.Name = "txtConfirmeSuaSenha";
            this.txtConfirmeSuaSenha.PasswordChar = '*';
            this.txtConfirmeSuaSenha.Size = new System.Drawing.Size(131, 22);
            this.txtConfirmeSuaSenha.TabIndex = 5;
            // 
            // btnRedefinirSenha
            // 
            this.btnRedefinirSenha.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRedefinirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedefinirSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRedefinirSenha.ForeColor = System.Drawing.Color.Transparent;
            this.btnRedefinirSenha.Location = new System.Drawing.Point(488, 211);
            this.btnRedefinirSenha.Name = "btnRedefinirSenha";
            this.btnRedefinirSenha.Size = new System.Drawing.Size(123, 44);
            this.btnRedefinirSenha.TabIndex = 6;
            this.btnRedefinirSenha.Text = "Redefinir Sua Senha";
            this.btnRedefinirSenha.UseVisualStyleBackColor = false;
            this.btnRedefinirSenha.Click += new System.EventHandler(this.btnRedefinirSenha_Click);
            // 
            // FrmRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRedefinirSenha);
            this.Controls.Add(this.txtConfirmeSuaSenha);
            this.Controls.Add(this.txtRenovaçãoDaSenha);
            this.Controls.Add(this.txtConfirmaçãoDeUsuario);
            this.Controls.Add(this.lblConfirmeSuaSenha);
            this.Controls.Add(this.lblRenovaçãoDaSenha);
            this.Controls.Add(this.lblNovoUsuario);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmRecuperarSenha";
            this.Text = "FrmRecuperarSenha";
            this.Load += new System.EventHandler(this.FrmRecuperarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNovoUsuario;
        private System.Windows.Forms.Label lblRenovaçãoDaSenha;
        private System.Windows.Forms.Label lblConfirmeSuaSenha;
        private System.Windows.Forms.TextBox txtConfirmaçãoDeUsuario;
        private System.Windows.Forms.TextBox txtRenovaçãoDaSenha;
        private System.Windows.Forms.TextBox txtConfirmeSuaSenha;
        private System.Windows.Forms.Button btnRedefinirSenha;
    }
}