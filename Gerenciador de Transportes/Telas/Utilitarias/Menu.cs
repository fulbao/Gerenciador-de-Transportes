using Gerenciador_de_Transportes.Properties;
using Gerenciador_de_Transportes.Telas.Usuario;
using Gerenciador_de_Transportes.Telas.Utilitarias;
using System;
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
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, 10);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {
                Telas.Usuario.Usuario user = new Telas.Usuario.Usuario(usuarioLogado);
                user.Show();
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
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, 11);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dropMenu)
            {
                btn_drop.Image = Resources.seta_cima1;
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    dropMenu = false;
                }
            }
            else
            {
                btn_drop.Image = Resources.seta_baixo1;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    dropMenu = true;
                }
            }
        }

        private void btn_motorista_Click(object sender, EventArgs e)
        {
            Motorista motorista = new Motorista(usuarioLogado);
            motorista.Show();
        }

        private void btn_drop_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_MudarSenha_Click(object sender, EventArgs e)
        {
            TrocarSenha trocar = new TrocarSenha(usuarioLogado);
            trocar.ShowDialog();
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
