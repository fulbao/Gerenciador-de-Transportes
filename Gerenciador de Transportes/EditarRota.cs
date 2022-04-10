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
    public partial class EditarRota : Form
    {
        string rota, cidadeOrigem, estadoOrigem, cidadeDestino, estadoDestino, usuarioLogado;
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

        private void EditarRota_Load(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Boolean retorno = BancoDeDados.alterarItemRota(tb_Rota.Text, tb_cidadeOrigen.Text, sl_EstadoOrigem.Text, tb_cidadeDestino.Text, sl_EstadoDestino.Text, rota, cidadeOrigem, estadoOrigem, cidadeDestino, estadoDestino, usuarioLogado);
            if (!retorno)
            {
                MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
            }
            else
            {
                this.Close();
            }
        }
    }
}
