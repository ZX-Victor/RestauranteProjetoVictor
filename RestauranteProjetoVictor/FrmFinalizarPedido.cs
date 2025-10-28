using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteProjetoVictor
{
    public partial class FrmFinalizarPedido : Form
    {
        private Dictionary<int, decimal> pedidos; // pedidoID → subtotal

        public FrmFinalizarPedido(Dictionary<int, decimal> listaPedidos)
        {
            InitializeComponent();
            pedidos = listaPedidos;

            foreach (var pedido in pedidos.Keys)
                cmbPedidos.Items.Add($"Pedido #{pedido}");

            if (cmbPedidos.Items.Count > 0)
                cmbPedidos.SelectedIndex = 0;
            
        }

        private void cmbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbPedidos.SelectedIndex;

            if (index >= 0)
            {
                int numPedido = pedidos.Keys.ElementAt(index);
                decimal valor = pedidos[numPedido];
                lblResumo.Text = $"Subtotal do pedido #{numPedido}: R$ {valor:F2}";
            }

        }
        

        private void btnPedidoFinalizado_Click(object sender, EventArgs e)
        {
            string formaPagamento = "";

            if (rdbDinheiro.Checked)
                formaPagamento = "Dinheiro";
            else if (rdbCartao.Checked)
                formaPagamento = "Cartão";
            else if (rdbPix.Checked)
                formaPagamento = "PIX";

            if (formaPagamento == "")
            {
                MessageBox.Show("Selecione uma forma de pagamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Exemplo de uso:
            MessageBox.Show($"Pagamento do pedido confirmado via {formaPagamento}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Fecha a tela se quiser
        }
        

        

        private void FrmFinalizarPedido_Load(object sender, EventArgs e)
        {
            
            // NÃO chame InitializeComponent() novamente!
            // NÃO chame CarregarPedidos() aqui!
        
        }

        private void CarregarPedidos()
        {
            foreach (var pedido in pedidos)
            {
                cmbPedidos.Items.Add($"Pedido #{pedido.Key} - Total: R$ {pedido.Value:F2}");
            }

            if (cmbPedidos.Items.Count > 0)
                cmbPedidos.SelectedIndex = 0;
        }

      
        }
    }
