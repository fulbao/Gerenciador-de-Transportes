using Gerenciador_de_Transportes.ConexaoBanco;
using Gerenciador_de_Transportes.ConexaoBanco.BancoSelects;
using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class EmbarqueEditar : Form
    {
        string contexto;

        List<VeiculoCs> veiculos = new List<VeiculoCs>();

        List<PedidoCs> pedidos = new List<PedidoCs>();

        string[] listaEmbarcadores = new string[1000];

        string[] itens = new string[12];

        string usuarioLogado;

        int j = 0;

        string empresa, filial, unidadeEmbarque, cidadeOrigem, estadoOrigem, cidadeDestino, estadoDestino, pedido, previsaoEmbarque, dataEmbarque, previsaoEntrega, dataEntrega, aceite, status, placaCavalo, placaCarreta, placaCarretaDois, proprietario, motorista, freteFiscal, icms, freteMotorista, adicional, pedagio, classificacao, adiantamento, meioPagamento, meioPagamentoDois, km, cliente, embarcador, destinatario, load, mercadoria, peso, embalagem, observacao, frota;

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

        public EmbarqueEditar(string empresa, string filial, string unidadeEmbarque, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino, string pedido, string previsaoEmbarque, string dataEmbarque, string previsaoEntrega, string dataEntrega, string aceite, string status, string placaCavalo, string placaCarreta, string placaCarretaDois, string proprietario, string motorista, string freteFiscal, string icms, string freteMotorista, string adicional, string pedagio, string classificacao, string adiantamento, string meioPagamento, string meioPagamentoDois, string km, string cliente, string embarcador, string destinatario, string load, string mercadoria, string peso, string embalagem, string observacao, string frota, string contexto, string usuario)
        {
            InitializeComponent();

            usuarioLogado = usuario;

            if (dataEntrega == "")
            {
                tb_dataEntrega.Format = DateTimePickerFormat.Custom;
                tb_dataEntrega.CustomFormat = " ";
            }
            else
            {
                this.dataEntrega = dataEntrega;
                tb_dataEntrega.Text = dataEntrega;
            }
            if (dataEmbarque == "")
            {
                tb_dataEmbarque.Format = DateTimePickerFormat.Custom;
                tb_dataEmbarque.CustomFormat = " ";
            }
            else
            {
                this.dataEmbarque = dataEmbarque;
                tb_dataEmbarque.Text = dataEmbarque;
            }

            tb_previsaoEmbarque.Text = previsaoEmbarque;
            tb_previsaoEntrega.Text = previsaoEntrega;
            Boolean retorno = retornaPedido();

            List<PedidoCs> SortedListPedidos = pedidos.OrderBy(p => Convert.ToInt32(p.Pedido)).ToList();

            pedidos.Clear();

            pedidos = SortedListPedidos;

            if (!retorno)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal.ShowDialog();
            }
            else
            {
                sl_pedido.Items.Add("Selecionar");
                for (int i = 0; i < pedidos.Count; i++)
                {
                    sl_pedido.SelectedIndex = 0;
                    sl_pedido.Items.Add(pedidos[i].Pedido);
                    tb_freteFiscal.Text = "Selecione Pedido";
                    tb_icms.Text = "Selecione Pedido";
                    tb_pedagio.Text = "Selecione Pedido";
                    tb_classificacao.Text = "Selecione Pedido";
                    tb_km.Text = "Selecione Pedido";
                    tb_cliente.Text = "Selecione Pedido";
                    tb_embarcador.Text = "Selecione Pedido";
                    tb_estadoOrigem.Text = "Selecione Pedido";
                    tb_destinatario.Text = "Selecione Pedido";
                    tb_estadoDestino.Text = "Selecione Pedido";
                    tb_freteMotorista.Text = "Selecione Pedido";
                    tb_cidadeOrigem.Text = "Selecione Pedido";
                    tb_cidadeDestino.Text = "Selecione Pedido";
                }
            }

            retorno = retornaVeiculo();

            if (!retorno)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                modal.ShowDialog();
            }
            else
            {
                List<VeiculoCs> SortedList = veiculos.OrderBy(o => o.PlacaCavalo).ToList();

                veiculos.Clear();

                veiculos = SortedList;

                sl_placaCavalo.Items.Add("Selecionar");
                for (int i = 0; i < veiculos.Count; i++)
                {
                    sl_placaCavalo.SelectedIndex = 0;
                    sl_placaCavalo.Items.Add(veiculos[i].PlacaCavalo);
                    tb_placaCarreta.Text = "Selecione Placa Cavalo";
                    tb_placaCarretaDois.Text = "Selecione Placa Cavalo";
                    tb_proprietario.Text = "Selecione Placa Cavalo";
                    tb_motorista.Text = "Selecione Placa Cavalo";
                }
            }
            string selecionado;
            selecionado = sl_pedido.Text;

            for (int i = 0; i < pedidos.Count; i++)
            {
                if (selecionado == pedidos[i].Pedido)
                {
                    tb_freteFiscal.Text = pedidos[i].FreteFiscal;
                    tb_icms.Text = pedidos[i].Icms;
                    tb_pedagio.Text = pedidos[i].Pedagio;
                    tb_classificacao.Text = pedidos[i].Classificacao;
                    tb_km.Text = pedidos[i].Km;
                    tb_cliente.Text = pedidos[i].Cliente;
                    tb_embarcador.Text = pedidos[i].Embarcador;
                    tb_estadoOrigem.Text = pedidos[i].EstadoEmbarcador;
                    tb_destinatario.Text = pedidos[i].Destinatario;
                    tb_estadoDestino.Text = pedidos[i].EstadoDestinatario;
                    tb_freteMotorista.Text = pedidos[i].FreteMotorista;
                    tb_cidadeOrigem.Text = pedidos[i].CidadeOrigem;
                    tb_cidadeDestino.Text = pedidos[i].CidadeDestino;
                    i = pedidos.Count;
                }
            }

            selecionado = sl_placaCavalo.Text;
            tb_motorista.Enabled = true;

            for (int i = 0; i < veiculos.Count; i++)
            {
                if (selecionado == veiculos[i].PlacaCavalo)
                {
                    tb_placaCarreta.Text = veiculos[i].PlacaCarreta;
                    tb_placaCarretaDois.Text = veiculos[i].PlacaCarretaSegunda;
                    tb_proprietario.Text = veiculos[i].Proprietario;
                    tb_motorista.Text = veiculos[i].Motorista;
                    i = veiculos.Count;
                }
            }
            Boolean semUso = leMotoristas(sl_placaCavalo.Text);
            for (int i = 0; i < 12; i++)
            {
                if (itens[i] != null)
                {
                    if (itens[i] != "")
                    {
                        tb_motorista.Items.Add(itens[i]);
                    }
                }
            }

            this.pedido = pedido;
            this.placaCavalo = placaCavalo;
            this.unidadeEmbarque = unidadeEmbarque;
            this.status = status;
            this.proprietario = proprietario;
            this.placaCarretaDois = placaCarretaDois;
            this.placaCarreta = placaCarreta;
            this.peso = peso;
            this.pedagio = pedagio;
            this.observacao = observacao;
            this.motorista = motorista;
            this.mercadoria = mercadoria;
            this.meioPagamentoDois = meioPagamentoDois;
            this.meioPagamento = meioPagamento;
            this.load = load;
            this.km = km;
            this.icms = icms;
            this.frota = frota;
            this.freteMotorista = freteMotorista;
            this.freteFiscal = freteFiscal;
            this.filial = filial;
            this.estadoOrigem = estadoOrigem;
            this.estadoDestino = estadoDestino;
            this.empresa = empresa;
            this.embarcador = embarcador;
            this.embalagem = embalagem;
            this.destinatario = destinatario;
            this.cliente = cliente;
            this.classificacao = classificacao;
            this.cidadeOrigem = cidadeOrigem;
            this.cidadeDestino = cidadeDestino;
            this.adicional = adicional;
            this.adiantamento = adiantamento;
            this.aceite = aceite;
            this.previsaoEmbarque = previsaoEmbarque;
            this.previsaoEntrega = previsaoEntrega;
            sl_pedido.Text = pedido;
            sl_placaCavalo.Text = placaCavalo;
            tb_unidadeDeEmbarque.Text = unidadeEmbarque;
            tb_status.Text = status;
            tb_proprietario.Text = proprietario;
            tb_placaCarretaDois.Text = placaCarretaDois;
            tb_placaCarreta.Text = placaCarreta;
            tb_peso.Text = peso;
            tb_pedagio.Text = pedagio;
            tb_observacao.Text = observacao;
            tb_motorista.Text = motorista;
            tb_mercadoria.Text = mercadoria;
            tb_meioPagamentoDois.Text = meioPagamentoDois;
            tb_meioPagamento.Text = meioPagamento;
            tb_load.Text = load;
            tb_km.Text = km;
            tb_icms.Text = icms;
            tb_frota.Text = frota;
            tb_freteMotorista.Text = freteMotorista;
            tb_freteFiscal.Text = freteFiscal;
            tb_filial.Text = filial;
            tb_estadoOrigem.Text = estadoOrigem;
            tb_estadoDestino.Text = estadoDestino;
            tb_Empresa.Text = empresa;
            tb_embarcador.Text = embarcador;
            tb_embalagem.Text = embalagem;
            tb_destinatario.Text = destinatario;
            tb_cliente.Text = cliente;
            tb_classificacao.Text = classificacao;
            tb_cidadeOrigem.Text = cidadeOrigem;
            tb_cidadeDestino.Text = cidadeDestino;
            tb_adicional.Text = adicional;
            tb_adiantamento.Text = adiantamento;
            tb_aceite.Text = aceite;
            this.contexto = contexto;
            leSelects();
        }

        private void EmbarqueEditar_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (veiculos[i].PlacaCavalo == placaCavalo)
                {
                    sl_placaCavalo.SelectedIndex = i + 1;
                    i = veiculos.Count;
                }
            }

            for (int i = 0; i < pedidos.Count; i++)
            {
                if (pedidos[i].Pedido == pedido)
                {
                    sl_pedido.SelectedIndex = i + 1;
                    i = pedidos.Count;
                }
            }
        }

        public void leSelects()
        {
            List<String> empresas = BancoEmpresas.leEmpresas();

            tb_Empresa.Items.Add("Selecione");
            for (int i = 0; i < empresas.Count; i++)
            {
                tb_Empresa.Items.Add(empresas[i]);
            }

            for (int i = 0;i < empresas.Count; i++)
            {
                if (this.empresa == empresas[i])
                {
                    tb_Empresa.SelectedIndex = i + 1;
                }
            }

            List<String> filial = BancoFilial.leFilial();

            tb_filial.Items.Add("Selecione");
            for (int i = 0; i < filial.Count; i++)
            {
                tb_filial.Items.Add(filial[i]);
            }

            for (int i = 0; i < filial.Count; i++)
            {
                if (this.filial == filial[i])
                {
                    tb_filial.SelectedIndex = i + 1;
                }
            }

            List<String> embalagem = BancoEmbalagem.leEmbalagem();

            tb_embalagem.Items.Add("Selecione");
            for (int i = 0; i < embalagem.Count; i++)
            {
                tb_embalagem.Items.Add(embalagem[i]);
            }

            for (int i = 0; i < embalagem.Count; i++)
            {
                if (this.embalagem == embalagem[i])
                {
                    tb_embalagem.SelectedIndex = i + 1;
                }
            }

            List<String> meioPagamento = BancoMeioPagamento.leMeioPagamento();

            tb_meioPagamento.Items.Add("Selecione");
            tb_meioPagamentoDois.Items.Add("Selecione");
            for (int i = 0; i < meioPagamento.Count; i++)
            {
                tb_meioPagamento.Items.Add(meioPagamento[i]);
                tb_meioPagamentoDois.Items.Add(meioPagamento[i]);
            }

            for (int i = 0; i < meioPagamento.Count; i++)
            {
                if (this.meioPagamento == meioPagamento[i])
                {
                    tb_meioPagamento.SelectedIndex = i + 1;
                }

                if (this.meioPagamentoDois == meioPagamento[i])
                {
                    tb_meioPagamentoDois.SelectedIndex = i + 1;
                }
            }

            List<String> status = BancoStatus.leStatus();

            tb_status.Items.Add("Selecione");
            for (int i = 0; i < status.Count; i++)
            {
                tb_status.Items.Add(status[i]);
            }

            for (int i = 0; i < status.Count; i++)
            {
                if (this.status == status[i])
                {
                    tb_status.SelectedIndex = i + 1;
                }
            }

            List<String> unidadeEmbarque = BancoUnidadeEmbarque.leUnidadeEmbarque();

            tb_unidadeDeEmbarque.Items.Add("Selecione");
            for (int i = 0; i < unidadeEmbarque.Count; i++)
            {
                tb_unidadeDeEmbarque.Items.Add(unidadeEmbarque[i]);
            }

            for (int i = 0; i < unidadeEmbarque.Count; i++)
            {
                if (this.unidadeEmbarque == unidadeEmbarque[i])
                {
                    tb_unidadeDeEmbarque.SelectedIndex = i + 1;
                }
            }
        }

        public bool leMotoristas(string placa)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.veiculos WHERE placaCavalo = '" + placa + "'";
                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();
                if (!readerUsuario.HasRows) { return true; }
                readerUsuario.Read();

                itens[0] = readerUsuario.GetString(5);

                itens[1] = readerUsuario.GetString(6);

                itens[2] = readerUsuario.GetString(7);

                itens[3] = readerUsuario.GetString(8);

                itens[4] = readerUsuario.GetString(9);

                itens[5] = readerUsuario.GetString(10);

                itens[6] = readerUsuario.GetString(11);

                itens[7] = readerUsuario.GetString(12);

                itens[8] = readerUsuario.GetString(13);

                itens[9] = readerUsuario.GetString(14);

                itens[10] = readerUsuario.GetString(15);

                itens[11] = readerUsuario.GetString(16);

                conn.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
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
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
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
            sl_pedido.SelectedIndex = 0;
            sl_placaCavalo.SelectedIndex = 0;
            tb_unidadeDeEmbarque.SelectedIndex = 0;
            tb_status.SelectedIndex = 0;
            tb_proprietario.Clear();
            tb_placaCarretaDois.Clear();
            tb_placaCarreta.Clear();
            tb_peso.Clear();
            tb_pedagio.Clear();
            tb_observacao.Clear();
            tb_motorista.SelectedIndex = 0;
            tb_mercadoria.Clear();
            tb_meioPagamentoDois.SelectedIndex = 0;
            tb_meioPagamento.SelectedIndex = 0;
            tb_load.Clear();
            tb_km.Clear();
            tb_icms.Clear();
            tb_frota.SelectedIndex = 0;
            tb_freteMotorista.Clear();
            tb_freteFiscal.Clear();
            tb_filial.SelectedIndex = 0;
            tb_estadoOrigem.Clear();
            tb_estadoDestino.Clear();
            tb_Empresa.SelectedIndex = 0;
            tb_embarcador.Clear();
            tb_embalagem.SelectedIndex = 0;
            tb_destinatario.Clear();
            tb_cliente.Clear();
            tb_classificacao.Clear();
            tb_cidadeOrigem.Clear();
            tb_cidadeDestino.Clear();
            tb_adicional.Clear();
            tb_adiantamento.Clear();
            tb_aceite.SelectedIndex = 0;

        }

        public Boolean retornaVeiculo()
        {
            j = 0;
            try
            {
                for (int i = 0; i > -1; i++)
                {
                    string deletado;
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.veiculos WHERE id = " + (i + 1).ToString();
                    usuarioQuery.CommandType = CommandType.Text;
                    usuarioQuery.Connection = conn;

                    conn.Open();

                    readerUsuario = usuarioQuery.ExecuteReader();
                    readerUsuario.Read();


                    if (!readerUsuario.HasRows)
                    {
                        return true;
                    }
                    deletado = readerUsuario.GetString(18);

                    if (deletado == "False")
                    {
                        veiculos.Add(new VeiculoCs(readerUsuario.GetString(1).Trim(' '), readerUsuario.GetString(2), readerUsuario.GetString(3), readerUsuario.GetString(4), readerUsuario.GetString(5)));
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

        public Boolean retornaPedido()
        {
            j = 0;
            try
            {
                for (int i = 0; i > -1; i++)
                {
                    string deletado;
                    MySqlConnection conne = new MySqlConnection("server=localhost;uid=root;pwd=root");
                    MySqlCommand usuarioQuerye = new MySqlCommand();
                    MySqlDataReader readerUsuarioe;

                    usuarioQuerye.CommandText = "SELECT * FROM gerenciadortransportes.pedido WHERE id = " + (i + 1).ToString();
                    usuarioQuerye.CommandType = CommandType.Text;
                    usuarioQuerye.Connection = conne;

                    conne.Open();

                    readerUsuarioe = usuarioQuerye.ExecuteReader();
                    readerUsuarioe.Read();


                    if (!readerUsuarioe.HasRows)
                    {
                        return true;
                    }
                    deletado = readerUsuarioe.GetString(17);

                    if (deletado == "False")
                    {
                        pedidos.Add(new PedidoCs(readerUsuarioe.GetString(1).Trim(' '), readerUsuarioe.GetString(2), readerUsuarioe.GetString(3), readerUsuarioe.GetString(4), readerUsuarioe.GetString(5), readerUsuarioe.GetString(6), readerUsuarioe.GetString(7), readerUsuarioe.GetString(8), readerUsuarioe.GetString(9), readerUsuarioe.GetString(10), readerUsuarioe.GetString(11), readerUsuarioe.GetString(12), readerUsuarioe.GetString(13), readerUsuarioe.GetString(14), readerUsuarioe.GetString(15)));
                    }

                    conne.Close();


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
            Boolean retorno;
            if ((sl_pedido.Text == "Selecionador") || (sl_placaCavalo.Text == "Selecionador"))
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Preencha todos os campos!");
                modal.ShowDialog();
            }
            else
            {
                string ff = tb_freteFiscal.Text.Trim(new Char[] { ' ', 'R', '$' });
                string fm = tb_freteMotorista.Text.Trim(new Char[] { ' ', 'R', '$' });
                string ad = tb_adiantamento.Text.Trim(new Char[] { ' ', 'R', '$' });
                double freteFFiscal;
                if (ff.Length == 0)
                {
                    freteFFiscal = 0;
                }
                else
                {
                    freteFFiscal = Convert.ToDouble(ff);
                }

                double freteMotorista;

                if (fm.Length == 0)
                {
                    freteMotorista = 0;
                }
                else
                {
                    freteMotorista = Convert.ToDouble(fm);
                }

                double adt;
                if (ad.Length == 0)
                {
                    adt = 0;
                }
                else
                {
                    adt = Convert.ToDouble(ad);
                }
                double margem = ((freteFFiscal - freteMotorista - adt) / (freteFFiscal)) * 100;

                retorno = BancoEmbarque.alterarItemEmbarque(empresa, filial, unidadeEmbarque, cidadeOrigem, estadoOrigem, cidadeDestino, estadoDestino, pedido, previsaoEmbarque, dataEmbarque, previsaoEntrega, dataEntrega, aceite, status, placaCavalo, placaCarreta, placaCarretaDois, proprietario, motorista, freteFiscal, icms, fm, adicional, pedagio, classificacao, adiantamento, meioPagamento, meioPagamentoDois, km, cliente, embarcador, destinatario, load, mercadoria, peso, embalagem, observacao, frota, tb_Empresa.Text, tb_filial.Text, tb_unidadeDeEmbarque.Text, tb_cidadeOrigem.Text, tb_estadoOrigem.Text, tb_cidadeDestino.Text, tb_estadoDestino.Text, sl_pedido.Text, tb_previsaoEmbarque.Text, tb_dataEmbarque.Text, tb_previsaoEntrega.Text, tb_dataEntrega.Text, tb_aceite.Text, tb_status.Text, sl_placaCavalo.Text, tb_placaCarreta.Text, tb_placaCarretaDois.Text, tb_proprietario.Text, tb_motorista.Text, tb_freteFiscal.Text, tb_icms.Text, tb_freteMotorista.Text, tb_adicional.Text, tb_pedagio.Text, tb_classificacao.Text, margem.ToString(), tb_adiantamento.Text, tb_meioPagamento.Text, tb_meioPagamentoDois.Text, tb_km.Text, tb_cliente.Text, tb_embarcador.Text, tb_destinatario.Text, tb_load.Text, tb_mercadoria.Text, tb_peso.Text, tb_embalagem.Text, tb_observacao.Text, tb_frota.Text, "embarqueTodos", usuarioLogado);
                retorno = BancoEmbarque.alterarItemEmbarque(empresa, filial, unidadeEmbarque, cidadeOrigem, estadoOrigem, cidadeDestino, estadoDestino, pedido, previsaoEmbarque, dataEmbarque, previsaoEntrega, dataEntrega, aceite, status, placaCavalo, placaCarreta, placaCarretaDois, proprietario, motorista, freteFiscal, icms, fm, adicional, pedagio, classificacao, adiantamento, meioPagamento, meioPagamentoDois, km, cliente, embarcador, destinatario, load, mercadoria, peso, embalagem, observacao, frota, tb_Empresa.Text, tb_filial.Text, tb_unidadeDeEmbarque.Text, tb_cidadeOrigem.Text, tb_estadoOrigem.Text, tb_cidadeDestino.Text, tb_estadoDestino.Text, sl_pedido.Text, tb_previsaoEmbarque.Text, tb_dataEmbarque.Text, tb_previsaoEntrega.Text, tb_dataEntrega.Text, tb_aceite.Text, tb_status.Text, sl_placaCavalo.Text, tb_placaCarreta.Text, tb_placaCarretaDois.Text, tb_proprietario.Text, tb_motorista.Text, tb_freteFiscal.Text, tb_icms.Text, tb_freteMotorista.Text, tb_adicional.Text, tb_pedagio.Text, tb_classificacao.Text, margem.ToString(), tb_adiantamento.Text, tb_meioPagamento.Text, tb_meioPagamentoDois.Text, tb_km.Text, tb_cliente.Text, tb_embarcador.Text, tb_destinatario.Text, tb_load.Text, tb_mercadoria.Text, tb_peso.Text, tb_embalagem.Text, tb_observacao.Text, tb_frota.Text, contexto, usuarioLogado);
                if (!retorno)
                {
                    ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal.ShowDialog();
                }
                else
                {
                    ModalSucesso modal = new ModalSucesso("Atenção!", "Dados cadastrados com sucesso!");
                    modal.ShowDialog();
                    this.Close();
                }
            }
        }

        private void sl_placaCavalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecionado;
            selecionado = sl_placaCavalo.Text;
            tb_motorista.Enabled = true;

            for (int i = 0; i < veiculos.Count; i++)
            {
                if (selecionado == veiculos[i].PlacaCavalo)
                {
                    tb_placaCarreta.Text = veiculos[i].PlacaCarreta;
                    tb_placaCarretaDois.Text = veiculos[i].PlacaCarretaSegunda;
                    tb_proprietario.Text = veiculos[i].Proprietario;
                    tb_motorista.Text = veiculos[i].Motorista;
                    i = veiculos.Count;
                }
            }
            Boolean semUso = leMotoristas(sl_placaCavalo.Text);
            for (int i = 0; i < 12; i++)
            {
                if (itens[i] != null)
                {
                    if (itens[i] != "")
                    {
                        tb_motorista.Items.Add(itens[i]);
                    }
                }
            }
        }

        private void sl_pedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecionado;
            selecionado = sl_pedido.Text;

            for (int i = 0; i < pedidos.Count; i++)
            {
                if (selecionado == pedidos[i].Pedido)
                {
                    tb_freteFiscal.Text = pedidos[i].FreteFiscal;
                    tb_icms.Text = pedidos[i].Icms;
                    tb_pedagio.Text = pedidos[i].Pedagio;
                    tb_classificacao.Text = pedidos[i].Classificacao;
                    tb_km.Text = pedidos[i].Km;
                    tb_cliente.Text = pedidos[i].Cliente;
                    tb_embarcador.Text = pedidos[i].Embarcador;
                    tb_estadoOrigem.Text = pedidos[i].EstadoEmbarcador;
                    tb_destinatario.Text = pedidos[i].Destinatario;
                    tb_estadoDestino.Text = pedidos[i].EstadoDestinatario;
                    tb_freteMotorista.Text = pedidos[i].FreteMotorista;
                    tb_cidadeOrigem.Text = pedidos[i].CidadeOrigem;
                    tb_cidadeDestino.Text = pedidos[i].CidadeDestino;
                    i = pedidos.Count;
                }
            }
        }

        private void tb_adiantamento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_adicional_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_peso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_km_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_dataEmbarque_ValueChanged(object sender, EventArgs e)
        {
            tb_dataEmbarque.Format = DateTimePickerFormat.Short;
        }

        private void tb_dataEntrega_ValueChanged(object sender, EventArgs e)
        {
            tb_dataEntrega.Format = DateTimePickerFormat.Short;
        }

        private void tb_pedagio_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
