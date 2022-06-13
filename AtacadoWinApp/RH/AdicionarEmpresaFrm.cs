using Atacado.POCO.RH;
using Atacado.Service.RH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtacadoWinApp.RH
{
    public partial class AdicionarEmpresaFrm : Form
    {
        public AdicionarEmpresaFrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FecharBtn_Click(object sender, EventArgs e)
        {
            
                this.Close();
            
        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            EmpresaPOCO poco = new EmpresaPOCO()
            {
                Cnpj = CnpjTxt.Text,
                InscricaoEstadual = InscricaoEstadualTxt.Text,
                Email = EmailTxt.Text,
                RazaoSocial = RazaoSocialTxt.Text,
                NomeFantasia = NomeFantasiaTxt.Text,
                Telefone = TelefoneTxt.Text,
                Endereco = EnderecoTxt.Text

            };

            EmpresaService srv = new EmpresaService();
            if (srv.Validar(poco) == false)
            {
                string mensagem = srv.MensagensDeErro.Aggregate((x, y) => x + ";\n" + y);
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mensagem = "Cadastro Realizado com Sucesso!!!.";
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
    }
}
