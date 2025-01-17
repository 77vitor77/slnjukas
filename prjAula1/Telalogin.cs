using DTO;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using System.Runtime.InteropServices;


namespace prjAula1
{
    public partial class Telalogin : Form
    {
        public Telalogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var menu = new SenhaPerdida();
            menu.Show();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro telamenu = new Cadastro();
            this.Hide();
            telamenu.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //try
            //{

            //Criando uma conex�o
            SqlConnection conexao =
            new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.bancojuka"].ToString());
            SqlDataReader leitor; //declarando uma vari�vel do tipo leitor de dados

            //Criando um comando
            SqlCommand cmd = new SqlCommand();

            //criando texto do comando, tipo e conex�o que ser� usada
            cmd.CommandText = "ps_ValidarLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            //passando os par�metros necess�rios
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("cpf", txtcpf.Text);
            cmd.Parameters.AddWithValue("senha", txtSenha.Text);

            conexao.Open(); //abrindo a conex�o

            leitor = cmd.ExecuteReader();
            //igualando o leitor ao resultado trazido do BD

            if (leitor.HasRows) //se o leitor encontrar linhas de dados
            {

                leitor.Read();

                UsuarioLogado.IdCliente = leitor.GetInt32(0);
                UsuarioLogado.NomeCliente = leitor.GetString(1);
                UsuarioLogado.Cpf = leitor.GetString(2);
                UsuarioLogado.RG = leitor.GetString(3);
                UsuarioLogado.Senha = leitor.GetString(4);
                UsuarioLogado.DataNascimento = leitor.GetDateTime(5);
                UsuarioLogado.Email = leitor.GetString(6);
                UsuarioLogado.sexo = leitor.GetString(7);
                UsuarioLogado.Celular = leitor.GetString(8);
                if (!leitor.IsDBNull(10))
                {

                    UsuarioLogado.Complemento = leitor.GetString(10);

                }
                UsuarioLogado.Endere�o = leitor.GetString(9);
                UsuarioLogado.Cidade = leitor.GetString(10);
                UsuarioLogado.Estado = leitor.GetString(11);

                //fechando leitor
                leitor.Close();

                //criando texto do comando, tipo e conex�o que ser� usada
                cmd.CommandText = "ps_buscaContasPorIdCorrentista_48";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;



                //passando os par�metros necess�rios
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);



                //ler novamente o leitor
                leitor = cmd.ExecuteReader();

                //verificar se h� linhas retornadas do leitor
                if (leitor.HasRows)
                {
                    //repete a leitura e enquanto h� linhas segue na estrutura
                    //de repeti��o
                    while (leitor.Read())
                    {
                        //cria uma conta na mem�ria
                        Conta conta = new Conta();
                        //passa os dados do leitor para a conta na mem�ria - objeto conta
                        conta.IdConta = leitor.GetInt32(0);
                        conta.IdCliente = leitor.GetInt32(1);
                        conta.Senhadaconta = leitor.GetString(2);
                        conta.DataAbertura = leitor.GetDateTime(3);
                        conta.Saldo = leitor.GetDecimal(4);
                        conta.StatusConta = leitor.GetString(5);
                        



                        //adiciona a conta rec�m criada na mem�ria para a colection de contas
                        UsuarioLogado.Contas.Add(conta);
                    }
                    MessageBox.Show($"Ol�,{UsuarioLogado.NomeCliente}!\n" +
                   $"Voc� foi logado na conta {UsuarioLogado.Contas[0].IdConta.ToString()}\n" +
                   $"Para trocar de conta, utilize o menu Conta\\Alternar Conta");
                }
               
                leitor.Close(); //fecha leitor
                conexao.Close(); //fecha conexao com BD

                Form telaPrincipal = Application.OpenForms["Form6"];
                //acessando o formul�rio aberto atrav�s da vari�vel janelaPrincipal
                MenuStrip menuPrincipal = (MenuStrip)telaPrincipal.Controls[0];
                menuPrincipal.Items[0].Text = "Logout";
                menuPrincipal.Items[1].Visible = false;
                menuPrincipal.Items[2].Visible = true;
                menuPrincipal.Items[3].Visible = true;
                menuPrincipal.Items[4].Visible = true;


               
                //MessageBox.Show($"{CorrentistaLogado.Id.ToString()},{CorrentistaLogado.NomeCorrentista},{CorrentistaLogado.DataNascimento.ToString()},{CorrentistaLogado.Logradouro}," +
                //    $"{CorrentistaLogado.Numero},{CorrentistaLogado.Complemento},{CorrentistaLogado.Cidade}," +
                //    $"{CorrentistaLogado.Estado},{CorrentistaLogado.Cpf},{CorrentistaLogado.Senha},{CorrentistaLogado.Celular}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usu�rio ou senha incorretos!");
            }
            //}
            //catch (Exception ex) 
            //{

            //    MessageBox.Show("errado lixo");

            //}

        }
    }
}