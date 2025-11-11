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
    public partial class FrmEntregasCadastradas : Form
    {
        string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";

        public FrmEntregasCadastradas()
        {
            InitializeComponent();
            this.Load += FrmEntregasCadastradas_Load;
            btnAtualizar10.Click += btnAtualizar_Click;
            btnMarcarEntregue.Click += btnMarcarEntregue_Click;
        }

        private void FrmEntregasCadastradas_Load(object sender, EventArgs e)
        {
            CarregarEntregas();
        }

        private void CarregarEntregas()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT IdEntrega, IdPedido, NomeCliente, Telefone, Endereco, Bairro, Cidade, 
                                            StatusEntrega, DataEntrega
                                     FROM Entregas
                                     ORDER BY IdEntrega DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEntregas.DataSource = dt;

                    dgvEntregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvEntregas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvEntregas.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar entregas:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarEntregas();
        }

        private void btnMarcarEntregue_Click(object sender, EventArgs e)
        {
            if (dgvEntregas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma entrega para marcar como entregue.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEntrega = Convert.ToInt32(dgvEntregas.SelectedRows[0].Cells["IdEntrega"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Entregas SET StatusEntrega = 'Entregue', DataEntrega = GETDATE() WHERE IdEntrega = @IdEntrega";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEntrega", idEntrega);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Entrega marcada como concluída!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarEntregas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar entrega:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaiuParaEntrega_Click(object sender, EventArgs e)
        {
            if (dgvEntregas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma entrega para marcar como 'Saiu para Entrega'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEntrega = Convert.ToInt32(dgvEntregas.SelectedRows[0].Cells["IdEntrega"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Entregas SET StatusEntrega = 'Saiu para Entrega' WHERE IdEntrega = @IdEntrega";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEntrega", idEntrega);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Entrega marcada como 'Saiu para Entrega'!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarEntregas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar entrega:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



