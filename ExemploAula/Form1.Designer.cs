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
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Location = new Point(135, 41);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(42, 15);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "LOGIN";
            lbllogin.TextAlign = ContentAlignment.TopCenter;
            lbllogin.Click += lbllogin_Click;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(62, 127);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(50, 15);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuário:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
    }
}
