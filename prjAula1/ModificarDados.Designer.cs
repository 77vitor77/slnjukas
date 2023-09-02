namespace prjAula1
{
    partial class ModificarDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarDados));
            CBestados = new ComboBox();
            txtnaoimporta = new TextBox();
            dtpdatadenascimento = new DateTimePicker();
            CBsexo = new ComboBox();
            txtemail = new TextBox();
            txtcidade = new TextBox();
            txtendereco = new TextBox();
            Complemento = new TextBox();
            txtsenha = new TextBox();
            txtcelular = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtrepetirsenha = new TextBox();
            txtCPF = new TextBox();
            txtRG = new TextBox();
            txtNome = new TextBox();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            btnmodificar = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CBestados
            // 
            CBestados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBestados.FormattingEnabled = true;
            CBestados.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            CBestados.Location = new Point(502, 356);
            CBestados.Name = "CBestados";
            CBestados.Size = new Size(217, 33);
            CBestados.TabIndex = 67;
            CBestados.Text = "estados";
            // 
            // txtnaoimporta
            // 
            txtnaoimporta.Enabled = false;
            txtnaoimporta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtnaoimporta.Location = new Point(502, 122);
            txtnaoimporta.Name = "txtnaoimporta";
            txtnaoimporta.PlaceholderText = "data de nascimento";
            txtnaoimporta.Size = new Size(217, 33);
            txtnaoimporta.TabIndex = 66;
            // 
            // dtpdatadenascimento
            // 
            dtpdatadenascimento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpdatadenascimento.Location = new Point(502, 166);
            dtpdatadenascimento.Name = "dtpdatadenascimento";
            dtpdatadenascimento.Size = new Size(217, 23);
            dtpdatadenascimento.TabIndex = 65;
            // 
            // CBsexo
            // 
            CBsexo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBsexo.FormattingEnabled = true;
            CBsexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            CBsexo.Location = new Point(142, 356);
            CBsexo.Name = "CBsexo";
            CBsexo.Size = new Size(217, 33);
            CBsexo.TabIndex = 64;
            CBsexo.Text = "sexo";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.ForeColor = SystemColors.ScrollBar;
            txtemail.Location = new Point(142, 317);
            txtemail.MaxLength = 50;
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "email";
            txtemail.Size = new Size(217, 33);
            txtemail.TabIndex = 63;
            // 
            // txtcidade
            // 
            txtcidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcidade.ForeColor = SystemColors.ScrollBar;
            txtcidade.Location = new Point(502, 317);
            txtcidade.MaxLength = 50;
            txtcidade.Name = "txtcidade";
            txtcidade.PlaceholderText = "cidade";
            txtcidade.Size = new Size(217, 33);
            txtcidade.TabIndex = 62;
            // 
            // txtendereco
            // 
            txtendereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtendereco.ForeColor = SystemColors.ScrollBar;
            txtendereco.Location = new Point(502, 278);
            txtendereco.MaxLength = 100;
            txtendereco.Name = "txtendereco";
            txtendereco.PlaceholderText = "endereço";
            txtendereco.Size = new Size(217, 33);
            txtendereco.TabIndex = 61;
            // 
            // Complemento
            // 
            Complemento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Complemento.ForeColor = SystemColors.ScrollBar;
            Complemento.Location = new Point(502, 239);
            Complemento.MaxLength = 100;
            Complemento.Name = "Complemento";
            Complemento.PlaceholderText = "Complemento";
            Complemento.Size = new Size(217, 33);
            Complemento.TabIndex = 60;
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtsenha.ForeColor = SystemColors.ScrollBar;
            txtsenha.Location = new Point(142, 239);
            txtsenha.MaxLength = 6;
            txtsenha.Name = "txtsenha";
            txtsenha.PlaceholderText = "senha(6 digitos)";
            txtsenha.Size = new Size(217, 33);
            txtsenha.TabIndex = 59;
            // 
            // txtcelular
            // 
            txtcelular.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcelular.ForeColor = SystemColors.ScrollBar;
            txtcelular.Location = new Point(502, 200);
            txtcelular.MaxLength = 11;
            txtcelular.Name = "txtcelular";
            txtcelular.PlaceholderText = "Celular";
            txtcelular.Size = new Size(217, 33);
            txtcelular.TabIndex = 58;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Pink;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(427, 95);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(352, 345);
            pictureBox3.TabIndex = 57;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(594, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            // 
            // txtrepetirsenha
            // 
            txtrepetirsenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtrepetirsenha.ForeColor = SystemColors.ScrollBar;
            txtrepetirsenha.Location = new Point(142, 278);
            txtrepetirsenha.MaxLength = 6;
            txtrepetirsenha.Name = "txtrepetirsenha";
            txtrepetirsenha.PlaceholderText = "Repetir senha";
            txtrepetirsenha.Size = new Size(217, 33);
            txtrepetirsenha.TabIndex = 55;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.ForeColor = SystemColors.ScrollBar;
            txtCPF.Location = new Point(142, 161);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF";
            txtCPF.Size = new Size(217, 33);
            txtCPF.TabIndex = 54;
            // 
            // txtRG
            // 
            txtRG.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRG.ForeColor = SystemColors.ScrollBar;
            txtRG.Location = new Point(142, 200);
            txtRG.MaxLength = 9;
            txtRG.Name = "txtRG";
            txtRG.PlaceholderText = "RG";
            txtRG.Size = new Size(217, 33);
            txtRG.TabIndex = 53;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.ScrollBar;
            txtNome.Location = new Point(142, 122);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(217, 33);
            txtNome.TabIndex = 52;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Pink;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(69, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 345);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Agency FB", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.HotPink;
            lblLogin.Location = new Point(69, 42);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(313, 45);
            lblLogin.TabIndex = 68;
            lblLogin.Text = "MODIFICAR INFORMAÇÕES";
            // 
            // btnmodificar
            // 
            btnmodificar.BackColor = Color.DeepPink;
            btnmodificar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnmodificar.ForeColor = Color.White;
            btnmodificar.Location = new Point(69, 446);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(222, 43);
            btnmodificar.TabIndex = 71;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = false;
            btnmodificar.Click += btnmodificar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DeepPink;
            btnLimpar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(69, 494);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(222, 43);
            btnLimpar.TabIndex = 72;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // ModificarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(843, 549);
            Controls.Add(btnLimpar);
            Controls.Add(btnmodificar);
            Controls.Add(lblLogin);
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
            Controls.Add(txtrepetirsenha);
            Controls.Add(txtCPF);
            Controls.Add(txtRG);
            Controls.Add(txtNome);
            Controls.Add(pictureBox1);
            Name = "ModificarDados";
            Text = "ModificarDados";
            Load += ModificarDados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBestados;
        private TextBox txtnaoimporta;
        private DateTimePicker dtpdatadenascimento;
        private ComboBox CBsexo;
        private TextBox txtemail;
        private TextBox txtcidade;
        private TextBox txtendereco;
        private TextBox Complemento;
        private TextBox txtsenha;
        private TextBox txtcelular;
        private PictureBox pictureBox3;
        internal protected PictureBox pictureBox2;
        private TextBox txtrepetirsenha;
        private TextBox txtCPF;
        private TextBox txtRG;
        private TextBox txtNome;
        private PictureBox pictureBox1;
        private Label lblLogin;
        private Button btnmodificar;
        private Button btnLimpar;
    }
}