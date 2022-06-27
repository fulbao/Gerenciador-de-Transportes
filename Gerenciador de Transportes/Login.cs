using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_Transportes
{
    public partial class Login : Form
    {
        public bool verificaSenha(string usuario, string senha)
        {
            int leituraUsuario;
            int leituraSenha;
            int aprovado;

            leituraUsuario = BancoDeDados.verificaUsuario(usuario);
            if (leituraUsuario == 0)
            {
                MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor");
                tb_usuario.Clear();
                tb_senha.Clear();
                return false;
            }

            leituraSenha = BancoDeDados.verificaSenha(senha);
            if (leituraSenha == 0)
            {
                MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor");
                tb_usuario.Clear();
                tb_senha.Clear();
                return false;
            }

            if ((leituraUsuario == -1) && (leituraSenha == -1))
            {
                MessageBox.Show("Usuário e senha incorretos!");
                tb_usuario.Clear();
                tb_senha.Clear();
                tb_usuario.Focus();
                return false;
            }

            if ((leituraUsuario == 1) && (leituraSenha == -1))
            {
                MessageBox.Show("Senha incorreta!");
                tb_senha.Clear();
                tb_senha.Focus();
                return false;
            }

            if ((leituraUsuario == -1) && (leituraSenha == 1))
            {
                MessageBox.Show("Usuario incorreto!");
                tb_usuario.Clear();
                tb_usuario.Focus();
                return false;
            }

            aprovado = BancoDeDados.verificaLogin(usuario, senha);
            if (aprovado == 0)
            {
                MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor");
                return false;
            }

            if (aprovado == 1)
            {
                return true;
            }

            return false;
        }
        public Login()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BancoDeDados.conectar();
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

        private void Usuario_Click(object sender, EventArgs e)
        {

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
