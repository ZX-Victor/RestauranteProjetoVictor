using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestauranteProjetoVictor.CJ3027414PR2DataSetTableAdapters;

namespace RestauranteProjetoVictor
{
    public partial class FrmProducts : Form
    {
        private int id;
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

                    string query = "INSERT INTO Alimentos (Tipo, Preco, Nome) VALUES ( @tipo, @preco, @nome)";

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

        private void lblAlimento_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string nome = txtAlimento2.Text;
            string tipo = txtAlimento.Text;
            decimal preco = decimal.Parse(txtAlimento3.Text);

            if (!decimal.TryParse(txtAlimento3.Text, out preco))
            {
                MessageBox.Show("Digite um valor válido para o preço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // aqui você pode usar o ID se tiver carregado ele no form

            // String de conexão (ajuste conforme seu ambiente)
            string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string query = "UPDATE Alimentos SET Nome = @Nome, Tipo = @Tipo, Preco = @Preco where id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Tipo", tipo);
                        cmd.Parameters.AddWithValue("@Preco", preco);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado para atualizar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FrmFood frmFood = new FrmFood();
                frmFood.ShowDialog();


            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0) // garante que não clicou no header
                {

                    
                    id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    txtAlimento.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtAlimento2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txtAlimento3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                   
                }
            }
        }
    }
}
