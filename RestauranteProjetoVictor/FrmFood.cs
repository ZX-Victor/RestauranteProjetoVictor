using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteProjetoVictor
{
    public partial class FrmFood : Form
    {
        public FrmFood()
        {
            InitializeComponent();
        }

        private void lblSnack_Click(object sender, EventArgs e)
        {

        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Carregar salgados
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT Id, Nome FROM Alimentos WHERE Tipo = 'Salgados'", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                cmbSalgados.DataSource = dt1;
                cmbSalgados.DisplayMember = "Nome";  // o que aparece para o usuário
                cmbSalgados.ValueMember = "Id";      // o valor interno (id do produto)

                // Carregar doces
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT Id, Nome FROM Alimentos WHERE Tipo = 'Doces'", con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                cmbDoces.DataSource = dt2;
                cmbDoces.DisplayMember = "Nome";
                cmbDoces.ValueMember = "Id";

                // Carregar bebidas
                SqlDataAdapter da3 = new SqlDataAdapter("SELECT Id, Nome FROM Alimentos WHERE Tipo = 'Bebida'", con);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                cmbBebidas.DataSource = dt3;
                cmbBebidas.DisplayMember = "Nome";
                cmbBebidas.ValueMember = "Id";
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmProducts frmProducts = new FrmProducts();
            frmProducts.ShowDialog();
            
        }
        private void Form2_Load(object sender, EventArgs e)
{
    
}

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cmbSalgados.SelectedValue != null)
            {
                listBoxPedido.Items.Add("Salgado: " + cmbSalgados.Text);
            }
            if (cmbDoces.SelectedValue != null)
            {
                listBoxPedido.Items.Add("Doce: " + cmbDoces.Text);
            }
            if (cmbBebidas.SelectedValue != null)
            {
                listBoxPedido.Items.Add("Bebida: " + cmbBebidas.Text);
            }
            if (cmbSalgados.SelectedItem != null);
            // Salgado
            if (cmbSalgados.SelectedItem != null)
            
            {
                DataRowView row = (DataRowView)cmbSalgados.SelectedItem;
                string nome = row["Nome"].ToString();
                decimal preco = Convert.ToDecimal(row["Preco"]);
                listBoxPedido.Items.Add($"Salgado: {nome} - R$ {preco:F2}");
            }

            // Doce
            if (cmbDoces.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cmbDoces.SelectedItem;
                string nome = row["Nome"].ToString();
                decimal preco = Convert.ToDecimal(row["Preco"]);
                listBoxPedido.Items.Add($"Doce: {nome} - R$ {preco:F2}");
            }

            // Bebida
            if (cmbBebidas.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cmbBebidas.SelectedItem;
                string nome = row["Nome"].ToString();
                decimal preco = Convert.ToDecimal(row["Preco"]);
                listBoxPedido.Items.Add($"Bebida: {nome} - R$ {preco:F2}");
            }
        }
    }
}
