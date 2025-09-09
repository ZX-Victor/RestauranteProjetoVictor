namespace RestauranteProjetoVictor
{
    partial class FrmFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFood));
            this.btnDrinks1 = new System.Windows.Forms.Button();
            this.btnSweets1 = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblSnack = new System.Windows.Forms.Label();
            this.lblSweets = new System.Windows.Forms.Label();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.cmbSalgados = new System.Windows.Forms.ComboBox();
            this.cmbDoces = new System.Windows.Forms.ComboBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.listBoxPedido = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrinks1
            // 
            this.btnDrinks1.Location = new System.Drawing.Point(470, 353);
            this.btnDrinks1.Name = "btnDrinks1";
            this.btnDrinks1.Size = new System.Drawing.Size(108, 27);
            this.btnDrinks1.TabIndex = 0;
            this.btnDrinks1.Text = "Escolha a bebida";
            this.btnDrinks1.UseVisualStyleBackColor = true;
            // 
            // btnSweets1
            // 
            this.btnSweets1.Location = new System.Drawing.Point(470, 200);
            this.btnSweets1.Name = "btnSweets1";
            this.btnSweets1.Size = new System.Drawing.Size(108, 27);
            this.btnSweets1.TabIndex = 1;
            this.btnSweets1.Text = "Escolha o doce";
            this.btnSweets1.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(470, 47);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(108, 25);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Escolha o salgado";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // lblSnack
            // 
            this.lblSnack.AutoSize = true;
            this.lblSnack.BackColor = System.Drawing.Color.White;
            this.lblSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnack.Location = new System.Drawing.Point(333, 32);
            this.lblSnack.Name = "lblSnack";
            this.lblSnack.Size = new System.Drawing.Size(69, 16);
            this.lblSnack.TabIndex = 3;
            this.lblSnack.Text = "Salgados:";
            this.lblSnack.Click += new System.EventHandler(this.lblSnack_Click);
            // 
            // lblSweets
            // 
            this.lblSweets.AutoSize = true;
            this.lblSweets.BackColor = System.Drawing.Color.White;
            this.lblSweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSweets.Location = new System.Drawing.Point(333, 190);
            this.lblSweets.Name = "lblSweets";
            this.lblSweets.Size = new System.Drawing.Size(50, 16);
            this.lblSweets.TabIndex = 4;
            this.lblSweets.Text = "Doces:";
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.BackColor = System.Drawing.Color.White;
            this.lblDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinks.Location = new System.Drawing.Point(333, 331);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(61, 16);
            this.lblDrinks.TabIndex = 5;
            this.lblDrinks.Text = "Bebidas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tan;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(601, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(670, 81);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(118, 31);
            this.btnProdutos.TabIndex = 10;
            this.btnProdutos.Text = "Adicionar Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // cmbSalgados
            // 
            this.cmbSalgados.FormattingEnabled = true;
            this.cmbSalgados.Location = new System.Drawing.Point(335, 51);
            this.cmbSalgados.Name = "cmbSalgados";
            this.cmbSalgados.Size = new System.Drawing.Size(121, 21);
            this.cmbSalgados.TabIndex = 11;
            // 
            // cmbDoces
            // 
            this.cmbDoces.FormattingEnabled = true;
            this.cmbDoces.Location = new System.Drawing.Point(335, 209);
            this.cmbDoces.Name = "cmbDoces";
            this.cmbDoces.Size = new System.Drawing.Size(121, 21);
            this.cmbDoces.TabIndex = 12;
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(335, 357);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(121, 21);
            this.cmbBebidas.TabIndex = 13;
            // 
            // listBoxPedido
            // 
            this.listBoxPedido.FormattingEnabled = true;
            this.listBoxPedido.Location = new System.Drawing.Point(9, 12);
            this.listBoxPedido.Name = "listBoxPedido";
            this.listBoxPedido.Size = new System.Drawing.Size(318, 381);
            this.listBoxPedido.TabIndex = 14;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(670, 25);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(118, 32);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "Adicionar ao Pedido";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // FrmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listBoxPedido);
            this.Controls.Add(this.cmbBebidas);
            this.Controls.Add(this.cmbDoces);
            this.Controls.Add(this.cmbSalgados);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.lblSweets);
            this.Controls.Add(this.lblSnack);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnSweets1);
            this.Controls.Add(this.btnDrinks1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmFood";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrinks1;
        private System.Windows.Forms.Button btnSweets1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblSnack;
        private System.Windows.Forms.Label lblSweets;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.ComboBox cmbSalgados;
        private System.Windows.Forms.ComboBox cmbDoces;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.ListBox listBoxPedido;
        private System.Windows.Forms.Button btnAdicionar;
    }
}