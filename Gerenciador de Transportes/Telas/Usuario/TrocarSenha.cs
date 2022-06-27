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

namespace Gerenciador_de_Transportes.Telas.Usuario
{
    public partial class TrocarSenha : Form
    {
        string usuarioLogado;

        public TrocarSenha(string usuarioLogado)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.usuarioLogado = usuarioLogado;
        }

        private void TrocarSenha_Load(object sender, EventArgs e)
        {

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

        private void btn_listaUsers_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(usuarioLogado);
            usuario.Show();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool verificaSenha(string usuario, string senha)
        {
            int leituraUsuario;
            int leituraSenha;
            int aprovado;

            leituraUsuario = BancoUsuario.verificaUsuario(usuario);
            if (leituraUsuario == 0)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal.ShowDialog();
                tb_login.Clear();
                tb_senha.Clear();
                return false;
            }

            leituraSenha = BancoUsuario.verificaSenha(senha);
            if (leituraSenha == 0)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal.ShowDialog();
                tb_login.Clear();
                tb_senha.Clear();
                return false;
            }

            if ((leituraUsuario == -1) && (leituraSenha == -1))
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Usuário e senha incorretos!");
                modal.ShowDialog();
                tb_login.Clear();
                tb_senha.Clear();
                tb_login.Focus();
                return false;
            }

            if ((leituraUsuario == 1) && (leituraSenha == -1))
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Senha incorreta!");
                modal.ShowDialog();
                tb_senha.Clear();
                tb_senha.Focus();
                return false;
            }

            if ((leituraUsuario == -1) && (leituraSenha == 1))
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Usuario incorreto!");
                modal.ShowDialog();
                tb_login.Clear();
                tb_login.Focus();
                return false;
            }

            aprovado = BancoUsuario.verificaLogin(usuario, senha);
            if (aprovado == 0)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal.ShowDialog();
                return false;
            }

            if (aprovado == 1)
            {
                return true;
            }

            return false;
        }

        private void btn_redefinir_Click(object sender, EventArgs e)
        {
            if (tb_confirmaSenha.Text == tb_novaSenha.Text)
            {
                if (tb_confirmaSenha.Text.Length > 7)
                {
                    Boolean login;

                    login = verificaSenha(tb_login.Text, tb_senha.Text);

                    if (login)
                    {
                        Boolean retorno = BancoUsuario.alteraSenha(tb_login.Text, tb_novaSenha.Text);
                        if (!retorno)
                        {
                            ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro no banco de dados. Por favor contate o desenvolvedor");
                            modal.ShowDialog();
                        }
                        else
                        {
                            ModalSucesso modal = new ModalSucesso("Sucesso!", "Senha alterada com sucesso!");
                            modal.ShowDialog();
                            tb_login.Clear();
                            tb_senha.Clear();
                            this.Close();
                        }
                    }
                } else
                {
                    ModalAlerta modal = new ModalAlerta("Atenção!", "A senha deve ter no minimo 8 caracteres!");
                    modal.ShowDialog();
                }

            } else
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "As senhas não corresponde!");
                modal.ShowDialog();
            }

            tb_confirmaSenha.Clear();
            tb_novaSenha.Clear();
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
