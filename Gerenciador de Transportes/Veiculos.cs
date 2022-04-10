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
    public partial class Veículos : Form
    {
        string usuarioLogado;

        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;
        public Veículos(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        public bool leVeiculos()
        {
            string[] itens = new string[5];

            lv_Veiculos.Items.Clear();

            string deletado;

            try
            {
                for (int i = 0; i > -1; i++)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.veiculos WHERE id = " + (i + 1).ToString();
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

                    deletado = readerUsuario.GetString(18);

                    conn.Close();

                    if (deletado == "False")
                    {
                        ListViewItem l = new ListViewItem(itens);

                        lv_Veiculos.Items.Add(l);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, 8);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                CadastroVeiculos cadastroVeiculos = new CadastroVeiculos(usuarioLogado);
                cadastroVeiculos.ShowDialog();
                Boolean semUso = leVeiculos();
            }
        }

        private void Veículos_Load(object sender, EventArgs e)
        {
            Boolean retorno = leVeiculos();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, 8);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                Boolean retorno;
                if (lv_Veiculos.SelectedIndices.Count <= 0)
                {
                    MessageBox.Show("Selecione um item");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja apagar esse item?", "Verificação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        retorno = BancoDeDados.deletarItemVeiculos(lv_Veiculos.SelectedItems[0].SubItems[0].Text, lv_Veiculos.SelectedItems[0].SubItems[1].Text, lv_Veiculos.SelectedItems[0].SubItems[2].Text, lv_Veiculos.SelectedItems[0].SubItems[3].Text, lv_Veiculos.SelectedItems[0].SubItems[4].Text);
                        if (!retorno)
                        {
                            MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                        }
                        else
                        {
                            retorno = leVeiculos();
                        }
                    }
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, 8);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                Boolean retorno;
                if (lv_Veiculos.SelectedIndices.Count <= 0)
                {
                    MessageBox.Show("Selecione um item");
                }
                else
                {
                    EditarVeiculos editarVeiculos = new EditarVeiculos(lv_Veiculos.SelectedItems[0].SubItems[0].Text, lv_Veiculos.SelectedItems[0].SubItems[1].Text, lv_Veiculos.SelectedItems[0].SubItems[2].Text, lv_Veiculos.SelectedItems[0].SubItems[3].Text, lv_Veiculos.SelectedItems[0].SubItems[4].Text, usuarioLogado);
                    editarVeiculos.ShowDialog();
                    retorno = leVeiculos();
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
                if (lv_Veiculos.SelectedIndices.Count <= 0)
                {
                    MessageBox.Show("Selecione um item");
                }
                else
                {
                    retorno = BancoDeDados.obterUsuarioVeiculo(lv_Veiculos.SelectedItems[0].SubItems[0].Text, lv_Veiculos.SelectedItems[0].SubItems[1].Text, lv_Veiculos.SelectedItems[0].SubItems[2].Text, lv_Veiculos.SelectedItems[0].SubItems[3].Text, lv_Veiculos.SelectedItems[0].SubItems[4].Text);
                    if (!retorno)
                    {
                        MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                    }
                    else
                    {
                        retorno = leVeiculos();
                    }
                }
            }
        }

        private void btn_motoristas_Click(object sender, EventArgs e)
        {
            if (lv_Veiculos.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Selecione um item");
            }
            else
            {
                Motoristas motoristas = new Motoristas(lv_Veiculos.SelectedItems[0].SubItems[0].Text, usuarioLogado);
                motoristas.ShowDialog();
            }
        }
    }
}
