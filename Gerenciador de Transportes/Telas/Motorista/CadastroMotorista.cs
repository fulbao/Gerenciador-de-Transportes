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
    public partial class CadastroMotorista : Form
    {
        string usuarioLogado;

        public CadastroMotorista(string usuarioLogado)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.usuarioLogado = usuarioLogado;
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
            if (tb_nome.Text.Length > 0)
            {
                MotoristaCs motorista = new MotoristaCs(tb_nome.Text, tb_telefoneMotorista.Text, tb_nomeEmergencia.Text, tb_telefoneEmergencia.Text);
                Boolean retorno = BancoMotorista.cadastrarMotorista(usuarioLogado, motorista);

                if (retorno)
                {
                    ModalSucesso modal = new ModalSucesso("Sucesso!", "Dados cadastrados com sucesso!");
                    modal.ShowDialog();
                    tb_nome.Clear();
                    tb_telefoneMotorista.Clear();
                    tb_nomeEmergencia.Clear();
                    tb_telefoneEmergencia.Clear();
                    tb_nome.Focus();
                } else
                {
                    ModalErro modal2 = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal2.ShowDialog();
                }
            } else
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Nome do motorista é obrigatório");
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
