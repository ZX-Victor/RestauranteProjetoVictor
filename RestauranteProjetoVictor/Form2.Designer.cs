namespace RestauranteProjetoVictor
{
    partial class frmFood
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
            this.btnDrinks1 = new System.Windows.Forms.Button();
            this.btnSweets1 = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblSnack = new System.Windows.Forms.Label();
            this.lblSweets = new System.Windows.Forms.Label();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.txtSnack1 = new System.Windows.Forms.TextBox();
            this.txtSweets1 = new System.Windows.Forms.TextBox();
            this.txtDrinks1 = new System.Windows.Forms.TextBox();
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
            // txtSnack1
            // 
            this.txtSnack1.Location = new System.Drawing.Point(336, 52);
            this.txtSnack1.Name = "txtSnack1";
            this.txtSnack1.Size = new System.Drawing.Size(120, 20);
            this.txtSnack1.TabIndex = 6;
            // 
            // txtSweets1
            // 
            this.txtSweets1.Location = new System.Drawing.Point(336, 209);
            this.txtSweets1.Name = "txtSweets1";
            this.txtSweets1.Size = new System.Drawing.Size(120, 20);
            this.txtSweets1.TabIndex = 7;
            // 
            // txtDrinks1
            // 
            this.txtDrinks1.Location = new System.Drawing.Point(336, 360);
            this.txtDrinks1.Name = "txtDrinks1";
            this.txtDrinks1.Size = new System.Drawing.Size(120, 20);
            this.txtDrinks1.TabIndex = 8;
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDrinks1);
            this.Controls.Add(this.txtSweets1);
            this.Controls.Add(this.txtSnack1);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.lblSweets);
            this.Controls.Add(this.lblSnack);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnSweets1);
            this.Controls.Add(this.btnDrinks1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmFood";
            this.Text = "Form2";
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
        private System.Windows.Forms.TextBox txtSnack1;
        private System.Windows.Forms.TextBox txtSweets1;
        private System.Windows.Forms.TextBox txtDrinks1;
    }
}