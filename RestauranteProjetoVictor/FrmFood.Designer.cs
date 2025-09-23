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
            this.ltvPedido = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbQtb = new System.Windows.Forms.ComboBox();
            this.cmbQtb1 = new System.Windows.Forms.ComboBox();
            this.cmbQtb2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrinks1
            // 
            this.btnDrinks1.Location = new System.Drawing.Point(680, 265);
            this.btnDrinks1.Name = "btnDrinks1";
            this.btnDrinks1.Size = new System.Drawing.Size(108, 27);
            this.btnDrinks1.TabIndex = 0;
            this.btnDrinks1.Text = "Escolha a bebida";
            this.btnDrinks1.UseVisualStyleBackColor = true;
            this.btnDrinks1.Click += new System.EventHandler(this.btnDrinks1_Click);
            // 
            // btnSweets1
            // 
            this.btnSweets1.Location = new System.Drawing.Point(680, 215);
            this.btnSweets1.Name = "btnSweets1";
            this.btnSweets1.Size = new System.Drawing.Size(108, 27);
            this.btnSweets1.TabIndex = 1;
            this.btnSweets1.Text = "Escolha o doce";
            this.btnSweets1.UseVisualStyleBackColor = true;
            this.btnSweets1.Click += new System.EventHandler(this.btnSweets1_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(680, 160);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(108, 25);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Escolha o salgado";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblSnack
            // 
            this.lblSnack.AutoSize = true;
            this.lblSnack.BackColor = System.Drawing.Color.White;
            this.lblSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnack.Location = new System.Drawing.Point(486, 144);
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
            this.lblSweets.Location = new System.Drawing.Point(486, 200);
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
            this.lblDrinks.Location = new System.Drawing.Point(485, 250);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(61, 16);
            this.lblDrinks.TabIndex = 5;
            this.lblDrinks.Text = "Bebidas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tan;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(520, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(670, 45);
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
            this.cmbSalgados.Location = new System.Drawing.Point(488, 163);
            this.cmbSalgados.Name = "cmbSalgados";
            this.cmbSalgados.Size = new System.Drawing.Size(121, 21);
            this.cmbSalgados.TabIndex = 11;
            // 
            // cmbDoces
            // 
            this.cmbDoces.FormattingEnabled = true;
            this.cmbDoces.Location = new System.Drawing.Point(488, 219);
            this.cmbDoces.Name = "cmbDoces";
            this.cmbDoces.Size = new System.Drawing.Size(121, 21);
            this.cmbDoces.TabIndex = 12;
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(488, 271);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(121, 21);
            this.cmbBebidas.TabIndex = 13;
            // 
            // ltvPedido
            // 
            this.ltvPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ltvPedido.HideSelection = false;
            this.ltvPedido.Location = new System.Drawing.Point(2, 12);
            this.ltvPedido.Name = "ltvPedido";
            this.ltvPedido.Size = new System.Drawing.Size(455, 431);
            this.ltvPedido.TabIndex = 16;
            this.ltvPedido.UseCompatibleStateImageBehavior = false;
            this.ltvPedido.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produto";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qtd";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 90;
            // 
            // cmbQtb
            // 
            this.cmbQtb.FormattingEnabled = true;
            this.cmbQtb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQtb.Location = new System.Drawing.Point(615, 164);
            this.cmbQtb.Name = "cmbQtb";
            this.cmbQtb.Size = new System.Drawing.Size(50, 21);
            this.cmbQtb.TabIndex = 17;
            // 
            // cmbQtb1
            // 
            this.cmbQtb1.FormattingEnabled = true;
            this.cmbQtb1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQtb1.Location = new System.Drawing.Point(615, 219);
            this.cmbQtb1.Name = "cmbQtb1";
            this.cmbQtb1.Size = new System.Drawing.Size(50, 21);
            this.cmbQtb1.TabIndex = 18;
            // 
            // cmbQtb2
            // 
            this.cmbQtb2.FormattingEnabled = true;
            this.cmbQtb2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQtb2.Location = new System.Drawing.Point(616, 269);
            this.cmbQtb2.Name = "cmbQtb2";
            this.cmbQtb2.Size = new System.Drawing.Size(50, 21);
            this.cmbQtb2.TabIndex = 19;
            // 
            // FrmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbQtb2);
            this.Controls.Add(this.cmbQtb1);
            this.Controls.Add(this.cmbQtb);
            this.Controls.Add(this.ltvPedido);
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
        private System.Windows.Forms.ListView ltvPedido;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cmbQtb;
        private System.Windows.Forms.ComboBox cmbQtb1;
        private System.Windows.Forms.ComboBox cmbQtb2;
    }
}