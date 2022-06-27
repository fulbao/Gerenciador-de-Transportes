using Gerenciador_de_Transportes.Telas.Utilitarias;
using System;
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

        private void limpar()
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
                ModalAlerta modal = new ModalAlerta("Atenção!", "Algum campo não foi preenchido!");
                modal.ShowDialog();
            }
            else
            {
                if (tb_CarretaSegunda.Text == "")
                {
                    tb_CarretaSegunda.Text = "-";
                }
                if (tb_Carreta.Text == "")
                {
                    tb_Carreta.Text = "-";
                }
                retorno = BancoVeiculo.adicionarVeiculos(tb_placaCavalo.Text, tb_Carreta.Text, tb_CarretaSegunda.Text, tb_Proprietario.Text, tb_Motorista.Text, usuarioLogado);

                if (!retorno)
                {
                    ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal.ShowDialog();
                }
                else
                {
                    ModalSucesso modal = new ModalSucesso("Sucesso!", "Dados cadastrador com sucesso!");
                    modal.ShowDialog();
                    limpar();
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
