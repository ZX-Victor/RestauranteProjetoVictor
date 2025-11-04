namespace RestauranteProjetoVictor
{
    partial class FrmFinalizarPedido
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
            this.cmbPedidos = new System.Windows.Forms.ComboBox();
            this.lblResumo = new System.Windows.Forms.Label();
            this.btnPedidoFinalizado = new System.Windows.Forms.Button();
            this.grpResumo = new System.Windows.Forms.GroupBox();
            this.rdbPix = new System.Windows.Forms.RadioButton();
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.cmbBandeira = new System.Windows.Forms.ComboBox();
            this.grpResumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPedidos
            // 
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Location = new System.Drawing.Point(357, 18);
            this.cmbPedidos.Name = "cmbPedidos";
            this.cmbPedidos.Size = new System.Drawing.Size(121, 21);
            this.cmbPedidos.TabIndex = 0;
            this.cmbPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbPedidos_SelectedIndexChanged);
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.Location = new System.Drawing.Point(16, 12);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(146, 25);
            this.lblResumo.TabIndex = 1;
            this.lblResumo.Text = "Finalizar Pedido";
            // 
            // btnPedidoFinalizado
            // 
            this.btnPedidoFinalizado.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPedidoFinalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidoFinalizado.ForeColor = System.Drawing.Color.Transparent;
            this.btnPedidoFinalizado.Location = new System.Drawing.Point(325, 406);
            this.btnPedidoFinalizado.Name = "btnPedidoFinalizado";
            this.btnPedidoFinalizado.Size = new System.Drawing.Size(153, 32);
            this.btnPedidoFinalizado.TabIndex = 2;
            this.btnPedidoFinalizado.Text = "Confirmar Pagamento";
            this.btnPedidoFinalizado.UseVisualStyleBackColor = false;
            this.btnPedidoFinalizado.Click += new System.EventHandler(this.btnPedidoFinalizado_Click);
            // 
            // grpResumo
            // 
            this.grpResumo.Controls.Add(this.cmbBandeira);
            this.grpResumo.Controls.Add(this.rdbPix);
            this.grpResumo.Controls.Add(this.rdbDebito);
            this.grpResumo.Controls.Add(this.rdbCredito);
            this.grpResumo.Controls.Add(this.rdbDinheiro);
            this.grpResumo.Location = new System.Drawing.Point(21, 56);
            this.grpResumo.Name = "grpResumo";
            this.grpResumo.Size = new System.Drawing.Size(457, 295);
            this.grpResumo.TabIndex = 3;
            this.grpResumo.TabStop = false;
            this.grpResumo.Text = "Resumo do Pedido";
            // 
            // rdbPix
            // 
            this.rdbPix.AutoSize = true;
            this.rdbPix.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdbPix.Location = new System.Drawing.Point(21, 94);
            this.rdbPix.Name = "rdbPix";
            this.rdbPix.Size = new System.Drawing.Size(47, 23);
            this.rdbPix.TabIndex = 6;
            this.rdbPix.TabStop = true;
            this.rdbPix.Text = "PIX";
            this.rdbPix.UseVisualStyleBackColor = true;
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdbDinheiro.Location = new System.Drawing.Point(17, 36);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(79, 23);
            this.rdbDinheiro.TabIndex = 4;
            this.rdbDinheiro.TabStop = true;
            this.rdbDinheiro.Text = "Dinheiro";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestauranteProjetoVictor.Properties.Resources.Lanchonete_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(514, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPedidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVerPedidos.ForeColor = System.Drawing.Color.Transparent;
            this.btnVerPedidos.Location = new System.Drawing.Point(21, 406);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(141, 32);
            this.btnVerPedidos.TabIndex = 5;
            this.btnVerPedidos.Text = "Ver Pedidos";
            this.btnVerPedidos.UseVisualStyleBackColor = false;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdbDebito.Location = new System.Drawing.Point(21, 210);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(68, 23);
            this.rdbDebito.TabIndex = 8;
            this.rdbDebito.Text = "Débito";
            this.rdbDebito.UseVisualStyleBackColor = true;
            this.rdbDebito.CheckedChanged += new System.EventHandler(this.rdbDebito_CheckedChanged);
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdbCredito.Location = new System.Drawing.Point(17, 152);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(72, 23);
            this.rdbCredito.TabIndex = 7;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            this.rdbCredito.CheckedChanged += new System.EventHandler(this.rdbCredito_CheckedChanged);
            // 
            // cmbBandeira
            // 
            this.cmbBandeira.FormattingEnabled = true;
            this.cmbBandeira.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "Elo",
            "HiperCard",
            "American Express"});
            this.cmbBandeira.Location = new System.Drawing.Point(116, 179);
            this.cmbBandeira.Name = "cmbBandeira";
            this.cmbBandeira.Size = new System.Drawing.Size(121, 21);
            this.cmbBandeira.TabIndex = 10;
            // 
            // FrmFinalizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerPedidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPedidoFinalizado);
            this.Controls.Add(this.grpResumo);
            this.Controls.Add(this.cmbPedidos);
            this.Controls.Add(this.lblResumo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmFinalizarPedido";
            this.Text = "FrmFinalizarPedido";
            this.Load += new System.EventHandler(this.FrmFinalizarPedido_Load);
            this.grpResumo.ResumeLayout(false);
            this.grpResumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPedidos;
        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.Button btnPedidoFinalizado;
        private System.Windows.Forms.GroupBox grpResumo;
        private System.Windows.Forms.RadioButton rdbDinheiro;
        private System.Windows.Forms.RadioButton rdbPix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVerPedidos;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.ComboBox cmbBandeira;
    }
}