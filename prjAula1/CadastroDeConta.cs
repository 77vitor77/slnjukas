using DTO;
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
    public partial class CadastroDeConta : Form
    {
        public CadastroDeConta()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsenha.Text == txtrepetirsenha.Text)
                {
                    Conta conta = new Conta();
                    conta.IdCliente = UsuarioLogado.IdCliente;
                    conta.DataAbertura = DateTime.Now;
                    conta.Saldo = Convert.ToDecimal(txtprimeirodeposito.Text);
                    conta.StatusConta = "aberto";
                    conta.tipoConta = CBtipodeconta.Text;
                    conta.Senhadaconta = txtsenha.Text;



                    //Criando uma conexão
                    SqlConnection conexao =
                          new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.bancojuka"].ToString());


                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();



                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_conta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;



                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("Diadeabertura", conta.DataAbertura);
                    cmd.Parameters.AddWithValue("saldo", conta.Saldo);
                    cmd.Parameters.AddWithValue("tipoConta", conta.tipoConta);
                    cmd.Parameters.AddWithValue("statusConta",conta.StatusConta);
                    cmd.Parameters.AddWithValue("senhadaconta", conta.Senhadaconta);



                    //abrir a conexão
                    conexao.Open();



                    //executa o comando no BD e captura o retorno devolvido pelo procedimento
                    conta.IdCliente = Convert.ToInt32(cmd.ExecuteScalar());



                    MessageBox.Show(conta.IdCliente.ToString());



                    conexao.Close();
                    MessageBox.Show("Conta criada com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                    UsuarioLogado.Contas.Add(conta);



                    Classedelimpeza.LimpaForm(this);



                }
                else
                {
                    throw new Exception("Os campos de senha não coincidem!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

