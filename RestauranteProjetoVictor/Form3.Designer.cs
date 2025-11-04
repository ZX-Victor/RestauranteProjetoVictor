namespace RestauranteProjetoVictor
{
    partial class FrmProducts
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
            this.components = new System.ComponentModel.Container();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.btnAlimento = new System.Windows.Forms.Button();
            this.txtAlimento2 = new System.Windows.Forms.TextBox();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.lblAlimento2 = new System.Windows.Forms.Label();
            this.lblAlimento3 = new System.Windows.Forms.Label();
            this.txtAlimento3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cJ3027414PR2DataSet = new RestauranteProjetoVictor.CJ3027414PR2DataSet();
            this.alimentosTableAdapter = new RestauranteProjetoVictor.CJ3027414PR2DataSetTableAdapters.AlimentosTableAdapter();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027414PR2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(75, 28);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(100, 22);
            this.txtAlimento.TabIndex = 0;
            // 
            // btnAlimento
            // 
            this.btnAlimento.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAlimento.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlimento.Location = new System.Drawing.Point(224, 71);
            this.btnAlimento.Name = "btnAlimento";
            this.btnAlimento.Size = new System.Drawing.Size(117, 34);
            this.btnAlimento.TabIndex = 2;
            this.btnAlimento.Text = "Registrar Id";
            this.btnAlimento.UseVisualStyleBackColor = false;
            this.btnAlimento.Click += new System.EventHandler(this.btnAlimento_Click);
            // 
            // txtAlimento2
            // 
            this.txtAlimento2.Location = new System.Drawing.Point(75, 71);
            this.txtAlimento2.Name = "txtAlimento2";
            this.txtAlimento2.Size = new System.Drawing.Size(100, 22);
            this.txtAlimento2.TabIndex = 3;
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.BackColor = System.Drawing.Color.Tan;
            this.lblAlimento.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblAlimento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlimento.Location = new System.Drawing.Point(12, 28);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(43, 23);
            this.lblAlimento.TabIndex = 4;
            this.lblAlimento.Text = "Tipo";
            this.lblAlimento.Click += new System.EventHandler(this.lblAlimento_Click);
            // 
            // lblAlimento2
            // 
            this.lblAlimento2.AutoSize = true;
            this.lblAlimento2.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblAlimento2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlimento2.Location = new System.Drawing.Point(12, 71);
            this.lblAlimento2.Name = "lblAlimento2";
            this.lblAlimento2.Size = new System.Drawing.Size(57, 23);
            this.lblAlimento2.TabIndex = 5;
            this.lblAlimento2.Text = "Nome";
            // 
            // lblAlimento3
            // 
            this.lblAlimento3.AutoSize = true;
            this.lblAlimento3.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblAlimento3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlimento3.Location = new System.Drawing.Point(12, 113);
            this.lblAlimento3.Name = "lblAlimento3";
            this.lblAlimento3.Size = new System.Drawing.Size(53, 23);
            this.lblAlimento3.TabIndex = 6;
            this.lblAlimento3.Text = "Preco";
            // 
            // txtAlimento3
            // 
            this.txtAlimento3.Location = new System.Drawing.Point(75, 113);
            this.txtAlimento3.Name = "txtAlimento3";
            this.txtAlimento3.Size = new System.Drawing.Size(100, 22);
            this.txtAlimento3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alimentosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(455, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 455);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // alimentosBindingSource
            // 
            this.alimentosBindingSource.DataMember = "Alimentos";
            this.alimentosBindingSource.DataSource = this.cJ3027414PR2DataSet;
            // 
            // cJ3027414PR2DataSet
            // 
            this.cJ3027414PR2DataSet.DataSetName = "CJ3027414PR2DataSet";
            this.cJ3027414PR2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alimentosTableAdapter
            // 
            this.alimentosTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoad.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoad.Location = new System.Drawing.Point(12, 397);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(148, 41);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Atualizar";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAlimento3);
            this.Controls.Add(this.lblAlimento3);
            this.Controls.Add(this.lblAlimento2);
            this.Controls.Add(this.lblAlimento);
            this.Controls.Add(this.txtAlimento2);
            this.Controls.Add(this.btnAlimento);
            this.Controls.Add(this.txtAlimento);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmProducts";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027414PR2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.Button btnAlimento;
        private System.Windows.Forms.TextBox txtAlimento2;
        private System.Windows.Forms.Label lblAlimento;
        private System.Windows.Forms.Label lblAlimento2;
        private System.Windows.Forms.Label lblAlimento3;
        private System.Windows.Forms.TextBox txtAlimento3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CJ3027414PR2DataSet cJ3027414PR2DataSet;
        private System.Windows.Forms.BindingSource alimentosBindingSource;
        private CJ3027414PR2DataSetTableAdapters.AlimentosTableAdapter alimentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLoad;
    }
}