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
    public partial class EmbarqueGloria : Form
    {
        string contexto;
        string usuarioLogado;
        int permissao;
        public EmbarqueGloria(string usuario, string contexto)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            usuarioLogado = usuario;
            this.contexto = contexto;
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
        public bool leEmbarque(string conte)
        {
            string[] itens = new string[39];

            lv_embarque.Items.Clear();

            string deletado;

            try
            {
                for (int i = 0; i > -1; i++)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes." + conte + " WHERE id = " + (i + 1).ToString();
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

                    itens[5] = readerUsuario.GetString(6);

                    itens[38] = readerUsuario.GetString(7);

                    itens[6] = readerUsuario.GetString(8);

                    itens[7] = readerUsuario.GetString(9);

                    itens[8] = readerUsuario.GetString(10);

                    itens[9] = readerUsuario.GetString(11);

                    itens[10] = readerUsuario.GetString(12);

                    itens[11] = readerUsuario.GetString(13);

                    itens[12] = readerUsuario.GetString(14);

                    itens[13] = readerUsuario.GetString(15);

                    itens[14] = readerUsuario.GetString(16);

                    itens[15] = readerUsuario.GetString(17);

                    itens[16] = readerUsuario.GetString(18);

                    itens[17] = readerUsuario.GetString(19);

                    itens[18] = readerUsuario.GetString(20);

                    itens[19] = readerUsuario.GetString(21);

                    itens[20] = readerUsuario.GetString(22);

                    itens[21] = readerUsuario.GetString(23);

                    itens[22] = readerUsuario.GetString(24);

                    itens[23] = readerUsuario.GetString(25);

                    itens[24] = readerUsuario.GetString(26);

                    itens[25] = readerUsuario.GetString(27);

                    itens[26] = readerUsuario.GetString(28);

                    itens[27] = readerUsuario.GetString(29);

                    itens[28] = readerUsuario.GetString(30);

                    itens[29] = readerUsuario.GetString(31);

                    itens[30] = readerUsuario.GetString(32);

                    itens[31] = readerUsuario.GetString(33);

                    itens[32] = readerUsuario.GetString(34);

                    itens[33] = readerUsuario.GetString(35);

                    itens[34] = readerUsuario.GetString(36);

                    itens[35] = readerUsuario.GetString(37);

                    itens[36] = readerUsuario.GetString(38);

                    itens[37] = readerUsuario.GetString(39);

                    deletado = readerUsuario.GetString(41);

                    conn.Close();

                    if (deletado == "False")
                    {
                        ListViewItem l = new ListViewItem(itens);

                        lv_embarque.Items.Add(l);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void EmbarqueGloria_Load(object sender, EventArgs e)
        {
            if (contexto == "embarqueGloria")
            {
                this.Text = "Embarque Glória de Dourados - MS";
                permissao = 3;
                Boolean retorno = leEmbarque(contexto);
                if (!retorno)
                {
                    MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                }
            }
            if (contexto == "embarqueParanavai")
            {
                this.Text = "Embarque Paranavaí - PR";
                permissao = 4;
                Boolean retorno = leEmbarque(contexto);
                if (!retorno)
                {
                    MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                }
            }
            if (contexto == "embarqueToledo")
            {
                this.Text = "Embarque Toledo - PR";
                permissao = 5;
                Boolean retorno = leEmbarque(contexto);
                if (!retorno)
                {
                    MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                }
            }
            if (contexto == "embarqueRioVerde")
            {
                this.Text = "Embarque Rio Verde - GO";
                permissao = 6;
                Boolean retorno = leEmbarque(contexto);
                if (!retorno)
                {
                    MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                }
            }
            if (contexto == "embarqueTodos")
            {
                this.Text = "Embarque Todos";
                Boolean retorno = leEmbarque("embarqueTodos");
                if (!retorno)
                {
                    MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                }
                btn_cadastrar.Visible = false;
                btn_deletar.Visible = false;
                btn_editar.Visible = false;
                btn_usuario.Visible = false;
                btn_voltar.Visible = false;
                tableLayoutPanel1.Visible = false;
                lv_embarque.Size = new System.Drawing.Size(lv_embarque.Size.Width, (int)(lv_embarque.Size.Height + (lv_embarque.Size.Height * 0.08)));
            }
            columnHeader1.Width++;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, permissao);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                CadastroEmbarque cadastroEmbarque = new CadastroEmbarque(usuarioLogado, contexto);
                cadastroEmbarque.ShowDialog();
                leEmbarque(contexto);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, permissao);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                Boolean retorno;
                if (lv_embarque.SelectedIndices.Count <= 0)
                {
                    MessageBox.Show("Selecione um item");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja apagar esse item?", "Verificação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        retorno = BancoDeDados.deletarItemEmbarque(lv_embarque.SelectedItems[0].SubItems[0].Text, lv_embarque.SelectedItems[0].SubItems[1].Text, lv_embarque.SelectedItems[0].SubItems[2].Text, lv_embarque.SelectedItems[0].SubItems[3].Text, lv_embarque.SelectedItems[0].SubItems[4].Text, lv_embarque.SelectedItems[0].SubItems[5].Text, lv_embarque.SelectedItems[0].SubItems[38].Text, lv_embarque.SelectedItems[0].SubItems[6].Text, lv_embarque.SelectedItems[0].SubItems[7].Text, lv_embarque.SelectedItems[0].SubItems[8].Text, lv_embarque.SelectedItems[0].SubItems[9].Text, lv_embarque.SelectedItems[0].SubItems[10].Text, lv_embarque.SelectedItems[0].SubItems[11].Text, lv_embarque.SelectedItems[0].SubItems[12].Text, lv_embarque.SelectedItems[0].SubItems[13].Text, lv_embarque.SelectedItems[0].SubItems[14].Text, lv_embarque.SelectedItems[0].SubItems[15].Text, lv_embarque.SelectedItems[0].SubItems[16].Text, lv_embarque.SelectedItems[0].SubItems[17].Text, lv_embarque.SelectedItems[0].SubItems[18].Text, lv_embarque.SelectedItems[0].SubItems[19].Text, lv_embarque.SelectedItems[0].SubItems[20].Text, lv_embarque.SelectedItems[0].SubItems[21].Text, lv_embarque.SelectedItems[0].SubItems[22].Text, lv_embarque.SelectedItems[0].SubItems[23].Text, lv_embarque.SelectedItems[0].SubItems[24].Text, lv_embarque.SelectedItems[0].SubItems[25].Text, lv_embarque.SelectedItems[0].SubItems[26].Text, lv_embarque.SelectedItems[0].SubItems[27].Text, lv_embarque.SelectedItems[0].SubItems[28].Text, lv_embarque.SelectedItems[0].SubItems[29].Text, lv_embarque.SelectedItems[0].SubItems[30].Text, lv_embarque.SelectedItems[0].SubItems[31].Text, lv_embarque.SelectedItems[0].SubItems[32].Text, lv_embarque.SelectedItems[0].SubItems[33].Text, lv_embarque.SelectedItems[0].SubItems[34].Text, lv_embarque.SelectedItems[0].SubItems[35].Text, lv_embarque.SelectedItems[0].SubItems[36].Text, lv_embarque.SelectedItems[0].SubItems[37].Text, contexto);
                        if (!retorno)
                        {
                            MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                        }
                        else
                        {
                            retorno = BancoDeDados.deletarItemEmbarque(lv_embarque.SelectedItems[0].SubItems[0].Text, lv_embarque.SelectedItems[0].SubItems[1].Text, lv_embarque.SelectedItems[0].SubItems[2].Text, lv_embarque.SelectedItems[0].SubItems[3].Text, lv_embarque.SelectedItems[0].SubItems[4].Text, lv_embarque.SelectedItems[0].SubItems[5].Text, lv_embarque.SelectedItems[0].SubItems[38].Text, lv_embarque.SelectedItems[0].SubItems[6].Text, lv_embarque.SelectedItems[0].SubItems[7].Text, lv_embarque.SelectedItems[0].SubItems[8].Text, lv_embarque.SelectedItems[0].SubItems[9].Text, lv_embarque.SelectedItems[0].SubItems[10].Text, lv_embarque.SelectedItems[0].SubItems[11].Text, lv_embarque.SelectedItems[0].SubItems[12].Text, lv_embarque.SelectedItems[0].SubItems[13].Text, lv_embarque.SelectedItems[0].SubItems[14].Text, lv_embarque.SelectedItems[0].SubItems[15].Text, lv_embarque.SelectedItems[0].SubItems[16].Text, lv_embarque.SelectedItems[0].SubItems[17].Text, lv_embarque.SelectedItems[0].SubItems[18].Text, lv_embarque.SelectedItems[0].SubItems[19].Text, lv_embarque.SelectedItems[0].SubItems[20].Text, lv_embarque.SelectedItems[0].SubItems[21].Text, lv_embarque.SelectedItems[0].SubItems[22].Text, lv_embarque.SelectedItems[0].SubItems[23].Text, lv_embarque.SelectedItems[0].SubItems[24].Text, lv_embarque.SelectedItems[0].SubItems[25].Text, lv_embarque.SelectedItems[0].SubItems[26].Text, lv_embarque.SelectedItems[0].SubItems[27].Text, lv_embarque.SelectedItems[0].SubItems[28].Text, lv_embarque.SelectedItems[0].SubItems[29].Text, lv_embarque.SelectedItems[0].SubItems[30].Text, lv_embarque.SelectedItems[0].SubItems[31].Text, lv_embarque.SelectedItems[0].SubItems[32].Text, lv_embarque.SelectedItems[0].SubItems[33].Text, lv_embarque.SelectedItems[0].SubItems[34].Text, lv_embarque.SelectedItems[0].SubItems[35].Text, lv_embarque.SelectedItems[0].SubItems[36].Text, lv_embarque.SelectedItems[0].SubItems[37].Text, "embarqueTodos");
                            retorno = leEmbarque(contexto);
                            if (!retorno)
                            {
                                MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                            }
                        }
                    }
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoDeDados.lePermissaoUsuario(usuarioLogado, permissao);
            if (nivelPermissao != 1)
            {
                MessageBox.Show("Você não tem permissão para isso!");
            }
            else
            {
                Boolean retorno;
                if (lv_embarque.SelectedIndices.Count <= 0)
                {
                    MessageBox.Show("Selecione um item");
                }
                else
                {
                    EmbarqueEditar embarque = new EmbarqueEditar(lv_embarque.SelectedItems[0].SubItems[0].Text, lv_embarque.SelectedItems[0].SubItems[1].Text, lv_embarque.SelectedItems[0].SubItems[2].Text, lv_embarque.SelectedItems[0].SubItems[3].Text, lv_embarque.SelectedItems[0].SubItems[4].Text, lv_embarque.SelectedItems[0].SubItems[5].Text, lv_embarque.SelectedItems[0].SubItems[38].Text, lv_embarque.SelectedItems[0].SubItems[6].Text, lv_embarque.SelectedItems[0].SubItems[7].Text, lv_embarque.SelectedItems[0].SubItems[8].Text, lv_embarque.SelectedItems[0].SubItems[9].Text, lv_embarque.SelectedItems[0].SubItems[10].Text, lv_embarque.SelectedItems[0].SubItems[11].Text, lv_embarque.SelectedItems[0].SubItems[12].Text, lv_embarque.SelectedItems[0].SubItems[13].Text, lv_embarque.SelectedItems[0].SubItems[14].Text, lv_embarque.SelectedItems[0].SubItems[15].Text, lv_embarque.SelectedItems[0].SubItems[16].Text, lv_embarque.SelectedItems[0].SubItems[17].Text, lv_embarque.SelectedItems[0].SubItems[18].Text, lv_embarque.SelectedItems[0].SubItems[19].Text, lv_embarque.SelectedItems[0].SubItems[20].Text, lv_embarque.SelectedItems[0].SubItems[21].Text, lv_embarque.SelectedItems[0].SubItems[22].Text, lv_embarque.SelectedItems[0].SubItems[23].Text, lv_embarque.SelectedItems[0].SubItems[25].Text, lv_embarque.SelectedItems[0].SubItems[26].Text, lv_embarque.SelectedItems[0].SubItems[27].Text, lv_embarque.SelectedItems[0].SubItems[28].Text, lv_embarque.SelectedItems[0].SubItems[29].Text, lv_embarque.SelectedItems[0].SubItems[30].Text, lv_embarque.SelectedItems[0].SubItems[31].Text, lv_embarque.SelectedItems[0].SubItems[32].Text, lv_embarque.SelectedItems[0].SubItems[33].Text, lv_embarque.SelectedItems[0].SubItems[34].Text, lv_embarque.SelectedItems[0].SubItems[35].Text, lv_embarque.SelectedItems[0].SubItems[36].Text, lv_embarque.SelectedItems[0].SubItems[37].Text, contexto, usuarioLogado);
                    embarque.ShowDialog();
                    Boolean semUso = leEmbarque(contexto);
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
                if (lv_embarque.SelectedIndices.Count <= 0)
                {
                    MessageBox.Show("Selecione um item");
                }
                else
                {
                    retorno = BancoDeDados.obterUsuarioEmbarque(lv_embarque.SelectedItems[0].SubItems[0].Text, lv_embarque.SelectedItems[0].SubItems[1].Text, lv_embarque.SelectedItems[0].SubItems[2].Text, lv_embarque.SelectedItems[0].SubItems[3].Text, lv_embarque.SelectedItems[0].SubItems[4].Text, lv_embarque.SelectedItems[0].SubItems[5].Text, lv_embarque.SelectedItems[0].SubItems[38].Text, lv_embarque.SelectedItems[0].SubItems[6].Text, lv_embarque.SelectedItems[0].SubItems[7].Text, lv_embarque.SelectedItems[0].SubItems[8].Text, lv_embarque.SelectedItems[0].SubItems[9].Text, lv_embarque.SelectedItems[0].SubItems[10].Text, lv_embarque.SelectedItems[0].SubItems[11].Text, lv_embarque.SelectedItems[0].SubItems[12].Text, lv_embarque.SelectedItems[0].SubItems[13].Text, lv_embarque.SelectedItems[0].SubItems[14].Text, lv_embarque.SelectedItems[0].SubItems[15].Text, lv_embarque.SelectedItems[0].SubItems[16].Text, lv_embarque.SelectedItems[0].SubItems[17].Text, lv_embarque.SelectedItems[0].SubItems[18].Text, lv_embarque.SelectedItems[0].SubItems[19].Text, lv_embarque.SelectedItems[0].SubItems[20].Text, lv_embarque.SelectedItems[0].SubItems[21].Text, lv_embarque.SelectedItems[0].SubItems[22].Text, lv_embarque.SelectedItems[0].SubItems[23].Text, lv_embarque.SelectedItems[0].SubItems[24].Text, lv_embarque.SelectedItems[0].SubItems[25].Text, lv_embarque.SelectedItems[0].SubItems[26].Text, lv_embarque.SelectedItems[0].SubItems[27].Text, lv_embarque.SelectedItems[0].SubItems[28].Text, lv_embarque.SelectedItems[0].SubItems[29].Text, lv_embarque.SelectedItems[0].SubItems[30].Text, lv_embarque.SelectedItems[0].SubItems[31].Text, lv_embarque.SelectedItems[0].SubItems[32].Text, lv_embarque.SelectedItems[0].SubItems[33].Text, lv_embarque.SelectedItems[0].SubItems[34].Text, lv_embarque.SelectedItems[0].SubItems[35].Text, lv_embarque.SelectedItems[0].SubItems[36].Text, lv_embarque.SelectedItems[0].SubItems[37].Text, contexto);
                    if (!retorno)
                    {
                        MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                    }
                    else
                    {
                        retorno = leEmbarque(contexto);
                        if (!retorno)
                        {
                            MessageBox.Show("Ocorreu um erro! Contate o desenvolvedor!");
                        }
                    }
                }
            }
        }
    }
}
