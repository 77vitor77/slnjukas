namespace prjAula1
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            txtNome = new TextBox();
            txtRG = new TextBox();
            txtCPF = new TextBox();
            txtrepetirsenha = new TextBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            txtcidade = new TextBox();
            txtendereco = new TextBox();
            Complemento = new TextBox();
            txtsenha = new TextBox();
            txtcelular = new TextBox();
            pictureBox3 = new PictureBox();
            txtemail = new TextBox();
            CBsexo = new ComboBox();
            dtpdatadenascimento = new DateTimePicker();
            txtnaoimporta = new TextBox();
            CBestados = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Pink;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(1, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 345);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Agency FB", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.HotPink;
            lblLogin.Location = new Point(12, 22);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(156, 45);
            lblLogin.TabIndex = 16;
            lblLogin.Text = "CADASTRAR";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.ScrollBar;
            txtNome.Location = new Point(74, 116);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(217, 33);
            txtNome.TabIndex = 17;
            // 
            // txtRG
            // 
            txtRG.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRG.ForeColor = SystemColors.ScrollBar;
            txtRG.Location = new Point(74, 194);
            txtRG.MaxLength = 9;
            txtRG.Name = "txtRG";
            txtRG.PlaceholderText = "RG";
            txtRG.Size = new Size(217, 33);
            txtRG.TabIndex = 19;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.ForeColor = SystemColors.ScrollBar;
            txtCPF.Location = new Point(74, 155);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF";
            txtCPF.Size = new Size(217, 33);
            txtCPF.TabIndex = 22;
            // 
            // txtrepetirsenha
            // 
            txtrepetirsenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtrepetirsenha.ForeColor = SystemColors.ScrollBar;
            txtrepetirsenha.Location = new Point(74, 272);
            txtrepetirsenha.MaxLength = 6;
            txtrepetirsenha.Name = "txtrepetirsenha";
            txtrepetirsenha.PlaceholderText = "Repetir senha";
            txtrepetirsenha.Size = new Size(217, 33);
            txtrepetirsenha.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepPink;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(251, 440);
            button2.Name = "button2";
            button2.Size = new Size(222, 43);
            button2.TabIndex = 30;
            button2.Text = "Criar cadastro ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(526, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // txtcidade
            // 
            txtcidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcidade.ForeColor = SystemColors.ScrollBar;
            txtcidade.Location = new Point(434, 311);
            txtcidade.MaxLength = 50;
            txtcidade.Name = "txtcidade";
            txtcidade.PlaceholderText = "cidade";
            txtcidade.Size = new Size(217, 33);
            txtcidade.TabIndex = 44;
            txtcidade.TextChanged += textBox1_TextChanged;
            // 
            // txtendereco
            // 
            txtendereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtendereco.ForeColor = SystemColors.ScrollBar;
            txtendereco.Location = new Point(434, 272);
            txtendereco.MaxLength = 100;
            txtendereco.Name = "txtendereco";
            txtendereco.PlaceholderText = "endereço";
            txtendereco.Size = new Size(217, 33);
            txtendereco.TabIndex = 43;
            // 
            // Complemento
            // 
            Complemento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Complemento.ForeColor = SystemColors.ScrollBar;
            Complemento.Location = new Point(434, 233);
            Complemento.MaxLength = 100;
            Complemento.Name = "Complemento";
            Complemento.PlaceholderText = "Complemento";
            Complemento.Size = new Size(217, 33);
            Complemento.TabIndex = 42;
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtsenha.ForeColor = SystemColors.ScrollBar;
            txtsenha.Location = new Point(74, 233);
            txtsenha.MaxLength = 6;
            txtsenha.Name = "txtsenha";
            txtsenha.PlaceholderText = "senha(6 digitos)";
            txtsenha.Size = new Size(217, 33);
            txtsenha.TabIndex = 41;
            // 
            // txtcelular
            // 
            txtcelular.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcelular.ForeColor = SystemColors.ScrollBar;
            txtcelular.Location = new Point(434, 194);
            txtcelular.MaxLength = 11;
            txtcelular.Name = "txtcelular";
            txtcelular.PlaceholderText = "Celular";
            txtcelular.Size = new Size(217, 33);
            txtcelular.TabIndex = 40;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Pink;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(359, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(352, 345);
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.ForeColor = SystemColors.ScrollBar;
            txtemail.Location = new Point(74, 311);
            txtemail.MaxLength = 50;
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "email";
            txtemail.Size = new Size(217, 33);
            txtemail.TabIndex = 46;
            // 
            // CBsexo
            // 
            CBsexo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBsexo.FormattingEnabled = true;
            CBsexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            CBsexo.Location = new Point(74, 350);
            CBsexo.Name = "CBsexo";
            CBsexo.Size = new Size(217, 33);
            CBsexo.TabIndex = 47;
            CBsexo.Text = "sexo";
            // 
            // dtpdatadenascimento
            // 
            dtpdatadenascimento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpdatadenascimento.Location = new Point(434, 160);
            dtpdatadenascimento.Name = "dtpdatadenascimento";
            dtpdatadenascimento.Size = new Size(217, 23);
            dtpdatadenascimento.TabIndex = 48;
            // 
            // txtnaoimporta
            // 
            txtnaoimporta.Enabled = false;
            txtnaoimporta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtnaoimporta.Location = new Point(434, 116);
            txtnaoimporta.Name = "txtnaoimporta";
            txtnaoimporta.PlaceholderText = "data de nascimento";
            txtnaoimporta.Size = new Size(217, 33);
            txtnaoimporta.TabIndex = 49;
            // 
            // CBestados
            // 
            CBestados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBestados.FormattingEnabled = true;
            CBestados.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            CBestados.Location = new Point(434, 350);
            CBestados.Name = "CBestados";
            CBestados.Size = new Size(217, 33);
            CBestados.TabIndex = 50;
            CBestados.Text = "estados";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(725, 538);
            Controls.Add(CBestados);
            Controls.Add(txtnaoimporta);
            Controls.Add(dtpdatadenascimento);
            Controls.Add(CBsexo);
            Controls.Add(txtemail);
            Controls.Add(txtcidade);
            Controls.Add(txtendereco);
            Controls.Add(Complemento);
            Controls.Add(txtsenha);
            Controls.Add(txtcelular);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(txtrepetirsenha);
            Controls.Add(txtCPF);
            Controls.Add(txtRG);
            Controls.Add(txtNome);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "Cadastro";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private TextBox txtNome;
        private TextBox txtRG;
        private TextBox txtCPF;
        private TextBox txtrepetirsenha;
        private Button button2;
        internal protected PictureBox pictureBox2;
        private TextBox txtcidade;
        private TextBox txtendereco;
        private TextBox Complemento;
        private TextBox txtsenha;
        private TextBox txtcelular;
        private PictureBox pictureBox3;
        private TextBox txtemail;
        private ComboBox CBsexo;
        private DateTimePicker dtpdatadenascimento;
        private TextBox txtnaoimporta;
        private ComboBox CBestados;
    }
}