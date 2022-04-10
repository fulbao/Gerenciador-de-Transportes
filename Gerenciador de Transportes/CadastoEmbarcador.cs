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
    public partial class CadastoEmbarcador : Form
    {
        string usuarioLogado;

        Boolean editando = false;
        public CadastoEmbarcador(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        public bool leEmbarcadores()
        {
            string[] itens = new string[2];

            lv_embarcador.Items.Clear();

            string deletado;

            try
            {
                for (int i = 0; i > -1; i++)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.embarcadores WHERE id = " + (i + 1).ToString();
                    usuarioQuery.CommandType = CommandType.Text;
                    usuarioQuery.Connection = conn;

                    conn.Open();
                    readerUsuario = usuarioQuery.ExecuteReader();
                    if (!readerUsuario.HasRows) { return true; }
                    readerUsuario.Read();

                    itens[0] = readerUsuario.GetString(1);

                    deletado = readerUsuario.GetString(3);

                    itens[1] = readerUsuario.GetString(4);

                    conn.Close();


                    if (deletado == "False")
                    {
                        ListViewItem l = new ListViewItem(itens);

                        lv_embarcador.Items.Add(l);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void CadastoEmbarcador_Load(object sender, EventArgs e)
        {
            Boolean retorno = leEmbarcadores();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if ((tb_embarcador.Text == "") || (tb_destinatario.Text == ""))
            {
                MessageBox.Show("Preencha o campo de embarcador e destinatário!");
            }
            if ((tb_embarcador.Text != "") && (tb_destinatario.Text != "") && (editando == false))
            {
                BancoDeDados.adicionarEmbarcador(tb_embarcador.Text, usuarioLogado, tb_destinatario.Text);
                tb_embarcador.Clear();
                tb_destinatario.Clear();
                Boolean retorno = leEmbarcadores();
            }
            if ((tb_embarcador.Text != "") && (tb_destinatario.Text != "") && (editando == true))
            {
                BancoDeDados.alterarItemEmbarcadores(tb_embarcador.Text, lv_embarcador.SelectedItems[0].SubItems[0].Text, tb_destinatario.Text, lv_embarcador.SelectedItems[0].SubItems[1].Text);
                tb_embarcador.Clear();
                Boolean retorno = leEmbarcadores();
                editando = false;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lv_embarcador.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Selecione um item");
            }
            else
            {
                tb_embarcador.Text = lv_embarcador.SelectedItems[0].SubItems[0].Text;
                tb_destinatario.Text = lv_embarcador.SelectedItems[0].SubItems[1].Text;
                editando = true;
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            Boolean retorno;
            if (lv_embarcador.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Selecione um item");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja apagar esse item?", "Verificação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    retorno = BancoDeDados.deletarItemEmbarcadores(lv_embarcador.SelectedItems[0].SubItems[0].Text, lv_embarcador.SelectedItems[0].SubItems[1].Text);
                    if (!retorno)
                    {
                        MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                    }
                    else
                    {
                        retorno = leEmbarcadores();
                    }
                }
            }
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            Boolean retorno;
            if (lv_embarcador.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Selecione um item");
            }
            else
            {
                retorno = BancoDeDados.obterUsuarioEmbarcadores(lv_embarcador.SelectedItems[0].SubItems[0].Text);
                if (!retorno)
                {
                    MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                }
                else
                {
                    retorno = leEmbarcadores();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_embarcador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/')
            {
                e.Handled = true;
            } else
            {
                e.Handled = false;
            }
        }

        private void tb_destinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
