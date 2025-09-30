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
    public partial class FrmRecuperarSenha : Form
    {
        public FrmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void lblNovoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblRenovaçãoDaSenha_Click(object sender, EventArgs e)
        {

        }

        private void FrmRecuperarSenha_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";

            {
                InitializeComponent();
            }
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            string usuario = txtConfirmaçãoDeUsuario.Text.Trim();
            string novaSenha = txtRenovaçãoDaSenha.Text;
            string confirmar = txtConfirmeSuaSenha.Text;

            MessageBox.Show($"Usuário: {usuario}\nNova Senha: {novaSenha}\nConfirmar: {confirmar}");

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmar))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaSenha != confirmar)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("sua_connection_string"))
                {
                    conn.Open();
                    string query = "UPDATE Funcionarios SET Senha = @senha WHERE Usuario = @usuario";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@senha", novaSenha);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    int linhas = cmd.ExecuteNonQuery();
                    if (linhas > 0)
                    {
                        MessageBox.Show("Senha redefinida com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
    

