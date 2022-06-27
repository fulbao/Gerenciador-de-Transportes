using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class Pedido : Form
    {
        string usuarioLogado;
        public Pedido(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            columnHeader1.Width++;
            bool retorno = lePedidos();
            if (!retorno)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
            }
        }

        public bool lePedidos()
        {
            string[] itens = new string[15];

            lv_Pedido.Items.Clear();

            string deletado;

            try
            {
                for (int i = 0; i > -1; i++)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.pedido WHERE id = " + (i + 1).ToString();
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

                    itens[6] = readerUsuario.GetString(7);

                    itens[7] = readerUsuario.GetString(8);

                    itens[8] = readerUsuario.GetString(9);

                    itens[9] = readerUsuario.GetString(10);

                    itens[10] = readerUsuario.GetString(11);

                    itens[11] = readerUsuario.GetString(12);

                    itens[12] = readerUsuario.GetString(13);

                    itens[13] = readerUsuario.GetString(14);

                    itens[14] = readerUsuario.GetString(15);


                    deletado = readerUsuario.GetString(17);

                    conn.Close();

                    if (deletado == "False")
                    {
                        ListViewItem l = new ListViewItem(itens);

                        lv_Pedido.Items.Add(l);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, 7);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {
                CadastroPedido cadastroPedido = new CadastroPedido(usuarioLogado);
                cadastroPedido.ShowDialog();
                lePedidos();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, 7);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {
                if (lv_Pedido.SelectedIndices.Count <= 0)
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
                        retorno = BancoPedido.deletarItemPedido(lv_Pedido.SelectedItems[0].SubItems[0].Text, lv_Pedido.SelectedItems[0].SubItems[1].Text, lv_Pedido.SelectedItems[0].SubItems[2].Text, lv_Pedido.SelectedItems[0].SubItems[3].Text, lv_Pedido.SelectedItems[0].SubItems[4].Text, lv_Pedido.SelectedItems[0].SubItems[5].Text, lv_Pedido.SelectedItems[0].SubItems[6].Text, lv_Pedido.SelectedItems[0].SubItems[7].Text, lv_Pedido.SelectedItems[0].SubItems[8].Text, lv_Pedido.SelectedItems[0].SubItems[9].Text, lv_Pedido.SelectedItems[0].SubItems[10].Text, lv_Pedido.SelectedItems[0].SubItems[11].Text, lv_Pedido.SelectedItems[0].SubItems[12].Text, lv_Pedido.SelectedItems[0].SubItems[13].Text, lv_Pedido.SelectedItems[0].SubItems[14].Text);
                        if (!retorno)
                        {
                            ModalErro modal2 = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                            modal2.ShowDialog();
                        }
                        else
                        {
                            retorno = lePedidos();
                            if (!retorno)
                            {
                                ModalErro modal3 = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                                modal3.ShowDialog();
                            }
                        }
                    }
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, 7);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {
                if (lv_Pedido.SelectedIndices.Count <= 0)
                {
                    ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item");
                    modal.ShowDialog();
                }
                else
                {
                    EditarPedido editarPedido = new EditarPedido(lv_Pedido.SelectedItems[0].SubItems[0].Text, lv_Pedido.SelectedItems[0].SubItems[1].Text, lv_Pedido.SelectedItems[0].SubItems[2].Text, lv_Pedido.SelectedItems[0].SubItems[3].Text, lv_Pedido.SelectedItems[0].SubItems[4].Text, lv_Pedido.SelectedItems[0].SubItems[5].Text, lv_Pedido.SelectedItems[0].SubItems[6].Text, lv_Pedido.SelectedItems[0].SubItems[7].Text, lv_Pedido.SelectedItems[0].SubItems[8].Text, lv_Pedido.SelectedItems[0].SubItems[9].Text, lv_Pedido.SelectedItems[0].SubItems[10].Text, lv_Pedido.SelectedItems[0].SubItems[11].Text, lv_Pedido.SelectedItems[0].SubItems[12].Text, lv_Pedido.SelectedItems[0].SubItems[13].Text, lv_Pedido.SelectedItems[0].SubItems[14].Text, usuarioLogado);
                    editarPedido.ShowDialog();
                    Boolean semUso = lePedidos();
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
                if (lv_Pedido.SelectedIndices.Count <= 0)
                {
                    ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item");
                    modal.ShowDialog();
                }
                else
                {
                    retorno = BancoUsuario.obterUsuarioPedido(lv_Pedido.SelectedItems[0].SubItems[0].Text, lv_Pedido.SelectedItems[0].SubItems[1].Text, lv_Pedido.SelectedItems[0].SubItems[2].Text, lv_Pedido.SelectedItems[0].SubItems[3].Text, lv_Pedido.SelectedItems[0].SubItems[4].Text, lv_Pedido.SelectedItems[0].SubItems[5].Text, lv_Pedido.SelectedItems[0].SubItems[6].Text, lv_Pedido.SelectedItems[0].SubItems[7].Text, lv_Pedido.SelectedItems[0].SubItems[8].Text, lv_Pedido.SelectedItems[0].SubItems[9].Text, lv_Pedido.SelectedItems[0].SubItems[10].Text, lv_Pedido.SelectedItems[0].SubItems[11].Text, lv_Pedido.SelectedItems[0].SubItems[12].Text, lv_Pedido.SelectedItems[0].SubItems[13].Text, lv_Pedido.SelectedItems[0].SubItems[14].Text);
                    if (!retorno)
                    {
                        ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                        modal.ShowDialog();
                    }
                    else
                    {
                        retorno = lePedidos();
                        if (!retorno)
                        {
                            ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                            modal.ShowDialog();
                        }
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
