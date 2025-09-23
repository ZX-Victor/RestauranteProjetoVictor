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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestauranteProjetoVictor
{
    public partial class FrmFood : Form
    {
        private List<float> preco;
        public FrmFood()
        {
            InitializeComponent();
            preco = new List<float>();
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

      

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (preco.Count == 0)
            {

                string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";
                string query = "SELECT Preco FROM Alimentos WHERE Tipo = @Tipo";

                SqlConnection connection = new SqlConnection(connectionString);

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tipo", "Salgados");

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                preco.Add(Convert.ToInt32(reader[0]));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                }
            }


            ListViewItem item = new ListViewItem(cmbSalgados.Text);

            // Adiciona subitens (colunas adicionais)
            item.SubItems.Add(cmbQtb.Text);
            item.SubItems.Add(preco[cmbSalgados.SelectedIndex].ToString());
            item.SubItems.Add($"R$ {(int.Parse(cmbQtb.Text) * preco[cmbSalgados.SelectedIndex]):F2}");

            // Adiciona o item ao ListView
            ltvPedido.Items.Add(item);


        }

        private void btnSweets1_Click(object sender, EventArgs e)
        {
            if (preco.Count == 0)
            {

                string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";
                string query = "SELECT Preco FROM Alimentos WHERE Tipo = @Tipo";

                SqlConnection connection = new SqlConnection(connectionString);

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tipo", "Doces");

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                preco.Add(Convert.ToInt32(reader[0]));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                }
            }


            ListViewItem item = new ListViewItem(cmbDoces.Text);

            // Adiciona subitens (colunas adicionais)
            item.SubItems.Add(cmbQtb1.Text);
            item.SubItems.Add(preco[cmbDoces.SelectedIndex].ToString());
            item.SubItems.Add($"R$ {(int.Parse(cmbQtb1.Text) * preco[cmbDoces.SelectedIndex]):F2}");

            // Adiciona o item ao ListView
            ltvPedido.Items.Add(item);
        }

        private void btnDrinks1_Click(object sender, EventArgs e)
        {
            if (preco.Count == 0)
            {

                string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";
                string query = "SELECT Preco FROM Alimentos WHERE Tipo = @Tipo";

                SqlConnection connection = new SqlConnection(connectionString);

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tipo", "Bebidas");

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                preco.Add(Convert.ToInt32(reader[0]));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                }
            }


            ListViewItem item = new ListViewItem(cmbBebidas.Text);

            // Adiciona subitens (colunas adicionais)
            item.SubItems.Add(cmbQtb2.Text);
            item.SubItems.Add(preco[cmbBebidas.SelectedIndex].ToString());
            item.SubItems.Add($"R$ {(int.Parse(cmbQtb2.Text) * preco[cmbBebidas.SelectedIndex]):F2}");

            // Adiciona o item ao ListView
            ltvPedido.Items.Add(item);
        }

       
        
    }
 }

