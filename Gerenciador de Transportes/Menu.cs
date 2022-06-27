using Gerenciador_de_Transportes.Properties;
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

namespace Gerenciador_de_Transportes
{

    public partial class Menu : Form
    {
        string usuarioLogado;
        private bool dropMenu;
        public Menu(string usuario)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            usuarioLogado = usuario;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (usuarioLogado != "admin")
            {
                btn_teste.Enabled = true;
                btn_teste.Visible = false;
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

        private void btn_cadastroUser_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, 10);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                Cadastro_de_Usuario cadastro = new Cadastro_de_Usuario(usuarioLogado);
                cadastro.ShowDialog();
            }
        }

        private void btn_Rotas_Click(object sender, EventArgs e)
        {
            Rotas rotas = new Rotas(usuarioLogado);
            rotas.Show();
        }

        private void btn_Veiculos_Click(object sender, EventArgs e)
        {
            Veículos veiculos = new Veículos(usuarioLogado);
            veiculos.Show();
        }

        private void btn_Pedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(usuarioLogado);
            pedido.Show();
        }

        private void btn_gloria_Click(object sender, EventArgs e)
        {
            Embarque gloria = new Embarque(usuarioLogado, "embarqueGloria");
            gloria.Show();
        }

        private void btn_Paranavai_Click(object sender, EventArgs e)
        {
            Embarque gloria = new Embarque(usuarioLogado, "embarqueParanavai");
            gloria.Show();
        }

        private void btn_Toledo_Click(object sender, EventArgs e)
        {
            Embarque gloria = new Embarque(usuarioLogado, "embarqueToledo");
            gloria.Show();
        }

        private void btn_RioVerde_Click(object sender, EventArgs e)
        {
            Embarque gloria = new Embarque(usuarioLogado, "embarqueRioVerde");
            gloria.Show();
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            Embarque gloria = new Embarque(usuarioLogado, "embarqueTodos");
            gloria.Show();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, 11);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastoEmbarcador cadastoEmbarcador = new CadastoEmbarcador(usuarioLogado);
            cadastoEmbarcador.Show();
        }

        private void btn_teste_Click(object sender, EventArgs e)
        {
            Teste teste = new Teste();
            teste.Show();
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para reportar algum erro ou\n" +
                            "deixa uma sugestão de melhoria\n" +
                            "entre em contato:\n" +
                            "ghfulber@gmail.com ou\n" +
                            "(45) 99959-8011", "Feedback");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dropMenu)
            {
                button1.Image = Resources.seta_cima1; 
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize )
                {
                    timer1.Stop();
                    dropMenu = false;
                }
            }
            else
            {
                button1.Image = Resources.seta_baixo1;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    dropMenu = true;
                }
            }
        }
    }
}
