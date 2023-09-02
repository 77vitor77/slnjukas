using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjAula1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro janelaCadastro = new Cadastro();
            janelaCadastro.MdiParent = this;
            janelaCadastro.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 janelaMenu = new Form2();
            janelaMenu.MdiParent = this;
            janelaMenu.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.menu.Items[0].Text == "Login")
            {
                Telalogin telaLogin = new Telalogin();
                telaLogin.MdiParent = this;
                telaLogin.Show();
            }
            else
            {
                menu.Items[0].Text = "Login";
                menu.Items[1].Visible = false;
                menu.Items[2].Visible = false;
                menu.Items[3].Visible = false;
                menu.Items[4].Visible = false;
                menu.Items[4].Text = String.Empty;
                menu.Items[5].Visible = false;
                menu.Items[6].Visible = false;
                menu.Items[6].Text = String.Empty;
                UsuarioLogado.Deslogar();
            }
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 janelaTransferencia = new Form5();
            janelaTransferencia.MdiParent = this;
            janelaTransferencia.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

            ModificarDados janelaModificaçãoDeDados = new ModificarDados();
            janelaModificaçãoDeDados.MdiParent = this;
            janelaModificaçãoDeDados.Show();

        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
