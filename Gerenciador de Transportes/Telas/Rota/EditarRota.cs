using Gerenciador_de_Transportes.Telas.Utilitarias;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class EditarRota : Form
    {
        string rota, cidadeOrigem, estadoOrigem, cidadeDestino, estadoDestino, usuarioLogado;

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

        public EditarRota(string rota, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino, string usuario)
        {
            InitializeComponent();
            tb_Rota.Text = rota;
            tb_cidadeOrigen.Text = cidadeOrigem;
            sl_EstadoOrigem.Text = estadoOrigem;
            tb_cidadeDestino.Text = cidadeDestino;
            sl_EstadoDestino.Text = estadoDestino;
            this.rota = rota;
            this.cidadeOrigem = cidadeOrigem;
            this.estadoOrigem = estadoOrigem;
            this.cidadeDestino = cidadeDestino;
            this.estadoDestino = estadoDestino;
            usuarioLogado = usuario;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Boolean retorno = BancoRota.alterarItemRota(tb_Rota.Text, tb_cidadeOrigen.Text, sl_EstadoOrigem.Text, tb_cidadeDestino.Text, sl_EstadoDestino.Text, rota, cidadeOrigem, estadoOrigem, cidadeDestino, estadoDestino, usuarioLogado);
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
    }
}
