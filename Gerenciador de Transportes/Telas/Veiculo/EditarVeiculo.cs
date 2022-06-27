using Gerenciador_de_Transportes.Telas.Utilitarias;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class EditarVeiculos : Form
    {
        string placaCavalo, placaCarreta, placaCarretaSegunda, proprietario, motorista, usuarioLogado;

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

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            Boolean retorno = BancoVeiculo.alterarItemVeiculos(tb_placaCavalo.Text, tb_Carreta.Text, tb_CarretaSegunda.Text, tb_Proprietario.Text, tb_Motorista.Text, placaCavalo, placaCarreta, placaCarretaSegunda, proprietario, motorista, usuarioLogado);
            if (!retorno)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public EditarVeiculos(string placaCavalo, string placaCarreta, string placaCarretaSegunda, string proprietario, string motorista, string usuario)
        {
            InitializeComponent();
            tb_placaCavalo.Text = placaCavalo;
            tb_Carreta.Text = placaCarreta;
            tb_CarretaSegunda.Text = placaCarretaSegunda;
            tb_Motorista.Text = motorista;
            tb_Proprietario.Text = proprietario;
            this.placaCavalo = placaCavalo;
            this.placaCarreta = placaCarreta;
            this.placaCarretaSegunda = placaCarretaSegunda;
            this.proprietario = proprietario;
            this.motorista = motorista;
            usuarioLogado = usuario;
        }
    }
}
