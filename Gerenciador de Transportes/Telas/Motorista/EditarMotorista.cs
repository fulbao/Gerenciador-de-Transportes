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
    public partial class EditarMotorista : Form
    {
        string usuarioLogado;

        string motorista;
        string telefone;
        string contatoEmergencia;
        string telefoneEmergencia;
        int id; 

        public EditarMotorista(string usuario, string motorista, string telefone, string contatoEmergencia, string telefoneEmergencia)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.usuarioLogado = usuario;
            this.motorista = motorista;
            this.telefone = telefone;
            this.contatoEmergencia = contatoEmergencia;
            this.telefoneEmergencia = telefoneEmergencia;
        }

        private void EditarMotorista_Load(object sender, EventArgs e)
        {
            tb_nome.Text = this.motorista;
            tb_telefoneMotorista.Text = this.telefone;
            tb_nomeEmergencia.Text = this.contatoEmergencia;
            tb_telefoneEmergencia.Text = this.telefoneEmergencia;

            this.id = BancoMotorista.retornaId(this.motorista, this.telefone, this.contatoEmergencia, this.telefoneEmergencia);

            if (this.id == -1)
            {
                ModalErro modal2 = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal2.ShowDialog();
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

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Boolean retorno = BancoMotorista.editarMotorista(this.id, tb_nome.Text, tb_telefoneMotorista.Text, tb_nomeEmergencia.Text, tb_telefoneEmergencia.Text);
            if (retorno == true)
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
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
