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
    public partial class FrmCadastro : Form
    {
      
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
           

        }

        private void btnNewCadastro_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";
          

            string usuario = txtNewUser .Text.Trim();
            string senha = txtNewPassword .Text.Trim();
            string confirmarSenha = txtConfirmNewPassword .Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não conferem!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Usuarios (Usuario, Senha) VALUES (@Usuario, @Senha)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");

                    this.Close(); // fecha a tela de cadastro
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}
        
