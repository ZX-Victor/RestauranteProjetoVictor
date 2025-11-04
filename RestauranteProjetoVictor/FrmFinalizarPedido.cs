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
        private HashSet<int> pedidosFinalizados = new HashSet<int>();

        public FrmFinalizarPedido(Dictionary<int, decimal> listaPedidos)
        {
            InitializeComponent();
            pedidos = listaPedidos;

            // Desabilita bandeiras no início
            cmbBandeira.Enabled = false;

            // Preenche ComboBox de pedidos
            foreach (var pedido in pedidos)
                cmbPedidos.Items.Add(new KeyValuePair<int, decimal>(pedido.Key, pedido.Value));

            cmbPedidos.DisplayMember = "Key";

            if (cmbPedidos.Items.Count > 0)
                cmbPedidos.SelectedIndex = 0;
        }

        // 🔹 Quando o formulário abrir
        private void FrmFinalizarPedido_Load(object sender, EventArgs e)
        {
            // Evita duplicação
            cmbBandeira.Items.Clear();

            cmbBandeira.Items.AddRange(new string[]
            {
        "Visa",
        "MasterCard",
        "Elo",
        "Hipercard",
        "American Express"
            });

            cmbBandeira.SelectedIndex = -1; // deixa nenhuma selecionada
            cmbBandeira.Enabled = false; // começa desabilitado
        }

        // 🔹 Quando o usuário muda a seleção de pedido
        private void cmbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPedidos.SelectedIndex < 0)
                return;

            var itemSelecionado = (KeyValuePair<int, decimal>)cmbPedidos.SelectedItem;
            lblResumo.Text = $"Subtotal do pedido #{itemSelecionado.Key}: R$ {itemSelecionado.Value:F2}";
        }

        // 🔹 Quando clicar em "Finalizar Pedido"
        private void btnPedidoFinalizado_Click(object sender, EventArgs e)
        {
            string formaPagamento = "";
            string tipoCartao = "";
            string bandeira = "";
            var itemSelecionado = (KeyValuePair<int, decimal>)cmbPedidos.SelectedItem;
            int numeroPedido = itemSelecionado.Key;
            decimal total = itemSelecionado.Value;

            // Verifica qual forma de pagamento foi selecionada
            if (rdbDinheiro.Checked)
            {
                formaPagamento = "Dinheiro";
            }
            else if (rdbPix.Checked)
            {
                formaPagamento = "PIX";

                // Gera QR Code para pagamento PIX
                string chavePix = "pix@cafedovictor.com"; // sua chave PIX
                string nomeLoja = "Café do Victor";
                string cidade = "São Paulo";
                string valorPix = total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);

                string payload = $"00020126580014BR.GOV.BCB.PIX0114{chavePix}520400005303986540{valorPix}5802BR5913{nomeLoja}6009{cidade}62070503***6304";

                using (var qrGenerator = new QRCoder.QRCodeGenerator())
                {
                    var qrData = qrGenerator.CreateQrCode(payload, QRCoder.QRCodeGenerator.ECCLevel.Q);
                    var qrCode = new QRCoder.QRCode(qrData);
                    var qrImage = qrCode.GetGraphic(20);

                    // Mostra o QR code em uma nova janela (ou dentro da nota fiscal)
                    FrmQrCode frmQr = new FrmQrCode(qrImage);
                    frmQr.ShowDialog();
                }
            }
            else if (rdbCredito.Checked || rdbDebito.Checked)
            {
                tipoCartao = rdbCredito.Checked ? "Crédito" : "Débito";

                if (cmbBandeira.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione a bandeira do cartão (Visa, MasterCard, etc).",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bandeira = cmbBandeira.SelectedItem.ToString();
                formaPagamento = $"Cartão de {tipoCartao} ({bandeira})";
            }

            // Verifica se alguma forma de pagamento foi escolhida
            if (string.IsNullOrEmpty(formaPagamento))
            {
                MessageBox.Show("Selecione uma forma de pagamento.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se um pedido foi selecionado
            if (cmbPedidos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um pedido para finalizar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            // Verifica se o pedido já foi finalizado
            if (pedidosFinalizados.Contains(numeroPedido))
            {
                MessageBox.Show($"O pedido #{numeroPedido} já foi finalizado.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostra mensagem de sucesso
            MessageBox.Show($"Pagamento do pedido confirmado via {formaPagamento}!",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Exemplo de itens (pode vir da lista real de produtos)
            List<string> itens = new List<string>
    {
        "Café com leite x1 - R$ 8,00",
        "Pão de queijo x2 - R$ 6,00",
        "Torta de Oreo x1 - R$ 15,00"
    };

            // Exibe a nota fiscal
            FrmNotaFiscaL nota = new FrmNotaFiscaL(numeroPedido, total, formaPagamento, itens);
            nota.ShowDialog();

            // Marca o pedido como finalizado
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

                    string query = @"INSERT INTO Pedidos 
                             (NumeroPedido, Total, FormaPagamento, DataHora) 
                             VALUES (@NumeroPedido, @Total, @FormaPagamento, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NumeroPedido", numeroPedido);
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@FormaPagamento", formaPagamento);

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
        }


        // 🔹 Quando o usuário selecionar Crédito ou Débito
        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            // Habilita o ComboBox de bandeira quando crédito é selecionado
            cmbBandeira.Enabled = rdbCredito.Checked || rdbDebito.Checked;
        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {
            // Mesmo comportamento para débito
            cmbBandeira.Enabled = rdbCredito.Checked || rdbDebito.Checked;
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidosCadastrados frm = new FrmPedidosCadastrados();
            frm.ShowDialog();
        }
    }
}




