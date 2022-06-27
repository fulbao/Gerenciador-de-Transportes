using Gerenciador_de_Transportes.Telas.Utilitarias;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BancoDeDados.conectar();
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
                tb_usuario.Clear();
                tb_senha.Clear();
                return false;
            }

            leituraSenha = BancoUsuario.verificaSenha(senha);
            if (leituraSenha == 0)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal.ShowDialog();
                tb_usuario.Clear();
                tb_senha.Clear();
                return false;
            }

            if ((leituraUsuario == -1) && (leituraSenha == -1))
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Usuário e senha incorretos!");
                modal.ShowDialog();
                tb_usuario.Clear();
                tb_senha.Clear();
                tb_usuario.Focus();
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
                tb_usuario.Clear();
                tb_usuario.Focus();
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string usuario = tb_usuario.Text;
            string senha = tb_senha.Text;
            Boolean login;

            login = verificaSenha(usuario, senha);

            if (login)
            {
                Menu mainMenu = new Menu(usuario);
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            }
        }

        private void Login_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Contatos do desenvolvedor:\n      ghfulber@gmail.com\n          (45) 99959-8011", "Contato");
        }

        private void tb_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)(e.KeyChar) == 13)
            {
                string usuario = tb_usuario.Text;
                string senha = tb_senha.Text;
                Boolean login;

                login = verificaSenha(usuario, senha);

                if (login)
                {
                    Menu mainMenu = new Menu(usuario);
                    this.Hide();
                    mainMenu.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
