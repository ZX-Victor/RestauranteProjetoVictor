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
    public partial class FrmPedidosCadastrados : Form
    {
        public FrmPedidosCadastrados()
        {
            InitializeComponent();
            CarregarPedidos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private void CarregarPedidos()
        {
            string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT NumeroPedido, Itens, Total, FormaPagamento, DataHora FROM Pedidos ORDER BY DataHora DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conexao);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPedidos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar pedidos: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
