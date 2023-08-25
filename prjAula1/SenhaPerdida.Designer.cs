namespace prjAula1
{
    partial class SenhaPerdida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenhaPerdida));
            txtconfCPF = new TextBox();
            txtnovasenha = new TextBox();
            txtconfnovasenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtconfCPF
            // 
            txtconfCPF.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtconfCPF.Location = new Point(44, 136);
            txtconfCPF.Name = "txtconfCPF";
            txtconfCPF.Size = new Size(272, 35);
            txtconfCPF.TabIndex = 0;
            // 
            // txtnovasenha
            // 
            txtnovasenha.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtnovasenha.Location = new Point(44, 216);
            txtnovasenha.Name = "txtnovasenha";
            txtnovasenha.Size = new Size(272, 35);
            txtnovasenha.TabIndex = 1;
            // 
            // txtconfnovasenha
            // 
            txtconfnovasenha.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtconfnovasenha.Location = new Point(44, 291);
            txtconfnovasenha.Name = "txtconfnovasenha";
            txtconfnovasenha.Size = new Size(272, 35);
            txtconfnovasenha.TabIndex = 2;
            txtconfnovasenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 103);
            label1.Name = "label1";
            label1.Size = new Size(48, 30);
            label1.TabIndex = 3;
            label1.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 183);
            label2.Name = "label2";
            label2.Size = new Size(216, 30);
            label2.TabIndex = 4;
            label2.Text = "coloque a nova senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 258);
            label3.Name = "label3";
            label3.Size = new Size(224, 30);
            label3.TabIndex = 5;
            label3.Text = "confirme a nova senha";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(91, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // SenhaPerdida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__2_;
            ClientSize = new Size(361, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtconfnovasenha);
            Controls.Add(txtnovasenha);
            Controls.Add(txtconfCPF);
            Name = "SenhaPerdida";
            Text = "SenhaPerdida";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtconfCPF;
        private TextBox txtnovasenha;
        private TextBox txtconfnovasenha;
        private Label label1;
        private Label label2;
        private Label label3;
        internal protected PictureBox pictureBox2;
    }
}