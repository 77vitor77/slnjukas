using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using System.Runtime.InteropServices;


namespace prjAula1
{
    public partial class Form1 : Form
    {
        public Form1()
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
            var telamenu = new Form3();
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

            try
            {

                //Criando uma conexão
                SqlConnection conexao =
                new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.bancojuka"].ToString());
                SqlDataReader leitor; //declarando uma variável do tipo leitor de dados

                //Criando um comando
                SqlCommand cmd = new SqlCommand();

                //criando texto do comando, tipo e conexão que será usada
                cmd.CommandText = "psValidaLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //passando os parâmetros necessários
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("logindecliente", txtcpf.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                conexao.Open(); //abrindo a conexão

                leitor = cmd.ExecuteReader();
                //igualando o leitor ao resultado trazido do BD

                if (leitor.HasRows) //se o leitor encontrar linhas de dados
                {

                    leitor.Read();
                    
                    UsuarioLogado.Id = leitor.GetInt32(0);
                    UsuarioLogado.NomeCliente = leitor.GetString(1);
                    UsuarioLogado.Cpf = leitor.GetString(2);
                    UsuarioLogado.RG = leitor.GetString(3);
                    UsuarioLogado.Senha = leitor.GetInt32(4);
                    UsuarioLogado.DataNascimento = leitor.GetDateTime(5);
                    UsuarioLogado.Email = leitor.GetString(6);
                    UsuarioLogado.sexo = leitor.GetString(7);
                    UsuarioLogado.Celular = leitor.GetString(8);
                    UsuarioLogado.Endereço = leitor.GetString(9);
                    if (!leitor.IsDBNull(10))

                    {

                        UsuarioLogado.Complemento = leitor.GetString(10);

                    }
                    UsuarioLogado.Cidade = leitor.GetString(10);
                    UsuarioLogado.Estado = leitor.GetString(11);



                    //fechando leitor
                    leitor.Close();
              
                }
            }
            catch (Exception ex) 
            { 
            
            

            }

        }
    }
}