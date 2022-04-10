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
    public partial class Cadastro_de_Usuario : Form
    {
        string usuarioLogado;
        public Cadastro_de_Usuario(string usuario)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            int retorno;
            int nivelPermissao;

            nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, 10);

            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
                this.Close();
            }
            else
            {
                if ((tb_usuario.Text.Length > 3) && (tb_senha.Text.Length > 7))
                {
                    retorno = BancoDeDados.verificaUsuario(tb_usuario.Text);
                    if (retorno == 0)
                    {
                        MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                        this.Close();
                    }
                    if (retorno == 1)
                    {
                        MessageBox.Show("Usuário já cadastrado!");
                        tb_usuario.Clear();
                        tb_usuario.Focus();
                    }
                    if (retorno == -1)
                    {
                        Boolean banco;
                        banco = BancoDeDados.cadastrarUsuario(tb_usuario.Text, tb_senha.Text, cb_gloria.Checked.ToString(), cb_paranavai.Checked.ToString(), cb_toledo.Checked.ToString(), cb_rioVerde.Checked.ToString(), cb_pedido.Checked.ToString(), cb_veiculos.Checked.ToString(), cb_rota.Checked.ToString(), cb_cadastroUsuario.Checked.ToString(), cb_dashboard.Checked.ToString(), cb_obterUsuario.Checked.ToString());
                        if (banco == false)
                        {
                            MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                            this.Close();
                        }
                        if (banco == true)
                        {
                            MessageBox.Show("Usuario cadastrado com sucesso!");
                            this.Close();
                        }
                    }
                }
                else if (tb_usuario.Text.Length <= 3)
                {
                    MessageBox.Show("Usuario deve ter no minímo 4 caracteres");
                    tb_usuario.Clear();
                    tb_usuario.Focus();
                }
                else if (tb_senha.Text.Length <= 7)
                {
                    MessageBox.Show("Senha deve ter no minímo 8 caracteres");
                    tb_senha.Clear();
                    tb_senha.Focus();
                }
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cadastro_de_Usuario_Load(object sender, EventArgs e)
        {
           
        }
    }
}
