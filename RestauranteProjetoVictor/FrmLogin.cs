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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttUser_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string senha = txtPassword.Text;

            // String de conexão (ajuste Data Source para o nome/instância do seu SQL Server)
            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@usuario AND Senha=@senha";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        // Evita SQL Injection
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            FrmFood product = new FrmFood();
                            this.Visible = false;
                            product.ShowDialog();
                            this.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco: " + ex.Message);
                }

            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.ShowDialog();
        }
    }
}
