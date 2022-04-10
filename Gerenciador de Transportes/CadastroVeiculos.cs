using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class CadastroVeiculos : Form
    {
        string usuarioLogado;
        public CadastroVeiculos(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void limpar ()
        {
            tb_placaCavalo.Clear();
            tb_Carreta.Clear();
            tb_CarretaSegunda.Clear();
            tb_Proprietario.Clear();
            tb_Motorista.Clear();
            tb_placaCavalo.Focus();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Boolean retorno;
            if ((tb_placaCavalo.Text == "") || (tb_Motorista.Text == "") || (tb_Proprietario.Text == ""))
            {
                MessageBox.Show("Algum campo não foi preenchido!");
            } else
            {
                if (tb_CarretaSegunda.Text == "")
                {
                    tb_CarretaSegunda.Text = "-";
                }
                if (tb_Carreta.Text == "")
                {
                    tb_Carreta.Text = "-";
                }
                retorno = BancoDeDados.adicionarVeiculos(tb_placaCavalo.Text, tb_Carreta.Text, tb_CarretaSegunda.Text, tb_Proprietario.Text, tb_Motorista.Text, usuarioLogado);

                if(!retorno)
                {
                    MessageBox.Show("Ocorreu um problema!\nContate o desenvolvedor");
                } else
                {
                    limpar();
                }
            }
        }

        private void CadastroVeiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
