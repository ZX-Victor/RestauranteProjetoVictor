using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteProjetoVictor
{
    public partial class FrmNotaFiscaL : Form
    {
        public FrmNotaFiscaL(int numeroPedido, decimal total, string pagamento, List<string> itens)
        {
            InitializeComponent();

            // 🎫 Título
            lblTitulo.Text = "NOTA FISCAL PAULISTA";
            lblTitulo.Font = new Font("Courier New", 14, FontStyle.Bold);

            // 📅 Informações do pedido
            lblPedido.Text = $"Pedido nº {numeroPedido}";
            lblPagamento.Text = $"Pagamento: {pagamento}";
            lblTotal.Text = $"Total: R$ {total:F2}";

            // 💬 Código fiscal fictício
            Random rnd = new Random();
            int codigo = rnd.Next(10000000, 99999999);
            lblCodigoFiscal.Text = $"Código Fiscal: NF-{codigo}";

            // 🍽️ Itens
            foreach (string item in itens)
                lstItens.Items.Add(item);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    
        public FrmNotaFiscaL()
        {
            InitializeComponent();
        }

        private void FrmNotaFiscaL_Load(object sender, EventArgs e)
        {

        }
    }
}
