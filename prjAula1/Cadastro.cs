using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAula1
{
    public partial class Cadastro : Form
    {
        public string Nome { get; set; }



        public Cadastro()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtsenha.Text == txtrepetirsenha.Text)
                {
                    //Criando uma conexão
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.bancojuka"].ToString());



                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();



                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_Cliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;



                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("nomeCliente", txtNome.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("rg", txtRG.Text);
                    cmd.Parameters.AddWithValue("senha", txtsenha.Text);
                    cmd.Parameters.AddWithValue("email", txtemail.Text);
                    cmd.Parameters.AddWithValue("sexo", CBsexo.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtpdatadenascimento.Text));
                    cmd.Parameters.AddWithValue("Celular", txtcelular.Text);
                    cmd.Parameters.AddWithValue("complemento", Complemento.Text);
                    cmd.Parameters.AddWithValue("endereço", txtendereco.Text);
                    cmd.Parameters.AddWithValue("cidade", txtcidade.Text);
                    cmd.Parameters.AddWithValue("estado", CBestados.Text);



                    //abrir a conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Cliente cadastrado com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
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



        class Cliente : Cadastro
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}




