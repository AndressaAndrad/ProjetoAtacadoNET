using Atacado.POCO.RH;
using Atacado.Service.RH;

namespace AtacadoWinApp
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void OiMundoBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Oi Mundo!!!");
            //MessageBox.Show("Oi Mundo!!!", "Mensagem");,
            //MessageBox.Show("Oi Mundo!!!", "Mensagem", MessageBoxButtons.OK);
            MessageBox.Show("Oi Mundo!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void FecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidarBtn_Click(object sender, EventArgs e)
        {
            FuncionarioPOCO poco = new FuncionarioPOCO()
            {
                Cpf = CpfTxt.Text
            };

            FuncionarioService srv = new FuncionarioService();
            if (srv.Validar(poco) == false)
            {
                string mensagem = srv.MensagensDeErro.Aggregate((x, y) => x + ";" + y);
                MessageBox.Show(mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                string mensagem = "CPF Válido.";
                MessageBox.Show(mensagem, "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            return;
        }
    }
}