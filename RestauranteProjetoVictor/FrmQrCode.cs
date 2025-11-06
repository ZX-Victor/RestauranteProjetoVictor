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
    public partial class FrmQrCode : Form
    {
        public FrmQrCode(Image qrImage)
        {
            InitializeComponent();
            picQrCode.Image = qrImage;
        }

        private void FrmQrCode_Load(object sender, EventArgs e)
        {

        }
    }
}
