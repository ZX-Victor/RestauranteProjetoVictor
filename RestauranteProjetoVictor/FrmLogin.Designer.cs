namespace RestauranteProjetoVictor
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblSignup = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnEsqueciMinhaSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.BackColor = System.Drawing.Color.Tan;
            this.lblSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.Location = new System.Drawing.Point(297, 280);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(161, 24);
            this.lblSignup.TabIndex = 0;
            this.lblSignup.Text = "Faça o seu Login:";
            this.lblSignup.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(319, 366);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(109, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Tan;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lblPassword.Location = new System.Drawing.Point(239, 366);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Senha:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(319, 317);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(109, 22);
            this.txtUser.TabIndex = 5;
            this.txtUser.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.BackColor = System.Drawing.Color.Tan;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lblUser1.Location = new System.Drawing.Point(239, 317);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(72, 20);
            this.lblUser1.TabIndex = 6;
            this.lblUser1.Text = "Usuário:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(449, 327);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 33);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Fazer Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCadastro.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastro.Location = new System.Drawing.Point(645, 391);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(134, 47);
            this.btnCadastro.TabIndex = 9;
            this.btnCadastro.Text = "Cadastre-se Aqui!";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(624, 363);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(178, 25);
            this.lblCadastro.TabIndex = 10;
            this.lblCadastro.Text = "Não tem Cadastro? ";
            // 
            // btnEsqueciMinhaSenha
            // 
            this.btnEsqueciMinhaSenha.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEsqueciMinhaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqueciMinhaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEsqueciMinhaSenha.ForeColor = System.Drawing.Color.Transparent;
            this.btnEsqueciMinhaSenha.Location = new System.Drawing.Point(301, 415);
            this.btnEsqueciMinhaSenha.Name = "btnEsqueciMinhaSenha";
            this.btnEsqueciMinhaSenha.Size = new System.Drawing.Size(147, 32);
            this.btnEsqueciMinhaSenha.TabIndex = 11;
            this.btnEsqueciMinhaSenha.Text = "Esqueci minha senha";
            this.btnEsqueciMinhaSenha.UseVisualStyleBackColor = false;
            this.btnEsqueciMinhaSenha.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEsqueciMinhaSenha);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblSignup);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login do Funcionario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button btnEsqueciMinhaSenha;
    }
}

