using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAula1
{
    public partial class ModificarDados : Form
    {
        public ModificarDados()
        {
            InitializeComponent();
        }

        private void ModificarDados_Load(object sender, EventArgs e)
        {

            txtNome.Text = UsuarioLogado.NomeCliente;
            txtCPF.Text = UsuarioLogado.Cpf;
            txtRG.Text = UsuarioLogado.RG;
            txtsenha.Text = UsuarioLogado.Senha;
            txtemail.Text = UsuarioLogado.Email;
            CBsexo.Text = UsuarioLogado.sexo;
            dtpdatadenascimento.Text = Convert.ToString(UsuarioLogado.DataNascimento);
            txtcelular.Text = UsuarioLogado.Celular;
            Complemento.Text = UsuarioLogado.Complemento;
            txtendereco.Text = UsuarioLogado.Endereço;
            txtcidade.Text = UsuarioLogado.Cidade;
            CBestados.Text = UsuarioLogado.Estado;



        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaParaAceitar.Text == UsuarioLogado.Senha)
                {

                    //Criando uma conexão
                    SqlConnection conexao =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.bancojuka"].ToString());
                    SqlDataReader leitor; //declarando uma variável do tipo leitor de dados

                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pu_alterardados";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("nomeCliente", txtNome.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("rg", txtRG.Text);
                    cmd.Parameters.AddWithValue("senha", txtsenha.Text);
                    cmd.Parameters.AddWithValue("email", txtemail.Text);
                    cmd.Parameters.AddWithValue("sexo", CBsexo.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtpdatadenascimento.Text));
                    cmd.Parameters.AddWithValue("Celular", txtcelular.Text);
                    cmd.Parameters.AddWithValue("complemento", Complemento.Text);
                    cmd.Parameters.AddWithValue("endereco", txtendereco.Text);
                    cmd.Parameters.AddWithValue("cidade", txtcidade.Text);
                    cmd.Parameters.AddWithValue("estado", CBestados.Text);


                    //abrir a conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();

                    MessageBox.Show("itens atualizados");

                }
                else
                {

                    MessageBox.Show("Senha errada");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            Classedelimpeza.LimpaForm(this);

        }
    }
}
