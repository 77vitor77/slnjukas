using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            Classedelimpeza.LimpaForm(this);

        }
    }
}
