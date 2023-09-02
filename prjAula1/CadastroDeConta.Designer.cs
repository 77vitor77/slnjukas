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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(179, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 33);
            textBox1.TabIndex = 41;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(179, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 33);
            textBox2.TabIndex = 42;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(179, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 33);
            textBox3.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(179, 119);
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
            label2.Location = new Point(179, 208);
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
            label3.Location = new Point(179, 300);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 46;
            label3.Text = "repetir senha";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(179, 381);
            button1.Name = "button1";
            button1.Size = new Size(177, 41);
            button1.TabIndex = 47;
            button1.Text = "criar conta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CdastroDeConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(539, 546);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "CdastroDeConta";
            Text = "Conta";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal protected PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}