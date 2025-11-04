namespace RestauranteProjetoVictor
{
    partial class FrmNotaFiscaL
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblCodigoFiscal = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblICMS = new System.Windows.Forms.Label();
            this.lblTotalComImposto = new System.Windows.Forms.Label();
            this.lblISS = new System.Windows.Forms.Label();
            this.lblPIS = new System.Windows.Forms.Label();
            this.lblCOFINS = new System.Windows.Forms.Label();
            this.lblTotalTributos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblTitulo.Location = new System.Drawing.Point(21, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nota Fiscal Eletrônica";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblPedido.Location = new System.Drawing.Point(14, 52);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(45, 19);
            this.lblPedido.TabIndex = 1;
            this.lblPedido.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblTotal.Location = new System.Drawing.Point(14, 90);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 19);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label2";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblPagamento.Location = new System.Drawing.Point(14, 283);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(45, 19);
            this.lblPagamento.TabIndex = 3;
            this.lblPagamento.Text = "label3";
            // 
            // lstItens
            // 
            this.lstItens.BackColor = System.Drawing.SystemColors.Window;
            this.lstItens.FormattingEnabled = true;
            this.lstItens.Location = new System.Drawing.Point(468, 1);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(331, 355);
            this.lstItens.TabIndex = 4;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFechar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechar.Location = new System.Drawing.Point(619, 385);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(169, 39);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblCodigoFiscal
            // 
            this.lblCodigoFiscal.AutoSize = true;
            this.lblCodigoFiscal.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblCodigoFiscal.Location = new System.Drawing.Point(229, 131);
            this.lblCodigoFiscal.Name = "lblCodigoFiscal";
            this.lblCodigoFiscal.Size = new System.Drawing.Size(45, 19);
            this.lblCodigoFiscal.TabIndex = 6;
            this.lblCodigoFiscal.Text = "label4";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblCpf.Location = new System.Drawing.Point(229, 165);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(45, 19);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "label5";
            // 
            // lblICMS
            // 
            this.lblICMS.AutoSize = true;
            this.lblICMS.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblICMS.Location = new System.Drawing.Point(14, 131);
            this.lblICMS.Name = "lblICMS";
            this.lblICMS.Size = new System.Drawing.Size(45, 19);
            this.lblICMS.TabIndex = 8;
            this.lblICMS.Text = "label6";
            // 
            // lblTotalComImposto
            // 
            this.lblTotalComImposto.AutoSize = true;
            this.lblTotalComImposto.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblTotalComImposto.Location = new System.Drawing.Point(229, 90);
            this.lblTotalComImposto.Name = "lblTotalComImposto";
            this.lblTotalComImposto.Size = new System.Drawing.Size(45, 19);
            this.lblTotalComImposto.TabIndex = 9;
            this.lblTotalComImposto.Text = "label7";
            // 
            // lblISS
            // 
            this.lblISS.AutoSize = true;
            this.lblISS.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblISS.Location = new System.Drawing.Point(14, 165);
            this.lblISS.Name = "lblISS";
            this.lblISS.Size = new System.Drawing.Size(45, 19);
            this.lblISS.TabIndex = 10;
            this.lblISS.Text = "label8";
            // 
            // lblPIS
            // 
            this.lblPIS.AutoSize = true;
            this.lblPIS.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblPIS.Location = new System.Drawing.Point(14, 206);
            this.lblPIS.Name = "lblPIS";
            this.lblPIS.Size = new System.Drawing.Size(45, 19);
            this.lblPIS.TabIndex = 11;
            this.lblPIS.Text = "label9";
            // 
            // lblCOFINS
            // 
            this.lblCOFINS.AutoSize = true;
            this.lblCOFINS.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblCOFINS.Location = new System.Drawing.Point(14, 245);
            this.lblCOFINS.Name = "lblCOFINS";
            this.lblCOFINS.Size = new System.Drawing.Size(53, 19);
            this.lblCOFINS.TabIndex = 12;
            this.lblCOFINS.Text = "label10";
            this.lblCOFINS.Click += new System.EventHandler(this.lblCOFINS_Click);
            // 
            // lblTotalTributos
            // 
            this.lblTotalTributos.AutoSize = true;
            this.lblTotalTributos.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblTotalTributos.Location = new System.Drawing.Point(229, 52);
            this.lblTotalTributos.Name = "lblTotalTributos";
            this.lblTotalTributos.Size = new System.Drawing.Size(53, 19);
            this.lblTotalTributos.TabIndex = 13;
            this.lblTotalTributos.Text = "label11";
            // 
            // FrmNotaFiscaL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalTributos);
            this.Controls.Add(this.lblCOFINS);
            this.Controls.Add(this.lblPIS);
            this.Controls.Add(this.lblISS);
            this.Controls.Add(this.lblTotalComImposto);
            this.Controls.Add(this.lblICMS);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblCodigoFiscal);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lstItens);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmNotaFiscaL";
            this.Text = "FrmNotaFiscaL";
            this.Load += new System.EventHandler(this.FrmNotaFiscaL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblCodigoFiscal;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblICMS;
        private System.Windows.Forms.Label lblTotalComImposto;
        private System.Windows.Forms.Label lblISS;
        private System.Windows.Forms.Label lblPIS;
        private System.Windows.Forms.Label lblCOFINS;
        private System.Windows.Forms.Label lblTotalTributos;
    }
}