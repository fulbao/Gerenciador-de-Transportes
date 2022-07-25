using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class Rotas : Form
    {
        string usuarioLogado;

        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public Rotas(string usuario)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            usuarioLogado = usuario;
        }

        private void Rotas_Load(object sender, EventArgs e)
        {
            Boolean retorno = leRotas();

            if (!retorno)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal.ShowDialog();
                this.Close();
            }

        }

        public bool leRotas()
        {
            string[] itens = new string[5];

            lv_rotas.Items.Clear();

            string deletado;

            try
            {
                for (int i = 0; i > -1; i++)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.rotas WHERE id = " + (i + 1).ToString();
                    usuarioQuery.CommandType = CommandType.Text;
                    usuarioQuery.Connection = conn;

                    conn.Open();

                    readerUsuario = usuarioQuery.ExecuteReader();
                    if (!readerUsuario.HasRows) { return true; }
                    readerUsuario.Read();

                    itens[0] = readerUsuario.GetString(1);

                    itens[1] = readerUsuario.GetString(2);

                    itens[2] = readerUsuario.GetString(3);

                    itens[3] = readerUsuario.GetString(4);

                    itens[4] = readerUsuario.GetString(5);

                    deletado = readerUsuario.GetString("deletado");

                    conn.Close();

                    if (deletado == "False")
                    {
                        ListViewItem l = new ListViewItem(itens);

                        lv_rotas.Items.Add(l);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
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
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, 9);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {
                CadastroRota cadastroRota = new CadastroRota(usuarioLogado);
                cadastroRota.ShowDialog();
                Boolean semUso = leRotas();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rotas_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, 9);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {
                if (lv_rotas.SelectedIndices.Count <= 0)
                {
                    ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item");
                    modal.ShowDialog();
                }
                else
                {
                    ModalYN modal = new ModalYN("Atenção!", "Você tem certeza que deseja apagar esse item?");
                    modal.ShowDialog();

                    Boolean retorno = modal.retorno;

                    if (retorno == true)
                    {
                        retorno = BancoRota.deletarItemRota(lv_rotas.SelectedItems[0].SubItems[0].Text, lv_rotas.SelectedItems[0].SubItems[1].Text, lv_rotas.SelectedItems[0].SubItems[2].Text, lv_rotas.SelectedItems[0].SubItems[3].Text, lv_rotas.SelectedItems[0].SubItems[4].Text);
                        if (!retorno)
                        {
                            ModalErro modal2 = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                            modal2.ShowDialog();
                        }
                        else
                        {
                            retorno = leRotas();
                        }
                    }
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, 9);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {
                if (lv_rotas.SelectedIndices.Count <= 0)
                {
                    ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item");
                    modal.ShowDialog();
                }
                else
                {
                    EditarRota editarRota = new EditarRota(lv_rotas.SelectedItems[0].SubItems[0].Text, lv_rotas.SelectedItems[0].SubItems[1].Text, lv_rotas.SelectedItems[0].SubItems[2].Text, lv_rotas.SelectedItems[0].SubItems[3].Text, lv_rotas.SelectedItems[0].SubItems[4].Text, usuarioLogado);
                    editarRota.ShowDialog();
                    leRotas();
                }
            }
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, 12);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {
                Boolean retorno;
                if (lv_rotas.SelectedIndices.Count <= 0)
                {
                    ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item");
                    modal.ShowDialog();
                }
                else
                {
                    retorno = BancoUsuario.obterUsuarioRota(lv_rotas.SelectedItems[0].SubItems[0].Text, lv_rotas.SelectedItems[0].SubItems[1].Text, lv_rotas.SelectedItems[0].SubItems[2].Text, lv_rotas.SelectedItems[0].SubItems[3].Text, lv_rotas.SelectedItems[0].SubItems[4].Text);
                    if (!retorno)
                    {
                        ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                        modal.ShowDialog();
                    }
                    else
                    {
                        retorno = leRotas();
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
