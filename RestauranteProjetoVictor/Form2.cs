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
    public partial class FrmFood : Form
    {
        public FrmFood()
        {
            InitializeComponent();
        }

        private void lblSnack_Click(object sender, EventArgs e)
        {

        }

        private void frmFood_Load(object sender, EventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmProducts frmProducts = new FrmProducts();
            frmProducts.ShowDialog();
            
        }
    }
}
