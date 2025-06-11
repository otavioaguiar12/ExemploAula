namespace ExemploAula
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbllogin = new Label();
            lblusuario = new Label();
            txtusuario = new TextBox();
            lblsenha = new Label();
            txtsenha = new TextBox();
            btnlogar = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbllogin.Location = new Point(135, 56);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(99, 37);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "LOGIN";
            lbllogin.TextAlign = ContentAlignment.TopCenter;
            lbllogin.Click += lbllogin_Click;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblusuario.Location = new Point(71, 144);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(64, 19);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuário:";
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtusuario.Location = new Point(135, 141);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(154, 25);
            txtusuario.TabIndex = 2;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblsenha.Location = new Point(71, 188);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(53, 19);
            lblsenha.TabIndex = 3;
            lblsenha.Text = "Senha:";
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtsenha.Location = new Point(135, 185);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(154, 25);
            txtsenha.TabIndex = 4;
            txtsenha.TextChanged += textBox1_TextChanged;
            // 
            // btnlogar
            // 
            btnlogar.Cursor = Cursors.Hand;
            btnlogar.Location = new Point(135, 241);
            btnlogar.Name = "btnlogar";
            btnlogar.Size = new Size(100, 30);
            btnlogar.TabIndex = 5;
            btnlogar.Text = "Logar";
            btnlogar.UseVisualStyleBackColor = true;
            btnlogar.Click += btnlogar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 308);
            Controls.Add(btnlogar);
            Controls.Add(txtsenha);
            Controls.Add(lblsenha);
            Controls.Add(txtusuario);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private TextBox txtusuario;
        private Label lblsenha;
        private TextBox txtsenha;
        private Button btnlogar;
    }
}
