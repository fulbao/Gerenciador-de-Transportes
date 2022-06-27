using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class CadastroPedido : Form
    {
        string[] listaRota = new string[10000];

        string[] listaCidadeOrigem = new string[10000];

        string[] listaCidadeDestino = new string[10000];

        string[] listaEmbarcadores = new string[10000];

        string[] listaDestinatario = new string[10000];

        string[] listaEstadoEmbarcador = new string[10000];

        string[] listaEstadoDestino = new string[10000];

        string usuarioLogado;

        int j;

        public CadastroPedido(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void CadastroPedido_Load(object sender, EventArgs e)
        {
            Boolean retorno = retornaRotas();

            if (!retorno)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal.ShowDialog();
            }
            else
            {
                sl_rota.Items.Add("Selecionar");
                for (int i = 0; i < j; i++)
                {
                    sl_rota.Items.Add(listaRota[i]);
                    tb_cidadeOrigem.Text = "Selecione Rota";
                    tb_cidadeDestino.Text = "Selecione Rota";
                    sl_rota.SelectedIndex = 0;
                    sl_EstadoEmbarcador.Text = "Selecione Rota";
                    sl_estadoDestinatario.Text = "Selecione Rota";
                }
            }
            retorno = retornaEmbarcador();

            if (!retorno)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal.ShowDialog();
            }
            else
            {
                tb_destinatario.Text = "Selecione Embarcador";
                tb_Embarcador.Items.Add("Selecionar");

                string[] embarcado = new string[j];

                for (int i = 0; i < j; i++)
                {
                    embarcado[i] = listaEmbarcadores[i] + "/" + listaDestinatario[i];
                }

                Array.Sort(embarcado);

                for (int i = 0; i < j; i++)
                {
                    tb_Embarcador.SelectedIndex = 0;
                    tb_Embarcador.Items.Add(embarcado[i]);
                }
            }
        }

        public Boolean retornaEmbarcador()
        {
            j = 0;
            try
            {
                for (int i = 0; i > -1; i++)
                {
                    string deletado;
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.embarcadores WHERE id = " + (i + 1).ToString();
                    usuarioQuery.CommandType = CommandType.Text;
                    usuarioQuery.Connection = conn;

                    conn.Open();

                    readerUsuario = usuarioQuery.ExecuteReader();
                    readerUsuario.Read();


                    if (!readerUsuario.HasRows)
                    {
                        return true;
                    }
                    deletado = readerUsuario.GetString(3);

                    if (deletado == "False")
                    {
                        listaEmbarcadores[j] = readerUsuario.GetString(1);

                        listaDestinatario[j] = readerUsuario.GetString(4);

                        j++;
                    }

                    conn.Close();


                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void limpar()
        {
            tb_Pedido.Clear();
            tb_freteFiscal.Clear();
            tb_Icms.Clear();
            tb_Pedagio.Clear();
            tb_Classificao.Clear();
            tb_Km.Clear();
            tb_Cliente.Clear();
            tb_Embarcador.SelectedIndex = 0;
            tb_destinatario.Text = "Selecione Embarcador";
            tb_freteMotorista.Clear();
            tb_cidadeOrigem.Clear();
            tb_cidadeDestino.Clear();
            sl_rota.SelectedIndex = 0;
            sl_EstadoEmbarcador.Clear();
            sl_estadoDestinatario.Clear();
            tb_Pedido.Focus();
            tb_cidadeOrigem.Text = "Selecione Rota";
            tb_cidadeDestino.Text = "Selecione Rota";
            sl_rota.SelectedIndex = 0;
            sl_EstadoEmbarcador.Text = "Selecione Rota";
            sl_estadoDestinatario.Text = "Selecione Rota";
        }

        public Boolean retornaRotas()
        {
            j = 0;
            try
            {
                for (int i = 0; i > -1; i++)
                {
                    string deletado;
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.rotas WHERE id = " + (i + 1).ToString();
                    usuarioQuery.CommandType = CommandType.Text;
                    usuarioQuery.Connection = conn;

                    conn.Open();

                    readerUsuario = usuarioQuery.ExecuteReader();
                    readerUsuario.Read();


                    if (!readerUsuario.HasRows)
                    {
                        return true;
                    }
                    deletado = readerUsuario.GetString("deletado");

                    if (deletado == "False")
                    {
                        listaRota[j] = readerUsuario.GetString(1);

                        listaCidadeOrigem[j] = readerUsuario.GetString(2);

                        listaCidadeDestino[j] = readerUsuario.GetString(4);

                        listaEstadoEmbarcador[j] = readerUsuario.GetString(3);

                        listaEstadoDestino[j] = readerUsuario.GetString(5);

                        j++;
                    }

                    conn.Close();


                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void sl_rota_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecionado;
            selecionado = sl_rota.Text;

            for (int i = 0; i < listaRota.Length; i++)
            {
                if (selecionado == listaRota[i])
                {
                    tb_cidadeOrigem.Text = listaCidadeOrigem[i];
                    tb_cidadeDestino.Text = listaCidadeDestino[i];
                    sl_EstadoEmbarcador.Text = listaEstadoEmbarcador[i];
                    sl_estadoDestinatario.Text = listaEstadoDestino[i];
                    i = listaRota.Length;
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Boolean retorno;
            if ((tb_Pedido.Text == "") || (sl_rota.Text == "Selecionador") || (tb_freteFiscal.Text == "") || (tb_Icms.Text == "") || (tb_Pedagio.Text == "") || (tb_Classificao.Text == "") || (tb_Km.Text == "") || (tb_Cliente.Text == "") || (tb_Embarcador.Text == "") || (sl_EstadoEmbarcador.Text == "Selecione") || (tb_destinatario.Text == "") || (sl_estadoDestinatario.Text == "Selecione") || (tb_freteMotorista.Text == "") || (tb_cidadeOrigem.Text == "") || (tb_cidadeDestino.Text == ""))
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Preencha todos os campos!");
                modal.ShowDialog();
            }
            else
            {
                string embarcador = tb_Embarcador.Text;
                string[] split = embarcador.Split('/');
                retorno = BancoPedido.adicionarPedido(tb_Pedido.Text, sl_rota.Text, tb_freteFiscal.Text, tb_Icms.Text, tb_Pedagio.Text, tb_Classificao.Text, tb_Km.Text, tb_Cliente.Text, split[0], sl_EstadoEmbarcador.Text, tb_destinatario.Text, sl_estadoDestinatario.Text, tb_freteMotorista.Text, tb_cidadeOrigem.Text, tb_cidadeDestino.Text, usuarioLogado);
                if (!retorno)
                {
                    ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal.ShowDialog();
                }
                else
                {
                    ModalSucesso modal = new ModalSucesso("Sucesso!", "Dados cadastrador com sucesso!");
                    modal.ShowDialog();
                    limpar();
                }
            }
        }

        private void tb_freteFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '1') && (e.KeyChar != '2') && (e.KeyChar != '3') && (e.KeyChar != '4') && (e.KeyChar != '5') && (e.KeyChar != '6') && (e.KeyChar != '7') && (e.KeyChar != '8') && (e.KeyChar != '9') && (e.KeyChar != '0') && (e.KeyChar != ',') && ((int)(e.KeyChar) != 8))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tb_Icms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '1') && (e.KeyChar != '2') && (e.KeyChar != '3') && (e.KeyChar != '4') && (e.KeyChar != '5') && (e.KeyChar != '6') && (e.KeyChar != '7') && (e.KeyChar != '8') && (e.KeyChar != '9') && (e.KeyChar != '0') && (e.KeyChar != ',') && ((int)(e.KeyChar) != 8))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tb_Pedagio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '1') && (e.KeyChar != '2') && (e.KeyChar != '3') && (e.KeyChar != '4') && (e.KeyChar != '5') && (e.KeyChar != '6') && (e.KeyChar != '7') && (e.KeyChar != '8') && (e.KeyChar != '9') && (e.KeyChar != '0') && (e.KeyChar != ',') && ((int)(e.KeyChar) != 8))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tb_Km_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '1') && (e.KeyChar != '2') && (e.KeyChar != '3') && (e.KeyChar != '4') && (e.KeyChar != '5') && (e.KeyChar != '6') && (e.KeyChar != '7') && (e.KeyChar != '8') && (e.KeyChar != '9') && (e.KeyChar != '0') && (e.KeyChar != ',') && ((int)(e.KeyChar) != 8))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tb_freteMotorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '1') && (e.KeyChar != '2') && (e.KeyChar != '3') && (e.KeyChar != '4') && (e.KeyChar != '5') && (e.KeyChar != '6') && (e.KeyChar != '7') && (e.KeyChar != '8') && (e.KeyChar != '9') && (e.KeyChar != '0') && (e.KeyChar != ',') && ((int)(e.KeyChar) != 8))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tb_Pedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '1') && (e.KeyChar != '2') && (e.KeyChar != '3') && (e.KeyChar != '4') && (e.KeyChar != '5') && (e.KeyChar != '6') && (e.KeyChar != '7') && (e.KeyChar != '8') && (e.KeyChar != '9') && (e.KeyChar != '0') && (e.KeyChar != ',') && ((int)(e.KeyChar) != 8))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tb_Embarcador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecionado;
            selecionado = tb_Embarcador.Text;

            for (int i = 0; i < listaEmbarcadores.Length; i++)
            {
                if (selecionado == listaEmbarcadores[i] + "/" + listaDestinatario[i])
                {
                    tb_Embarcador.Text = listaEmbarcadores[i];
                    tb_destinatario.Text = listaDestinatario[i];
                    i = listaEmbarcadores.Length;
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
