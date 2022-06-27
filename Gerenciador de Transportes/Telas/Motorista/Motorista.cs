using Gerenciador_de_Transportes.Telas.Utilitarias;
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
    public partial class Motorista : Form
    {
        string usuarioLogado;

        public Motorista(string usuarioLogado)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.usuarioLogado = usuarioLogado;
        }

        private void Motorista_Load(object sender, EventArgs e)
        {
            exibirTela();
        }

        private void exibirTela ()
        {
            List<MotoristaCs> moto = BancoMotorista.leMotorista();

            lv_motoristas.Items.Clear();

            for (int i = 0; i < moto.Count; i++)
            {
                string[] itensOrganizados = { moto[i].Nome, moto[i].NumeroTelefone, moto[i].ContatoEmergencia, moto[i].NumeroContatoEmergencia };

                ListViewItem l = new ListViewItem(itensOrganizados);
                lv_motoristas.Items.Add(l);
            }
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

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CadastroMotorista cadastroMotorista = new CadastroMotorista(usuarioLogado);
            cadastroMotorista.ShowDialog();
            exibirTela();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            if (lv_motoristas.SelectedItems.Count <= 0)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item!");
                modal.ShowDialog();
            }
            else
            {
                BancoUsuario.obterUsuarioMotorista(lv_motoristas.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lv_motoristas.SelectedItems.Count <= 0)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item!");
                modal.ShowDialog();
            }
            else
            {
                EditarMotorista editarMotorista = new EditarMotorista(usuarioLogado, lv_motoristas.SelectedItems[0].SubItems[0].Text, lv_motoristas.SelectedItems[0].SubItems[1].Text, lv_motoristas.SelectedItems[0].SubItems[2].Text, lv_motoristas.SelectedItems[0].SubItems[3].Text);
                editarMotorista.ShowDialog();
                exibirTela();
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            ModalYN modal = new ModalYN("Atenção!", "Você tem certeza que deseja apagar esse item?");
            modal.ShowDialog();

            Boolean retorno = modal.retorno;

            if (retorno == true)
            {
                if (lv_motoristas.SelectedItems.Count <= 0)
                {
                    ModalAlerta modal2 = new ModalAlerta("Atenção!", "Selecione um item!");
                    modal2.ShowDialog();
                }
                else
                {
                    int id = BancoMotorista.retornaId(lv_motoristas.SelectedItems[0].SubItems[0].Text, lv_motoristas.SelectedItems[0].SubItems[1].Text, lv_motoristas.SelectedItems[0].SubItems[2].Text, lv_motoristas.SelectedItems[0].SubItems[3].Text);
                    retorno = BancoMotorista.deletarMotorista(id);
                    if (retorno)
                    {
                        ModalSucesso modal3 = new ModalSucesso("Sucesso!", "Deletado com sucesso!");
                        modal3.ShowDialog();
                        exibirTela();
                    } else
                    {
                        ModalErro modal4 = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                        modal4.ShowDialog();
                    }
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
