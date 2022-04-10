using MySql.Data.MySqlClient;
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
                MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
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
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.rotas WHERE id = " + (i+1).ToString();
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

                    deletado = readerUsuario.GetString(7);

                    conn.Close();

                    if (deletado == "False")
                    {
                        ListViewItem l = new ListViewItem(itens);

                        lv_rotas.Items.Add(l);
                    }
                }

                return true;
            }
            catch (Exception ex)
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
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, 9);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
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
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, 9);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                Boolean retorno;
                if (lv_rotas.SelectedIndices.Count <= 0)
                {
                    MessageBox.Show("Selecione um item");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja apagar esse item?", "Verificação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        retorno = BancoDeDados.deletarItemRota(lv_rotas.SelectedItems[0].SubItems[0].Text, lv_rotas.SelectedItems[0].SubItems[1].Text, lv_rotas.SelectedItems[0].SubItems[2].Text, lv_rotas.SelectedItems[0].SubItems[3].Text, lv_rotas.SelectedItems[0].SubItems[4].Text);
                        if (!retorno)
                        {
                            MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
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
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, 9);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                if (lv_rotas.SelectedIndices.Count <= 0)
                {
                    MessageBox.Show("Selecione um item");
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
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, 12);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                Boolean retorno;
                if (lv_rotas.SelectedIndices.Count <= 0)
                {
                    MessageBox.Show("Selecione um item");
                }
                else
                {
                    retorno = BancoDeDados.obterUsuarioRota(lv_rotas.SelectedItems[0].SubItems[0].Text, lv_rotas.SelectedItems[0].SubItems[1].Text, lv_rotas.SelectedItems[0].SubItems[2].Text, lv_rotas.SelectedItems[0].SubItems[3].Text, lv_rotas.SelectedItems[0].SubItems[4].Text);
                    if (!retorno)
                    {
                        MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                    }
                    else
                    {
                        retorno = leRotas();
                    }
                }
            }
        }
    }
}
