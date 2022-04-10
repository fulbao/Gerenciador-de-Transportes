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

                retorno = BancoDeDados.adicionarRota(tb_Rota.Text, tb_cidadeOrigen.Text, sl_EstadoOrigem.Text, tb_cidadeDestino.Text, sl_EstadoDestino.Text, usuarioLogado);

                limparTextBox();

                if (!retorno)
                {
                    MessageBox.Show("Ocorreu um problema!\nContate o desenvolvedor");
                }

            } else
            {
                MessageBox.Show("Algum campo não foi preenchido!");
            }
        }
    }
}
