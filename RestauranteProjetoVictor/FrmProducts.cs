using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteProjetoVictor
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void btnAlimento_Click(object sender, EventArgs e)
        {
            string nome = txtAlimento2.Text;
            string tipo = txtAlimento.Text;
            //string preco = txtAlimento3.Text;
            decimal preco;
            bool sucesso = decimal.TryParse(txtAlimento3.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out preco);

            // Valida os dados básicos
            if (!Decimal.TryParse(txtAlimento3.Text, out preco) 
                || string.IsNullOrEmpty(txtAlimento.Text) 
                || string.IsNullOrEmpty(txtAlimento2.Text))
            {
                MessageBox.Show("Campo(s) inválido(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // String de conexão (ajuste conforme seu ambiente)
            string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string query = "INSERT INTO Alimentos (Nome, Tipo, Preco) VALUES (@nome, @tipo, @preco)";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@preco", preco);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Id registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Limpar campos, se quiser
                            txtAlimento.Clear();
                            txtAlimento2.Clear();
                            txtAlimento3.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível registrar o Id.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cJ3027414PR2DataSet.Alimentos'. Você pode movê-la ou removê-la conforme necessário.
            this.alimentosTableAdapter.Fill(this.cJ3027414PR2DataSet.Alimentos);

        }
    }
}
