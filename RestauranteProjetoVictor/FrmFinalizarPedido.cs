using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace RestauranteProjetoVictor

{

    public partial class FrmFinalizarPedido : Form
    {
        private Dictionary<int, decimal> pedidos;
        private Dictionary<int, List<string>> itensPorPedido;
        private HashSet<int> pedidosFinalizados = new HashSet<int>();

        public FrmFinalizarPedido(Dictionary<int, decimal> listaPedidos, Dictionary<int, List<string>> listaItens)
        {
            InitializeComponent();
            pedidos = listaPedidos;
            itensPorPedido = listaItens;

            // Desabilita bandeiras no início
            cmbBandeira.Enabled = false;

            // Preenche ComboBox de pedidos
            foreach (var pedido in pedidos)
                cmbPedidos.Items.Add(new KeyValuePair<int, decimal>(pedido.Key, pedido.Value));

            cmbPedidos.DisplayMember = "Key";

            if (cmbPedidos.Items.Count > 0)
                cmbPedidos.SelectedIndex = 0;
        }

        private void FrmFinalizarPedido_Load(object sender, EventArgs e)
        {
            cmbBandeira.Items.Clear();

            cmbBandeira.Items.AddRange(new string[]
            {
                "Visa", "MasterCard", "Elo", "Hipercard", "American Express"
            });

            cmbBandeira.SelectedIndex = -1;
            cmbBandeira.Enabled = false;
        }

        private void cmbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPedidos.SelectedIndex < 0)
                return;

            var itemSelecionado = (KeyValuePair<int, decimal>)cmbPedidos.SelectedItem;
            lblResumo.Text = $"Subtotal do pedido #{itemSelecionado.Key}: R$ {itemSelecionado.Value:F2}";
        }

        private void btnPedidoFinalizado_Click(object sender, EventArgs e)
        {
            if (cmbPedidos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um pedido para finalizar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formaPagamento = "";
            string tipoCartao = "";
            string bandeira = "";

            var itemSelecionado = (KeyValuePair<int, decimal>)cmbPedidos.SelectedItem;
            int numeroPedido = itemSelecionado.Key;
            decimal total = itemSelecionado.Value;

            // 🔹 Forma de pagamento
            if (rdbDinheiro.Checked)
            {
                formaPagamento = "Dinheiro";
            }
            else if (rdbPix.Checked)
            {
                formaPagamento = "PIX";

                // Gera QR Code PIX
                string chavePix = "pix@Cafe&SalgadosdeVictor.com";
                string nomeLoja = "Café e Salgados de Victor";
                string cidade = "Campos do Jordão";
                string valorPix = total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);

                string payload = $"00020126580014BR.GOV.BCB.PIX0114{chavePix}520400005303986540{valorPix}5802BR5913{nomeLoja}6009{cidade}62070503***6304";

                using (var qrGenerator = new QRCodeGenerator())
                {
                    var qrData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                    var qrCode = new QRCode(qrData);
                    var qrImage = qrCode.GetGraphic(20);

                    FrmQrCode frmQr = new FrmQrCode(qrImage);
                    frmQr.ShowDialog();
                }
            }
            else if (rdbCredito.Checked || rdbDebito.Checked)
            {
                tipoCartao = rdbCredito.Checked ? "Crédito" : "Débito";

                if (cmbBandeira.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione a bandeira do cartão.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bandeira = cmbBandeira.SelectedItem.ToString();
                formaPagamento = $"Cartão de {tipoCartao} ({bandeira})";
            }

            if (string.IsNullOrEmpty(formaPagamento))
            {
                MessageBox.Show("Selecione uma forma de pagamento.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pedidosFinalizados.Contains(numeroPedido))
            {
                MessageBox.Show($"O pedido #{numeroPedido} já foi finalizado.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Pagamento do pedido confirmado via {formaPagamento}!",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 🔹 Busca os itens corretos do pedido
            List<string> itensDoPedido = itensPorPedido.ContainsKey(numeroPedido)
                ? itensPorPedido[numeroPedido]
                : new List<string>();

            // 🔹 Abre a nota fiscal
            FrmNotaFiscaL nota = new FrmNotaFiscaL(numeroPedido, total, formaPagamento, itensDoPedido);
            nota.ShowDialog();

            // 🔹 Marca o pedido como finalizado
            pedidosFinalizados.Add(numeroPedido);
            cmbPedidos.Items.Remove(cmbPedidos.SelectedItem);
            lblResumo.Text = "";

            // 🔹 Salva no banco de dados
            try
            {
                string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    // ✅ Aqui está a correção importante
                    string itensTexto = string.Join(", ", itensDoPedido);

                    string query = @"INSERT INTO Pedidos 
                        (NumeroPedido, Total, FormaPagamento, Itens, DataHora) 
                        VALUES (@NumeroPedido, @Total, @FormaPagamento, @Itens, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NumeroPedido", numeroPedido);
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@FormaPagamento", formaPagamento);
                        cmd.Parameters.AddWithValue("@Itens", itensTexto);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pedido salvo no banco de dados com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar pedido no banco de dados:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // 🔹 Se o cliente marcou entrega, abre o formulário de entrega
            if (chkEntrega.Checked)
            {
                FrmEntrega frmEntrega = new FrmEntrega(numeroPedido);
                frmEntrega.ShowDialog();
            }

            // 🔹 Marca o pedido como finalizado
            pedidosFinalizados.Add(numeroPedido);
            cmbPedidos.Items.Remove(cmbPedidos.SelectedItem);
            lblResumo.Text = "";
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            cmbBandeira.Enabled = rdbCredito.Checked || rdbDebito.Checked;
        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {
            cmbBandeira.Enabled = rdbCredito.Checked || rdbDebito.Checked;
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidosCadastrados frm = new FrmPedidosCadastrados();
            frm.ShowDialog();
        }
    }
}



