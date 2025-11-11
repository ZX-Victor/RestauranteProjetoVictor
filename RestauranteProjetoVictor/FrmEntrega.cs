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
    public partial class FrmEntrega : Form
    {
        string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;";
        private int numeroPedido; // campo para guardar o número do pedido

        // Construtor já existente (se tiver)
        public FrmEntrega()
        {
            {
                InitializeComponent();

                // 🧾 Configurações dos campos de texto:

                // Nome do cliente – até 100 caracteres
                txtNome1.MaxLength = 100;

                // Telefone – até 15 caracteres e só números + símbolos comuns
                txtTelefone.MaxLength = 15;
                txtTelefone.KeyPress += (s, e) =>
                {
                    // Aceita apenas dígitos, espaço, parênteses, traço e '+'
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                        e.KeyChar != ' ' && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '-'
                        && e.KeyChar != '+')
                    {
                        e.Handled = true; // bloqueia
                    }
                };

                // Endereço – até 200 caracteres
                txtEndereco.MaxLength = 200;

                // Bairro – até 100 caracteres
                txtBairro.MaxLength = 100;

                // Cidade – até 100 caracteres
                txtCidade.MaxLength = 100;

                // Se quiser: bloquear caracteres especiais nesses campos de texto puro
                txtNome1.KeyPress += SomenteLetrasComEspaco;
                txtBairro.KeyPress += SomenteLetrasComEspaco;
                txtCidade.KeyPress += SomenteLetrasComEspaco;
            }
        }
// Método auxiliar para aceitar apenas letras e espaço
private void SomenteLetrasComEspaco(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        // <-- ADICIONE ESTE CONSTRUTOR:
        public FrmEntrega(int pedido) : this()   // chama o construtor padrão para garantir InitializeComponent()
        {
            numeroPedido = pedido;
            // se você tiver um label de título, atualize-o:
            if (this.Controls.ContainsKey("lblTitulo"))
                lblTitulo10.Text = $"Entrega do Pedido #{numeroPedido}";

            // Opcional: pré-preencher o campo txtPedido (se existir)
            if (this.Controls.ContainsKey("txtPedido"))
            {
                txtPedido1.Text = numeroPedido.ToString();
                txtPedido1.Enabled = false; // evita edição
            }
        }


        private void btnSalvarEntrega_Click(object sender, EventArgs e)
            {
            // Pega os dados digitados
            string nome = txtNome1.Text.Trim();
            string telefone = txtTelefone.Text.Trim();
            string endereco = txtEndereco.Text.Trim();
            string bairro = txtBairro.Text.Trim();
            string cidade = txtCidade.Text.Trim();

            // Validação simples
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco) || string.IsNullOrEmpty(cidade))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=sqlexpress;Initial Catalog=CJ3027414PR2;User Id=aluno;Password=aluno;"))
                {
                    conn.Open();

                    string query = @"
                INSERT INTO Entregas 
                (IdPedido, NomeCliente, Telefone, Endereco, Bairro, Cidade, StatusEntrega, DataEntrega)
                VALUES (@IdPedido, @NomeCliente, @Telefone, @Endereco, @Bairro, @Cidade, 'Pendente', GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Usa o número do pedido vindo do formulário anterior
                        cmd.Parameters.AddWithValue("@IdPedido", numeroPedido);
                        cmd.Parameters.AddWithValue("@NomeCliente", nome);
                        cmd.Parameters.AddWithValue("@Telefone", telefone);
                        cmd.Parameters.AddWithValue("@Endereco", endereco);
                        cmd.Parameters.AddWithValue("@Bairro", string.IsNullOrEmpty(bairro) ? (object)DBNull.Value : bairro);
                        cmd.Parameters.AddWithValue("@Cidade", string.IsNullOrEmpty(cidade) ? (object)DBNull.Value : cidade);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Entrega cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar entrega no banco de dados:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmEntregasCadastradas frm = new FrmEntregasCadastradas();
            frm.ShowDialog();
        }

        private void LimparCampos()
            {
                txtPedido1.Clear();
                txtNome1.Clear();
                txtTelefone.Clear();
                txtEndereco.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                cmbStatus.SelectedIndex = -1;
            }

        private void FrmEntrega_Load(object sender, EventArgs e)
        {

        }

        
    }
    }
