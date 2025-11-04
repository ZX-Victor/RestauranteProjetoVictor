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
        private static readonly Random rnd = new Random();

        public FrmNotaFiscaL(int numeroPedido, decimal total, string pagamento, List<string> itens)
        {
            InitializeComponent();

            // 🎫 Título
            lblTitulo.Text = "NOTA FISCAL PAULISTA";
            lblTitulo.Font = new Font("Courier New", 14, FontStyle.Bold);

            // 📅 Informações básicas
            lblPedido.Text = $"Pedido nº {numeroPedido}";
            lblPagamento.Text = $"Pagamento: {pagamento}";
            lblTotal.Text = $"Total: R$ {total:F2}";

            // 💰 Cálculo dos impostos
            decimal aliquotaICMS = 0.18m;
            decimal aliquotaISS = 0.05m;
            decimal aliquotaPIS = 0.0165m;
            decimal aliquotaCOFINS = 0.076m;

            decimal valorICMS = total * aliquotaICMS;
            decimal valorISS = total * aliquotaISS;
            decimal valorPIS = total * aliquotaPIS;
            decimal valorCOFINS = total * aliquotaCOFINS;

            decimal totalTributos = valorICMS + valorISS + valorPIS + valorCOFINS;
            decimal totalComImposto = total + totalTributos;

            decimal percentualTributos = (totalTributos / total) * 100;

            // 🧾 Exibição dos impostos
            lblICMS.Text = $"ICMS (18%): R$ {valorICMS:F2}";
            lblISS.Text = $"ISS (5%): R$ {valorISS:F2}";
            lblPIS.Text = $"PIS (1,65%): R$ {valorPIS:F2}";
            lblCOFINS.Text = $"COFINS (7,6%): R$ {valorCOFINS:F2}";
            lblTotalTributos.Text = $"Total de Tributos: R$ {totalTributos:F2} ({percentualTributos:F2}%)";
            lblTotalComImposto.Text = $"Total com Impostos: R$ {totalComImposto:F2}";

            // 💬 Código fiscal fictício
            int codigo = rnd.Next(10000000, 99999999);
            lblCodigoFiscal.Text = $"Código Fiscal: NF-{codigo}";

            // 🧾 CPF
            string cpf = GerarCpfAleatorio();
            lblCpf.Text = $"CPF: {cpf}";

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

        private string GerarCpfAleatorio()
        {
            Random rnd = new Random();

            int n1 = rnd.Next(0, 10);
            int n2 = rnd.Next(0, 10);
            int n3 = rnd.Next(0, 10);
            int n4 = rnd.Next(0, 10);
            int n5 = rnd.Next(0, 10);
            int n6 = rnd.Next(0, 10);
            int n7 = rnd.Next(0, 10);
            int n8 = rnd.Next(0, 10);
            int n9 = rnd.Next(0, 10);

            int d1 = n9 * 2 + n8 * 3 + n7 * 4 + n6 * 5 + n5 * 6 + n4 * 7 + n3 * 8 + n2 * 9 + n1 * 10;
            d1 = 11 - (d1 % 11);
            if (d1 >= 10) d1 = 0;

            int d2 = d1 * 2 + n9 * 3 + n8 * 4 + n7 * 5 + n6 * 6 + n5 * 7 + n4 * 8 + n3 * 9 + n2 * 10 + n1 * 11;
            d2 = 11 - (d2 % 11);
            if (d2 >= 10) d2 = 0;

            return $"{n1}{n2}{n3}.{n4}{n5}{n6}.{n7}{n8}{n9}-{d1}{d2}";
        }


        private void FrmNotaFiscaL_Load(object sender, EventArgs e)
        {

        }

        private void lblCOFINS_Click(object sender, EventArgs e)
        {

        }

       
    }
}
