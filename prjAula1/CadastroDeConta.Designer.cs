namespace prjAula1
{
    partial class CadastroDeConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeConta));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtprimeirodeposito = new TextBox();
            txtsenha = new TextBox();
            txtrepetirsenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            CBtipodeconta = new ComboBox();
            lblTipoDeConta = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(179, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Pink;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(114, 87);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(301, 381);
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // txtprimeirodeposito
            // 
            txtprimeirodeposito.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtprimeirodeposito.Location = new Point(179, 127);
            txtprimeirodeposito.Name = "txtprimeirodeposito";
            txtprimeirodeposito.Size = new Size(177, 33);
            txtprimeirodeposito.TabIndex = 41;
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtsenha.Location = new Point(179, 255);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(177, 33);
            txtsenha.TabIndex = 42;
            // 
            // txtrepetirsenha
            // 
            txtrepetirsenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtrepetirsenha.Location = new Point(179, 319);
            txtrepetirsenha.Name = "txtrepetirsenha";
            txtrepetirsenha.Size = new Size(177, 33);
            txtrepetirsenha.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(179, 99);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 44;
            label1.Text = "primeiro deposito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 227);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 45;
            label2.Text = "senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(179, 291);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 46;
            label3.Text = "repetir senha";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(179, 384);
            button1.Name = "button1";
            button1.Size = new Size(177, 41);
            button1.TabIndex = 47;
            button1.Text = "criar conta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CBtipodeconta
            // 
            CBtipodeconta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBtipodeconta.FormattingEnabled = true;
            CBtipodeconta.Items.AddRange(new object[] { "Corrente", "Poupança" });
            CBtipodeconta.Location = new Point(179, 191);
            CBtipodeconta.Name = "CBtipodeconta";
            CBtipodeconta.Size = new Size(177, 33);
            CBtipodeconta.TabIndex = 48;
            // 
            // lblTipoDeConta
            // 
            lblTipoDeConta.AutoSize = true;
            lblTipoDeConta.BackColor = Color.Transparent;
            lblTipoDeConta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoDeConta.Location = new Point(179, 163);
            lblTipoDeConta.Name = "lblTipoDeConta";
            lblTipoDeConta.Size = new Size(127, 25);
            lblTipoDeConta.TabIndex = 49;
            lblTipoDeConta.Text = "Tipo de conta";
            // 
            // CadastroDeConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(539, 546);
            Controls.Add(lblTipoDeConta);
            Controls.Add(CBtipodeconta);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtrepetirsenha);
            Controls.Add(txtsenha);
            Controls.Add(txtprimeirodeposito);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "CadastroDeConta";
            Text = "Conta";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal protected PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtprimeirodeposito;
        private TextBox txtsenha;
        private TextBox txtrepetirsenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ComboBox CBtipodeconta;
        private Label lblTipoDeConta;
    }
}