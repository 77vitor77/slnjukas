namespace prjAula1
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            criarContaToolStripMenuItem = new ToolStripMenuItem();
            mudarDeContaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            modificaçãoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            saquetranferenciadepositoToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem1 = new ToolStripMenuItem();
            cadastroToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripTextBox3 = new ToolStripTextBox();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripTextBox1, toolStripTextBox2, toolStripTextBox3 });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1381, 27);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            menu.ItemClicked += menu_ItemClicked;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 23);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { criarContaToolStripMenuItem, mudarDeContaToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(138, 23);
            toolStripMenuItem2.Text = "configuração da conta";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // criarContaToolStripMenuItem
            // 
            criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            criarContaToolStripMenuItem.Size = new Size(158, 22);
            criarContaToolStripMenuItem.Text = "Criar Conta";
            criarContaToolStripMenuItem.Click += criarContaToolStripMenuItem_Click;
            // 
            // mudarDeContaToolStripMenuItem
            // 
            mudarDeContaToolStripMenuItem.Name = "mudarDeContaToolStripMenuItem";
            mudarDeContaToolStripMenuItem.Size = new Size(158, 22);
            mudarDeContaToolStripMenuItem.Text = "Mudar de conta";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { modificaçãoDeDadosToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(164, 23);
            toolStripMenuItem3.Text = "configuração de correntista";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // modificaçãoDeDadosToolStripMenuItem
            // 
            modificaçãoDeDadosToolStripMenuItem.Name = "modificaçãoDeDadosToolStripMenuItem";
            modificaçãoDeDadosToolStripMenuItem.Size = new Size(191, 22);
            modificaçãoDeDadosToolStripMenuItem.Text = "Modificação de dados";
            modificaçãoDeDadosToolStripMenuItem.Click += modificaçãoDeDadosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { saquetranferenciadepositoToolStripMenuItem, menuToolStripMenuItem1, cadastroToolStripMenuItem1 });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(43, 23);
            toolStripMenuItem4.Text = "telas";
            // 
            // saquetranferenciadepositoToolStripMenuItem
            // 
            saquetranferenciadepositoToolStripMenuItem.Name = "saquetranferenciadepositoToolStripMenuItem";
            saquetranferenciadepositoToolStripMenuItem.Size = new Size(230, 22);
            saquetranferenciadepositoToolStripMenuItem.Text = "Saque/transferencia/deposito";
            saquetranferenciadepositoToolStripMenuItem.Click += saquetranferenciadepositoToolStripMenuItem_Click;
            // 
            // menuToolStripMenuItem1
            // 
            menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            menuToolStripMenuItem1.Size = new Size(230, 22);
            menuToolStripMenuItem1.Text = "Menu";
            menuToolStripMenuItem1.Click += menuToolStripMenuItem1_Click;
            // 
            // cadastroToolStripMenuItem1
            // 
            cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            cadastroToolStripMenuItem1.Size = new Size(230, 22);
            cadastroToolStripMenuItem1.Text = "Cadastro";
            cadastroToolStripMenuItem1.Click += cadastroToolStripMenuItem1_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Enabled = false;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Visible = false;
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Enabled = false;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
            toolStripTextBox2.Text = "conta";
            toolStripTextBox2.Visible = false;
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.Enabled = false;
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(100, 23);
            toolStripTextBox3.Visible = false;
            toolStripTextBox3.Click += toolStripTextBox3_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 601);
            Controls.Add(menu);
            IsMdiContainer = true;
            MainMenuStrip = menu;
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem criarContaToolStripMenuItem;
        private ToolStripMenuItem mudarDeContaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem modificaçãoDeDadosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem saquetranferenciadepositoToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem1;
        private ToolStripMenuItem cadastroToolStripMenuItem1;
    }
}