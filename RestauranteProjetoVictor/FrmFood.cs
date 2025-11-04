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
        private string usuarioLogado;
        int numeroPedido = 1;
        decimal subtotalAtual = 0;
        List<decimal> listaPrecos = new List<decimal>();
        private List<float> preco;

        // ✅ Construtor modificado para receber o nome do usuário logado
        public FrmFood(string usuario)
        {
            InitializeComponent();
            preco = new List<float>();
            usuarioLogado = usuario;
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
            // 🔒 Verifica se o usuário é admin
            if (usuarioLogado.ToLower() != "admin")
            {
                MessageBox.Show("🚫 Você não tem permissão para acessar esta funcionalidade.",
                                "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmProducts frmProducts = new FrmProducts(usuarioLogado);
            frmProducts.ShowDialog();
        }

        private void EnsurePrecos(string tipo)
        {
            listaPrecos.Clear();

            string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";
            string query = "SELECT Preco FROM Alimentos WHERE Tipo = @Tipo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Tipo", tipo);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaPrecos.Add(Convert.ToDecimal(reader[0]));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }
        }




        private void btnChoose_Click(object sender, EventArgs e) // salgados
        {
            // carrega preços dos salgados na lista
            EnsurePrecos("Salgados");

            if (cmbSalgados.SelectedIndex < 0) return;

            string produto = cmbSalgados.Text;
            int quantidade = int.TryParse(cmbQtb.Text, out var q1) ? q1 : 1;
            decimal precoUnitario = listaPrecos[cmbSalgados.SelectedIndex];
            decimal total = quantidade * precoUnitario;

            ListViewItem itemSalgado = new ListViewItem(produto);
            itemSalgado.SubItems.Add(quantidade.ToString());
            itemSalgado.SubItems.Add(precoUnitario.ToString("C"));
            itemSalgado.SubItems.Add(total.ToString("C"));
            ltvPedido.Items.Add(itemSalgado);

            subtotalAtual += total;
        }

        private void btnSweets1_Click(object sender, EventArgs e) // doces
        {
            EnsurePrecos("Doces");

            if (cmbDoces.SelectedIndex < 0) return;

            string produto = cmbDoces.Text;
            int quantidade = int.TryParse(cmbQtb1.Text, out var q2) ? q2 : 1;
            decimal precoUnitario = listaPrecos[cmbDoces.SelectedIndex];
            decimal total = quantidade * precoUnitario;

            ListViewItem itemDoce = new ListViewItem(produto);
            itemDoce.SubItems.Add(quantidade.ToString());
            itemDoce.SubItems.Add(precoUnitario.ToString("C"));
            itemDoce.SubItems.Add(total.ToString("C"));
            ltvPedido.Items.Add(itemDoce);

            subtotalAtual += total;
        }

        private void btnDrinks1_Click(object sender, EventArgs e)
        {
            EnsurePrecos("Bebida");

            if (cmbBebidas.SelectedIndex < 0 || cmbBebidas.SelectedIndex >= listaPrecos.Count)
            {
                MessageBox.Show("Preço da bebida não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string produto = cmbBebidas.Text;
            int quantidade = int.TryParse(cmbQtb2.Text, out var q3) ? q3 : 1;
            decimal precoUnitario = listaPrecos[cmbBebidas.SelectedIndex];
            decimal total = quantidade * precoUnitario;

            ListViewItem itemBebida = new ListViewItem(produto);
            itemBebida.SubItems.Add(quantidade.ToString());
            itemBebida.SubItems.Add(precoUnitario.ToString("C"));
            itemBebida.SubItems.Add(total.ToString("C"));
            ltvPedido.Items.Add(itemBebida);

            subtotalAtual += total;
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            // se houver itens no pedido atual, adiciona subtotal do pedido anterior
            if (subtotalAtual > 0)
            {
                ListViewItem subtotalItem = new ListViewItem($"Subtotal Pedido #{numeroPedido}:");
                subtotalItem.SubItems.Add("");
                subtotalItem.SubItems.Add("");
                subtotalItem.SubItems.Add(subtotalAtual.ToString("C"));
                subtotalItem.ForeColor = Color.DarkGreen;
                subtotalItem.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                ltvPedido.Items.Add(subtotalItem);

                // linha em branco
                ltvPedido.Items.Add(new ListViewItem(""));
            }

            // cria separador para o pedido atual
            ListViewItem separadorItem = new ListViewItem($"--- Pedido #{numeroPedido} ---");
            separadorItem.SubItems.Add("");
            separadorItem.SubItems.Add("");
            separadorItem.SubItems.Add("");
            separadorItem.BackColor = Color.Beige;
            separadorItem.ForeColor = Color.Brown;
            separadorItem.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            ltvPedido.Items.Add(separadorItem);

            // zera o subtotal e incrementa para o próximo
            subtotalAtual = 0m;
            numeroPedido++;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ltvPedido.Items.Count == 0)
            {
                MessageBox.Show("Nenhum pedido para finalizar.");
                return;
            }

            // Dicionário de pedidos e seus subtotais
            Dictionary<int, decimal> pedidos = new Dictionary<int, decimal>();

            int numeroAtual = 0;
            decimal subtotal = 0;

            foreach (ListViewItem item in ltvPedido.Items)
            {
                string texto = item.Text;

                if (texto.StartsWith("--- Pedido #"))
                {
                    // Se já existe subtotal anterior, salva no dicionário
                    if (numeroAtual != 0)
                        pedidos[numeroAtual] = subtotal;

                    // Novo pedido
                    string numeroStr = texto.Replace("--- Pedido #", "").Replace(" ---", "").Trim();
                    int.TryParse(numeroStr, out numeroAtual);
                    subtotal = 0;
                }
                else if (texto.StartsWith("Subtotal"))
                {
                    // Pula, pois já tratamos subtotal
                    continue;
                }
                else if (item.SubItems.Count >= 4)
                {
                    // Soma os totais
                    string totalStr = item.SubItems[3].Text.Replace("R$", "").Trim();
                    if (decimal.TryParse(totalStr, out decimal valor))
                        subtotal += valor;
                }
            }

            // Adiciona o último pedido
            if (numeroAtual != 0)
                pedidos[numeroAtual] = subtotal;

            // Abre o formulário de finalização passando o dicionário
            FrmFinalizarPedido frm = new FrmFinalizarPedido(pedidos);
            frm.ShowDialog();
        }
    }
}







