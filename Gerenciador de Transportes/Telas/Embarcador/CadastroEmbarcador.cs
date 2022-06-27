using Gerenciador_de_Transportes.Telas.Utilitarias;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class CadastoEmbarcador : Form
    {
        List<EmbarcadoresCs> embarcadores = new List<EmbarcadoresCs>();

        string usuarioLogado;

        Boolean editando = false;

        public CadastoEmbarcador(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void CadastoEmbarcador_Load(object sender, EventArgs e)
        {
            geraListaTela();
        }

        private void geraListaTela()
        {
            lv_embarcador.Items.Clear();
            embarcadores.Clear();

            embarcadores = BancoEmbarcador.leEmbarcadores();

            for (int i = 0; i < embarcadores.Count; i++)
            {
                string[] itensOrganizados = { embarcadores[i].Embarcador, embarcadores[i].Destinatario };

                ListViewItem l = new ListViewItem(itensOrganizados);
                lv_embarcador.Items.Add(l);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if ((tb_embarcador.Text == "") || (tb_destinatario.Text == ""))
            {
                ModalAlerta modal = new ModalAlerta("Atenção", "Preencha o campo de embarcador e destinatário!");
                modal.ShowDialog();
            }
            if ((tb_embarcador.Text != "") && (tb_destinatario.Text != "") && (editando == false))
            {
                Boolean retorno;
                retorno = BancoEmbarcador.adicionarEmbarcador(tb_embarcador.Text, usuarioLogado, tb_destinatario.Text);
                if (retorno)
                {
                    ModalSucesso modal = new ModalSucesso("Sucesso!", "Dados cadastrador com sucesso!");
                    modal.ShowDialog();
                    tb_embarcador.Clear();
                    tb_destinatario.Clear();
                    geraListaTela();
                } else
                {
                    ModalErro modalErro = new ModalErro("Erro", "Ocorreu uma falha na operação, contate o desenvolvedor!");
                    modalErro.ShowDialog();
                }
       
            }
            if ((tb_embarcador.Text != "") && (tb_destinatario.Text != "") && (editando == true))
            {
                BancoEmbarcador.alterarItemEmbarcadores(tb_embarcador.Text, lv_embarcador.SelectedItems[0].SubItems[0].Text, tb_destinatario.Text, lv_embarcador.SelectedItems[0].SubItems[1].Text);
                ModalSucesso modal = new ModalSucesso("Sucesso!", "Dados cadastrador com sucesso!");
                modal.ShowDialog();
                tb_embarcador.Clear();
                tb_destinatario.Clear();
                geraListaTela();
                editando = false;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lv_embarcador.SelectedIndices.Count <= 0)
            {
                ModalAlerta modal = new ModalAlerta("Atenção", "Selecione um item");
                modal.ShowDialog();
            }
            else
            {
                tb_embarcador.Text = lv_embarcador.SelectedItems[0].SubItems[0].Text;
                tb_destinatario.Text = lv_embarcador.SelectedItems[0].SubItems[1].Text;
                editando = true;
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (lv_embarcador.SelectedIndices.Count <= 0)
            {
                ModalAlerta modal = new ModalAlerta("Atenção", "Selecione um item");
                modal.ShowDialog();
            }
            else
            {
                ModalYN modal = new ModalYN("Atenção!", "Você tem certeza que deseja apagar esse item?");
                modal.ShowDialog();

                Boolean retorno = modal.retorno;

                if (retorno == true)
                {
                    retorno = BancoEmbarcador.deletarItemEmbarcadores(lv_embarcador.SelectedItems[0].SubItems[0].Text, lv_embarcador.SelectedItems[0].SubItems[1].Text);
                    if (!retorno)
                    {
                        ModalErro modal2 = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                        modal2.ShowDialog();
                    }
                    else
                    {
                        geraListaTela();
                    }
                }
            }
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            Boolean retorno;
            if (lv_embarcador.SelectedIndices.Count <= 0)
            {
                ModalAlerta modal = new ModalAlerta("Atenção", "Selecione um item");
                modal.ShowDialog();
            }
            else
            {
                retorno = BancoUsuario.obterUsuarioEmbarcadores(lv_embarcador.SelectedItems[0].SubItems[0].Text);
                if (!retorno)
                {
                    ModalErro modal2 = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal2.ShowDialog();
                }
                else
                {
                    geraListaTela();
                }
            }
        }

        private void tb_embarcador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tb_destinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
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
