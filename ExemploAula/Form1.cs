namespace ExemploAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "admin" && txtsenha.Text == "123456")
            {
                MessageBox.Show("Login realizado com sucesso");
                txtusuario.Clear();
                txtsenha.Clear();

                txtusuario.Focus();
;

            }
            else
            {
                MessageBox.Show("O usu�rio ou a senha est�o incorretos");
                txtusuario.Clear(); 
                txtsenha.Clear();
                txtusuario.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
