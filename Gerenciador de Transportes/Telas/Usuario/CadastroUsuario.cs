using Gerenciador_de_Transportes.Telas.Utilitarias;
using System;
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

            nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, 10);

            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
                this.Close();
            }
            else
            {
                if ((tb_usuario.Text.Length > 3) && (tb_senha.Text.Length > 7))
                {
                    retorno = BancoUsuario.verificaUsuario(tb_usuario.Text);
                    if (retorno == 0)
                    {
                        ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                        modal.ShowDialog();
                    }
                    if (retorno == 1)
                    {
                        ModalAlerta modal = new ModalAlerta("Atenção!", "Usuário já cadastrado!");
                        modal.ShowDialog();
                        tb_usuario.Clear();
                        tb_usuario.Focus();
                    }
                    if (retorno == -1)
                    {
                        Boolean banco;
                        banco = BancoUsuario.cadastrarUsuario(tb_usuario.Text, tb_senha.Text, cb_gloria.Checked.ToString(), cb_paranavai.Checked.ToString(), cb_toledo.Checked.ToString(), cb_rioVerde.Checked.ToString(), cb_pedido.Checked.ToString(), cb_veiculos.Checked.ToString(), cb_rota.Checked.ToString(), cb_cadastroUsuario.Checked.ToString(), cb_dashboard.Checked.ToString(), cb_obterUsuario.Checked.ToString());
                        if (banco == false)
                        {
                            ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                            modal.ShowDialog();
                        }
                        if (banco == true)
                        {
                            ModalSucesso modal = new ModalSucesso("Atenção!", "Usuario cadastrado com sucesso!");
                            modal.ShowDialog();
                        }
                    }
                }
                else if (tb_usuario.Text.Length <= 3)
                {
                    ModalAlerta modal = new ModalAlerta("Atenção!", "Usuario deve ter no minímo 4 caracteres");
                    modal.ShowDialog();
                    tb_usuario.Clear();
                    tb_usuario.Focus();
                }
                else if (tb_senha.Text.Length <= 7)
                {
                    ModalAlerta modal = new ModalAlerta("Atenção!", "Senha deve ter no minímo 8 caracteres");
                    modal.ShowDialog();
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

        private void Cadastro_de_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
