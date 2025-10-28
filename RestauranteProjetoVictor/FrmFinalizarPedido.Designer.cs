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
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.rdbCartao = new System.Windows.Forms.RadioButton();
            this.rdbPix = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpResumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPedidos
            // 
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Location = new System.Drawing.Point(387, 56);
            this.cmbPedidos.Name = "cmbPedidos";
            this.cmbPedidos.Size = new System.Drawing.Size(121, 21);
            this.cmbPedidos.TabIndex = 0;
            this.cmbPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbPedidos_SelectedIndexChanged);
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.Location = new System.Drawing.Point(90, 50);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(146, 25);
            this.lblResumo.TabIndex = 1;
            this.lblResumo.Text = "Finalizar Pedido";
            // 
            // btnPedidoFinalizado
            // 
            this.btnPedidoFinalizado.Location = new System.Drawing.Point(254, 267);
            this.btnPedidoFinalizado.Name = "btnPedidoFinalizado";
            this.btnPedidoFinalizado.Size = new System.Drawing.Size(153, 46);
            this.btnPedidoFinalizado.TabIndex = 2;
            this.btnPedidoFinalizado.Text = "Confirmar Pagamento";
            this.btnPedidoFinalizado.UseVisualStyleBackColor = true;
            this.btnPedidoFinalizado.Click += new System.EventHandler(this.btnPedidoFinalizado_Click);
            // 
            // grpResumo
            // 
            this.grpResumo.Controls.Add(this.rdbPix);
            this.grpResumo.Controls.Add(this.rdbCartao);
            this.grpResumo.Controls.Add(this.rdbDinheiro);
            this.grpResumo.Controls.Add(this.btnPedidoFinalizado);
            this.grpResumo.Location = new System.Drawing.Point(95, 78);
            this.grpResumo.Name = "grpResumo";
            this.grpResumo.Size = new System.Drawing.Size(413, 319);
            this.grpResumo.TabIndex = 3;
            this.grpResumo.TabStop = false;
            this.grpResumo.Text = "Resumo do Pedido";
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdbDinheiro.Location = new System.Drawing.Point(20, 112);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(79, 23);
            this.rdbDinheiro.TabIndex = 4;
            this.rdbDinheiro.TabStop = true;
            this.rdbDinheiro.Text = "Dinheiro";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rdbCartao
            // 
            this.rdbCartao.AutoSize = true;
            this.rdbCartao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdbCartao.Location = new System.Drawing.Point(20, 167);
            this.rdbCartao.Name = "rdbCartao";
            this.rdbCartao.Size = new System.Drawing.Size(68, 23);
            this.rdbCartao.TabIndex = 5;
            this.rdbCartao.TabStop = true;
            this.rdbCartao.Text = "Cartão";
            this.rdbCartao.UseVisualStyleBackColor = true;
            // 
            // rdbPix
            // 
            this.rdbPix.AutoSize = true;
            this.rdbPix.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdbPix.Location = new System.Drawing.Point(20, 221);
            this.rdbPix.Name = "rdbPix";
            this.rdbPix.Size = new System.Drawing.Size(47, 23);
            this.rdbPix.TabIndex = 6;
            this.rdbPix.TabStop = true;
            this.rdbPix.Text = "PIX";
            this.rdbPix.UseVisualStyleBackColor = true;
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
            // FrmFinalizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.RadioButton rdbCartao;
        private System.Windows.Forms.RadioButton rdbPix;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}