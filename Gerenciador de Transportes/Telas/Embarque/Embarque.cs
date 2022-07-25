using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class Embarque : Form
    {
        List<EmbarqueCs> embarques = new List<EmbarqueCs>();

        string contexto;

        string usuarioLogado;

        int permissao;

        public Embarque(string usuario, string contexto)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            usuarioLogado = usuario;
            this.contexto = contexto;
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
                    ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal.ShowDialog();
                }
            }
            if (contexto == "embarqueParanavai")
            {
                this.Text = "Embarque Paranavaí - PR";
                permissao = 4;
                Boolean retorno = leEmbarque(contexto);
                if (!retorno)
                {
                    ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal.ShowDialog();
                }
            }
            if (contexto == "embarqueToledo")
            {
                this.Text = "Embarque Toledo - PR";
                permissao = 5;
                Boolean retorno = leEmbarque(contexto);
                if (!retorno)
                {
                    ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal.ShowDialog();
                }
            }
            if (contexto == "embarqueRioVerde")
            {
                this.Text = "Embarque Rio Verde - GO";
                permissao = 6;
                Boolean retorno = leEmbarque(contexto);
                if (!retorno)
                {
                    ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal.ShowDialog();
                }
            }
            if (contexto == "embarqueTodos")
            {
                this.Text = "Embarque Todos";
                Boolean retorno = leEmbarque("embarqueTodos");
                if (!retorno)
                {
                    ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal.ShowDialog();
                }

                btn_cadastrar.Visible = false;
                btn_deletar.Visible = false;
                btn_editar.Visible = false;
                btn_usuario.Visible = false;
                btn_voltar.Visible = false;
                tableLayoutPanel1.Visible = false;
                lv_embarque.Size = new System.Drawing.Size(lv_embarque.Size.Width, (int)(lv_embarque.Size.Height + (lv_embarque.Size.Height * 0.08)));
            }
            organizaDados();
            CidadeDestino.Width++;
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

        public void organizaDados()
        {
            for (int i = 0; i < embarques.Count; i++)
            {
                string[] itensOrganizados = { embarques[i].Empresa, embarques[i].Filial, embarques[i].UnidadeEmbarque, embarques[i].Pedido.CidadeOrigem, embarques[i].Pedido.EstadoEmbarcador, embarques[i].Pedido.CidadeDestino, embarques[i].Pedido.EstadoDestinatario, embarques[i].Pedido.Pedido, embarques[i].PrevisaoEmbarque, embarques[i].DataEmbarque, embarques[i].PrevisaoEntrega, embarques[i].DataEntrega, embarques[i].Aceite, embarques[i].Status, embarques[i].Veiculo.PlacaCavalo, embarques[i].Veiculo.PlacaCarreta, embarques[i].Veiculo.PlacaCarretaSegunda, embarques[i].Veiculo.Proprietario, embarques[i].Veiculo.Motorista, embarques[i].Pedido.FreteFiscal, embarques[i].Pedido.Icms, embarques[i].Pedido.FreteMotorista, embarques[i].Adicional, embarques[i].Pedido.Pedagio, embarques[i].Pedido.Classificacao, embarques[i].Margem, embarques[i].Adiantamento, embarques[i].MeioPagamento, embarques[i].MeioPagamentoDois, embarques[i].Pedido.Km, embarques[i].Pedido.Cliente, embarques[i].Pedido.Embarcador, embarques[i].Pedido.Destinatario, embarques[i].Load, embarques[i].Mercadoria, embarques[i].Peso, embarques[i].Embalagem, embarques[i].Observacao, embarques[i].Frota };

                ListViewItem l = new ListViewItem(itensOrganizados);

                lv_embarque.Items.Add(l);
            }
        }

        public bool leEmbarque(string conte)
        {
            lv_embarque.Items.Clear();

            embarques.Clear();

            string deletado;

            try
            {
                for (int i = 0; i > -1; i++)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes." + conte + " WHERE id = " + (i + 1).ToString();
                    usuarioQuery.CommandType = CommandType.Text;
                    usuarioQuery.Connection = conn;

                    conn.Open();
                    readerUsuario = usuarioQuery.ExecuteReader();
                    if (!readerUsuario.HasRows) { return true; }
                    readerUsuario.Read();

                    deletado = readerUsuario.GetString(41);

                    if (deletado == "False")
                    {
                        PedidoCs pedido = new PedidoCs(readerUsuario.GetString("pedido"), readerUsuario.GetString("freteFiscal"), readerUsuario.GetString("icms"), readerUsuario.GetString("pedagio"), readerUsuario.GetString("classificacao"), readerUsuario.GetString("km"), readerUsuario.GetString("cliente"), readerUsuario.GetString("embarcador"), readerUsuario.GetString("estadoOrigem"), readerUsuario.GetString("destinatario"), readerUsuario.GetString("estadoDestino"), readerUsuario.GetString("freteMotorista"), readerUsuario.GetString("cidadeOrigem"), readerUsuario.GetString("cidadeDestino"));

                        VeiculoCs veiculo = new VeiculoCs(readerUsuario.GetString("placaCavalo"), readerUsuario.GetString("placaCarreta"), readerUsuario.GetString("placaSegundaCarreta"), readerUsuario.GetString("proprietario"), readerUsuario.GetString("motorista"));

                        embarques.Add(new EmbarqueCs(pedido, veiculo, readerUsuario.GetString("empresa"), readerUsuario.GetString("filial"), readerUsuario.GetString("unidadeEmbarque"), readerUsuario.GetString("previsaoEmbarque"), readerUsuario.GetString("dataEmbarque"), readerUsuario.GetString("previsaoEntrega"), readerUsuario.GetString("dataEntrega"), readerUsuario.GetString("aceite"), readerUsuario.GetString("adicional"), readerUsuario.GetString("adiantamento"), readerUsuario.GetString("meioPagamento"), readerUsuario.GetString("meioPagamentoDois"), readerUsuario.GetString("lload"), readerUsuario.GetString("mercadoria"), readerUsuario.GetString("peso"), readerUsuario.GetString("embalagem"), readerUsuario.GetString("observacao"), readerUsuario.GetString("frota"), readerUsuario.GetString("sstatus"), readerUsuario.GetString("margem")));
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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, permissao);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {
                CadastroEmbarque cadastroEmbarque = new CadastroEmbarque(usuarioLogado, contexto);
                cadastroEmbarque.ShowDialog();
                leEmbarque(contexto);
                organizaDados();
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, permissao);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {                                       
                if (lv_embarque.SelectedIndices.Count <= 0)
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
                        retorno = BancoEmbarque.deletarItemEmbarque(lv_embarque.SelectedItems[0].SubItems[0].Text, lv_embarque.SelectedItems[0].SubItems[1].Text, lv_embarque.SelectedItems[0].SubItems[2].Text, lv_embarque.SelectedItems[0].SubItems[3].Text, lv_embarque.SelectedItems[0].SubItems[4].Text, lv_embarque.SelectedItems[0].SubItems[5].Text, lv_embarque.SelectedItems[0].SubItems[6].Text, lv_embarque.SelectedItems[0].SubItems[7].Text, lv_embarque.SelectedItems[0].SubItems[8].Text, lv_embarque.SelectedItems[0].SubItems[9].Text, lv_embarque.SelectedItems[0].SubItems[10].Text, lv_embarque.SelectedItems[0].SubItems[11].Text, lv_embarque.SelectedItems[0].SubItems[12].Text, lv_embarque.SelectedItems[0].SubItems[13].Text, lv_embarque.SelectedItems[0].SubItems[14].Text, lv_embarque.SelectedItems[0].SubItems[15].Text, lv_embarque.SelectedItems[0].SubItems[16].Text, lv_embarque.SelectedItems[0].SubItems[17].Text, lv_embarque.SelectedItems[0].SubItems[18].Text, lv_embarque.SelectedItems[0].SubItems[19].Text, lv_embarque.SelectedItems[0].SubItems[20].Text, lv_embarque.SelectedItems[0].SubItems[21].Text, lv_embarque.SelectedItems[0].SubItems[22].Text, lv_embarque.SelectedItems[0].SubItems[23].Text, lv_embarque.SelectedItems[0].SubItems[24].Text, lv_embarque.SelectedItems[0].SubItems[25].Text, lv_embarque.SelectedItems[0].SubItems[26].Text, lv_embarque.SelectedItems[0].SubItems[27].Text, lv_embarque.SelectedItems[0].SubItems[28].Text, lv_embarque.SelectedItems[0].SubItems[29].Text, lv_embarque.SelectedItems[0].SubItems[30].Text, lv_embarque.SelectedItems[0].SubItems[31].Text, lv_embarque.SelectedItems[0].SubItems[32].Text, lv_embarque.SelectedItems[0].SubItems[33].Text, lv_embarque.SelectedItems[0].SubItems[34].Text, lv_embarque.SelectedItems[0].SubItems[35].Text, lv_embarque.SelectedItems[0].SubItems[36].Text, lv_embarque.SelectedItems[0].SubItems[37].Text, lv_embarque.SelectedItems[0].SubItems[38].Text, contexto);
                        if (!retorno)
                        {
                            ModalErro modal2 = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                            modal2.ShowDialog();
                        }
                        else
                        {
                            retorno = BancoEmbarque.deletarItemEmbarque(lv_embarque.SelectedItems[0].SubItems[0].Text, lv_embarque.SelectedItems[0].SubItems[1].Text, lv_embarque.SelectedItems[0].SubItems[2].Text, lv_embarque.SelectedItems[0].SubItems[3].Text, lv_embarque.SelectedItems[0].SubItems[4].Text, lv_embarque.SelectedItems[0].SubItems[5].Text, lv_embarque.SelectedItems[0].SubItems[6].Text, lv_embarque.SelectedItems[0].SubItems[7].Text, lv_embarque.SelectedItems[0].SubItems[8].Text, lv_embarque.SelectedItems[0].SubItems[9].Text, lv_embarque.SelectedItems[0].SubItems[10].Text, lv_embarque.SelectedItems[0].SubItems[11].Text, lv_embarque.SelectedItems[0].SubItems[12].Text, lv_embarque.SelectedItems[0].SubItems[13].Text, lv_embarque.SelectedItems[0].SubItems[14].Text, lv_embarque.SelectedItems[0].SubItems[15].Text, lv_embarque.SelectedItems[0].SubItems[16].Text, lv_embarque.SelectedItems[0].SubItems[17].Text, lv_embarque.SelectedItems[0].SubItems[18].Text, lv_embarque.SelectedItems[0].SubItems[19].Text, lv_embarque.SelectedItems[0].SubItems[20].Text, lv_embarque.SelectedItems[0].SubItems[21].Text, lv_embarque.SelectedItems[0].SubItems[22].Text, lv_embarque.SelectedItems[0].SubItems[23].Text, lv_embarque.SelectedItems[0].SubItems[24].Text, lv_embarque.SelectedItems[0].SubItems[25].Text, lv_embarque.SelectedItems[0].SubItems[26].Text, lv_embarque.SelectedItems[0].SubItems[27].Text, lv_embarque.SelectedItems[0].SubItems[28].Text, lv_embarque.SelectedItems[0].SubItems[29].Text, lv_embarque.SelectedItems[0].SubItems[30].Text, lv_embarque.SelectedItems[0].SubItems[31].Text, lv_embarque.SelectedItems[0].SubItems[32].Text, lv_embarque.SelectedItems[0].SubItems[33].Text, lv_embarque.SelectedItems[0].SubItems[34].Text, lv_embarque.SelectedItems[0].SubItems[35].Text, lv_embarque.SelectedItems[0].SubItems[36].Text, lv_embarque.SelectedItems[0].SubItems[37].Text, lv_embarque.SelectedItems[0].SubItems[38].Text, "embarqueTodos");
                            retorno = leEmbarque(contexto);
                            organizaDados();
                            if (!retorno)
                            {
                                ModalErro modal3 = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                                modal3.ShowDialog();
                            }
                            else
                            {
                                ModalSucesso modal4 = new ModalSucesso("Sucesso!", "Deletado com sucesso!");
                                modal4.ShowDialog();
                            }
                        }
                    }
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int nivelPermissao = BancoUsuario.lePermissaoUsuario(usuarioLogado, permissao);
            if (nivelPermissao != 1)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Você não tem permissão para isso!");
                modal.ShowDialog();
            }
            else
            {
                if (lv_embarque.SelectedIndices.Count <= 0)
                {
                    ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item");
                    modal.ShowDialog();
                }
                else
                {
                    EmbarqueEditar embarque = new EmbarqueEditar(lv_embarque.SelectedItems[0].SubItems[0].Text, lv_embarque.SelectedItems[0].SubItems[1].Text, lv_embarque.SelectedItems[0].SubItems[2].Text, lv_embarque.SelectedItems[0].SubItems[3].Text, lv_embarque.SelectedItems[0].SubItems[4].Text, lv_embarque.SelectedItems[0].SubItems[5].Text, lv_embarque.SelectedItems[0].SubItems[6].Text, lv_embarque.SelectedItems[0].SubItems[7].Text, lv_embarque.SelectedItems[0].SubItems[8].Text, lv_embarque.SelectedItems[0].SubItems[9].Text, lv_embarque.SelectedItems[0].SubItems[10].Text, lv_embarque.SelectedItems[0].SubItems[11].Text, lv_embarque.SelectedItems[0].SubItems[12].Text, lv_embarque.SelectedItems[0].SubItems[13].Text, lv_embarque.SelectedItems[0].SubItems[14].Text, lv_embarque.SelectedItems[0].SubItems[15].Text, lv_embarque.SelectedItems[0].SubItems[16].Text, lv_embarque.SelectedItems[0].SubItems[17].Text, lv_embarque.SelectedItems[0].SubItems[18].Text, lv_embarque.SelectedItems[0].SubItems[19].Text, lv_embarque.SelectedItems[0].SubItems[20].Text, lv_embarque.SelectedItems[0].SubItems[21].Text, lv_embarque.SelectedItems[0].SubItems[22].Text, lv_embarque.SelectedItems[0].SubItems[23].Text, lv_embarque.SelectedItems[0].SubItems[24].Text, lv_embarque.SelectedItems[0].SubItems[26].Text, lv_embarque.SelectedItems[0].SubItems[27].Text, lv_embarque.SelectedItems[0].SubItems[28].Text, lv_embarque.SelectedItems[0].SubItems[29].Text, lv_embarque.SelectedItems[0].SubItems[30].Text, lv_embarque.SelectedItems[0].SubItems[31].Text, lv_embarque.SelectedItems[0].SubItems[32].Text, lv_embarque.SelectedItems[0].SubItems[33].Text, lv_embarque.SelectedItems[0].SubItems[34].Text, lv_embarque.SelectedItems[0].SubItems[35].Text, lv_embarque.SelectedItems[0].SubItems[36].Text, lv_embarque.SelectedItems[0].SubItems[37].Text, lv_embarque.SelectedItems[0].SubItems[38].Text, contexto, usuarioLogado);
                    embarque.ShowDialog();
                    Boolean semUso = leEmbarque(contexto);
                    organizaDados();
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
                if (lv_embarque.SelectedIndices.Count <= 0)
                {
                    ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item");
                    modal.ShowDialog();
                }
                else
                {
                    retorno = BancoUsuario.obterUsuarioEmbarque(lv_embarque.SelectedItems[0].SubItems[0].Text, lv_embarque.SelectedItems[0].SubItems[1].Text, lv_embarque.SelectedItems[0].SubItems[2].Text, lv_embarque.SelectedItems[0].SubItems[3].Text, lv_embarque.SelectedItems[0].SubItems[4].Text, lv_embarque.SelectedItems[0].SubItems[5].Text, lv_embarque.SelectedItems[0].SubItems[6].Text, lv_embarque.SelectedItems[0].SubItems[7].Text, lv_embarque.SelectedItems[0].SubItems[8].Text, lv_embarque.SelectedItems[0].SubItems[9].Text, lv_embarque.SelectedItems[0].SubItems[10].Text, lv_embarque.SelectedItems[0].SubItems[11].Text, lv_embarque.SelectedItems[0].SubItems[12].Text, lv_embarque.SelectedItems[0].SubItems[13].Text, lv_embarque.SelectedItems[0].SubItems[14].Text, lv_embarque.SelectedItems[0].SubItems[15].Text, lv_embarque.SelectedItems[0].SubItems[16].Text, lv_embarque.SelectedItems[0].SubItems[17].Text, lv_embarque.SelectedItems[0].SubItems[18].Text, lv_embarque.SelectedItems[0].SubItems[19].Text, lv_embarque.SelectedItems[0].SubItems[20].Text, lv_embarque.SelectedItems[0].SubItems[21].Text, lv_embarque.SelectedItems[0].SubItems[22].Text, lv_embarque.SelectedItems[0].SubItems[23].Text, lv_embarque.SelectedItems[0].SubItems[24].Text, lv_embarque.SelectedItems[0].SubItems[25].Text, lv_embarque.SelectedItems[0].SubItems[26].Text, lv_embarque.SelectedItems[0].SubItems[27].Text, lv_embarque.SelectedItems[0].SubItems[28].Text, lv_embarque.SelectedItems[0].SubItems[29].Text, lv_embarque.SelectedItems[0].SubItems[30].Text, lv_embarque.SelectedItems[0].SubItems[31].Text, lv_embarque.SelectedItems[0].SubItems[32].Text, lv_embarque.SelectedItems[0].SubItems[33].Text, lv_embarque.SelectedItems[0].SubItems[34].Text, lv_embarque.SelectedItems[0].SubItems[35].Text, lv_embarque.SelectedItems[0].SubItems[36].Text, lv_embarque.SelectedItems[0].SubItems[37].Text, lv_embarque.SelectedItems[0].SubItems[38].Text, contexto);
                }
            }
        }

        private void lv_embarque_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            MessageBox.Show(e.ToString(), "fffffffffffffffff");
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

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
