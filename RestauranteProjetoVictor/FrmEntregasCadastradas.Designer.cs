namespace RestauranteProjetoVictor
{
    partial class FrmEntregasCadastradas
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
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.btnAtualizar10 = new System.Windows.Forms.Button();
            this.btnMarcarEntregue = new System.Windows.Forms.Button();
            this.btnSaiuParaEntrega = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.Location = new System.Drawing.Point(0, 1);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.Size = new System.Drawing.Size(598, 450);
            this.dgvEntregas.TabIndex = 0;
            // 
            // btnAtualizar10
            // 
            this.btnAtualizar10.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAtualizar10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar10.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnAtualizar10.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizar10.Location = new System.Drawing.Point(628, 153);
            this.btnAtualizar10.Name = "btnAtualizar10";
            this.btnAtualizar10.Size = new System.Drawing.Size(160, 54);
            this.btnAtualizar10.TabIndex = 1;
            this.btnAtualizar10.Text = "Atualizar";
            this.btnAtualizar10.UseVisualStyleBackColor = false;
            this.btnAtualizar10.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnMarcarEntregue
            // 
            this.btnMarcarEntregue.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnMarcarEntregue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarEntregue.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnMarcarEntregue.ForeColor = System.Drawing.Color.Transparent;
            this.btnMarcarEntregue.Location = new System.Drawing.Point(628, 369);
            this.btnMarcarEntregue.Name = "btnMarcarEntregue";
            this.btnMarcarEntregue.Size = new System.Drawing.Size(160, 54);
            this.btnMarcarEntregue.TabIndex = 2;
            this.btnMarcarEntregue.Text = " Entregue!";
            this.btnMarcarEntregue.UseVisualStyleBackColor = false;
            this.btnMarcarEntregue.Click += new System.EventHandler(this.btnMarcarEntregue_Click);
            // 
            // btnSaiuParaEntrega
            // 
            this.btnSaiuParaEntrega.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSaiuParaEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaiuParaEntrega.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnSaiuParaEntrega.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaiuParaEntrega.Location = new System.Drawing.Point(628, 266);
            this.btnSaiuParaEntrega.Name = "btnSaiuParaEntrega";
            this.btnSaiuParaEntrega.Size = new System.Drawing.Size(160, 54);
            this.btnSaiuParaEntrega.TabIndex = 3;
            this.btnSaiuParaEntrega.Text = "Saiu para Entrega!";
            this.btnSaiuParaEntrega.UseVisualStyleBackColor = false;
            this.btnSaiuParaEntrega.Click += new System.EventHandler(this.btnSaiuParaEntrega_Click);
            // 
            // FrmEntregasCadastradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaiuParaEntrega);
            this.Controls.Add(this.btnMarcarEntregue);
            this.Controls.Add(this.btnAtualizar10);
            this.Controls.Add(this.dgvEntregas);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmEntregasCadastradas";
            this.Text = "FrmEntregasCadastradas";
            this.Load += new System.EventHandler(this.FrmEntregasCadastradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.Button btnAtualizar10;
        private System.Windows.Forms.Button btnMarcarEntregue;
        private System.Windows.Forms.Button btnSaiuParaEntrega;
    }
}