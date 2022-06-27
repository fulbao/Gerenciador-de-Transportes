using Gerenciador_de_Transportes.Telas.Utilitarias;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class CadastroRota : Form
    {
        string usuarioLogado;
        public CadastroRota(string usuario)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            usuarioLogado = usuario;
        }

        private void CadastroRota_Load(object sender, EventArgs e)
        {
            sl_EstadoDestino.SelectedIndex = 0;
            sl_EstadoOrigem.SelectedIndex = 0;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparTextBox()
        {
            tb_Rota.Clear();
            tb_cidadeOrigen.Clear();
            tb_cidadeDestino.Clear();
            sl_EstadoDestino.SelectedIndex = 0;
            sl_EstadoOrigem.SelectedIndex = 0;
            tb_Rota.Focus();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if ((tb_Rota.Text != "") && (tb_cidadeOrigen.Text != "") && (tb_cidadeDestino.Text != "") && (sl_EstadoDestino.Text != "Selecione") && (sl_EstadoOrigem.Text != "Selecione"))
            {
                Boolean retorno;

                retorno = BancoRota.adicionarRota(tb_Rota.Text, tb_cidadeOrigen.Text, sl_EstadoOrigem.Text, tb_cidadeDestino.Text, sl_EstadoDestino.Text, usuarioLogado);

                if (!retorno)
                {
                    ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal.ShowDialog();
                } else
                {
                    ModalSucesso modal = new ModalSucesso("Sucesso!", "Dados cadastrador com sucesso!");
                    modal.ShowDialog();
                    limparTextBox();
                }

            }
            else
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Algum campo não foi preenchido!");
                modal.ShowDialog();
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
