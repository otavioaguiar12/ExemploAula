namespace ExemploAula
{
    partial class Form2
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
            lblmenu = new Label();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lblmenu
            // 
            lblmenu.AutoSize = true;
            lblmenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmenu.Location = new Point(280, 76);
            lblmenu.Name = "lblmenu";
            lblmenu.Size = new Size(259, 25);
            lblmenu.TabIndex = 0;
            lblmenu.Text = "SEJA BEM VINDO AO MENU";
            lblmenu.Click += lblmenu_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(49, 167);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(81, 65);
            btnvoltar.TabIndex = 1;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnvoltar);
            Controls.Add(lblmenu);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmenu;
        private Button btnvoltar;
    }
}