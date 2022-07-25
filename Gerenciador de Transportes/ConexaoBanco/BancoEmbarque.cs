using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    internal class BancoEmbarque
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void criarTabelaEmbarque()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

            Conexao.Open();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.embarqueGloria" +
                                            "(id integer auto_increment primary key," +
                                            "empresa char(40)," +
                                            "filial char(40)," +
                                            "unidadeEmbarque char(40)," +
                                            "cidadeOrigem char(40)," +
                                            "estadoOrigem char(40)," +
                                            "cidadeDestino char(40)," +
                                            "estadoDestino char(40)," +
                                            "pedido char(40)," +
                                            "previsaoEmbarque char(40)," +
                                            "dataEmbarque char(40)," +
                                            "previsaoEntrega char(40)," +
                                            "dataEntrega char(40)," +
                                            "aceite char(40)," +
                                            "sstatus char(40)," +
                                            "placaCavalo char(40)," +
                                            "placaCarreta char(40)," +
                                            "placaSegundaCarreta char(40)," +
                                            "proprietario char(40)," +
                                            "motorista char(40)," +
                                            "freteFiscal char(40)," +
                                            "icms char(40)," +
                                            "freteMotorista char(40)," +
                                            "adicional char(40)," +
                                            "pedagio char(40)," +
                                            "classificacao char(40)," +
                                            "margem char(40)," +
                                            "adiantamento char(40)," +
                                            "meioPagamento char(40)," +
                                            "meioPagamentoDois char(40)," +
                                            "km char(40)," +
                                            "cliente char(40)," +
                                            "embarcador char(40)," +
                                            "destinatario char(40)," +
                                            "lload char(40)," +
                                            "mercadoria char(40)," +
                                            "peso char(40)," +
                                            "embalagem char(40)," +
                                            "observacao char(100)," +
                                            "frota char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean)", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.embarqueParanavai" +
                                           "(id integer auto_increment primary key," +
                                           "empresa char(40)," +
                                           "filial char(40)," +
                                           "unidadeEmbarque char(40)," +
                                           "cidadeOrigem char(40)," +
                                           "estadoOrigem char(40)," +
                                           "cidadeDestino char(40)," +
                                           "estadoDestino char(40)," +
                                           "pedido char(40)," +
                                           "previsaoEmbarque char(40)," +
                                           "dataEmbarque char(40)," +
                                           "previsaoEntrega char(40)," +
                                           "dataEntrega char(40)," +
                                           "aceite char(40)," +
                                           "sstatus char(40)," +
                                           "placaCavalo char(40)," +
                                           "placaCarreta char(40)," +
                                           "placaSegundaCarreta char(40)," +
                                           "proprietario char(40)," +
                                           "motorista char(40)," +
                                           "freteFiscal char(40)," +
                                           "icms char(40)," +
                                           "freteMotorista char(40)," +
                                           "adicional char(40)," +
                                           "pedagio char(40)," +
                                           "classificacao char(40)," +
                                           "margem char(40)," +
                                           "adiantamento char(40)," +
                                           "meioPagamento char(40)," +
                                           "meioPagamentoDois char(40)," +
                                           "km char(40)," +
                                           "cliente char(40)," +
                                           "embarcador char(40)," +
                                           "destinatario char(40)," +
                                           "lload char(40)," +
                                           "mercadoria char(40)," +
                                           "peso char(40)," +
                                           "embalagem char(40)," +
                                           "observacao char(100)," +
                                           "frota char(40)," +
                                           "usuario char(40)," +
                                           "deletado boolean)", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.embarqueToledo" +
                                           "(id integer auto_increment primary key," +
                                           "empresa char(40)," +
                                           "filial char(40)," +
                                           "unidadeEmbarque char(40)," +
                                           "cidadeOrigem char(40)," +
                                           "estadoOrigem char(40)," +
                                           "cidadeDestino char(40)," +
                                           "estadoDestino char(40)," +
                                           "pedido char(40)," +
                                           "previsaoEmbarque char(40)," +
                                           "dataEmbarque char(40)," +
                                           "previsaoEntrega char(40)," +
                                           "dataEntrega char(40)," +
                                           "aceite char(40)," +
                                           "sstatus char(40)," +
                                           "placaCavalo char(40)," +
                                           "placaCarreta char(40)," +
                                           "placaSegundaCarreta char(40)," +
                                           "proprietario char(40)," +
                                           "motorista char(40)," +
                                           "freteFiscal char(40)," +
                                           "icms char(40)," +
                                           "freteMotorista char(40)," +
                                           "adicional char(40)," +
                                           "pedagio char(40)," +
                                           "classificacao char(40)," +
                                           "margem char(40)," +
                                           "adiantamento char(40)," +
                                           "meioPagamento char(40)," +
                                           "meioPagamentoDois char(40)," +
                                           "km char(40)," +
                                           "cliente char(40)," +
                                           "embarcador char(40)," +
                                           "destinatario char(40)," +
                                           "lload char(40)," +
                                           "mercadoria char(40)," +
                                           "peso char(40)," +
                                           "embalagem char(40)," +
                                           "observacao char(100)," +
                                           "frota char(40)," +
                                           "usuario char(40)," +
                                           "deletado boolean)", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.embarqueRioVerde" +
                                           "(id integer auto_increment primary key," +
                                           "empresa char(40)," +
                                           "filial char(40)," +
                                           "unidadeEmbarque char(40)," +
                                           "cidadeOrigem char(40)," +
                                           "estadoOrigem char(40)," +
                                           "cidadeDestino char(40)," +
                                           "estadoDestino char(40)," +
                                           "pedido char(40)," +
                                           "previsaoEmbarque char(40)," +
                                           "dataEmbarque char(40)," +
                                           "previsaoEntrega char(40)," +
                                           "dataEntrega char(40)," +
                                           "aceite char(40)," +
                                           "sstatus char(40)," +
                                           "placaCavalo char(40)," +
                                           "placaCarreta char(40)," +
                                           "placaSegundaCarreta char(40)," +
                                           "proprietario char(40)," +
                                           "motorista char(40)," +
                                           "freteFiscal char(40)," +
                                           "icms char(40)," +
                                           "freteMotorista char(40)," +
                                           "adicional char(40)," +
                                           "pedagio char(40)," +
                                           "classificacao char(40)," +
                                           "margem char(40)," +
                                           "adiantamento char(40)," +
                                           "meioPagamento char(40)," +
                                           "meioPagamentoDois char(40)," +
                                           "km char(40)," +
                                           "cliente char(40)," +
                                           "embarcador char(40)," +
                                           "destinatario char(40)," +
                                           "lload char(40)," +
                                           "mercadoria char(40)," +
                                           "peso char(40)," +
                                           "embalagem char(40)," +
                                           "observacao char(100)," +
                                           "frota char(40)," +
                                           "usuario char(40)," +
                                           "deletado boolean)", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.embarqueTodos" +
                                            "(id integer auto_increment primary key," +
                                            "empresa char(40)," +
                                            "filial char(40)," +
                                            "unidadeEmbarque char(40)," +
                                            "cidadeOrigem char(40)," +
                                            "estadoOrigem char(40)," +
                                            "cidadeDestino char(40)," +
                                            "estadoDestino char(40)," +
                                            "pedido char(40)," +
                                            "previsaoEmbarque char(40)," +
                                            "dataEmbarque char(40)," +
                                            "previsaoEntrega char(40)," +
                                            "dataEntrega char(40)," +
                                            "aceite char(40)," +
                                            "sstatus char(40)," +
                                            "placaCavalo char(40)," +
                                            "placaCarreta char(40)," +
                                            "placaSegundaCarreta char(40)," +
                                            "proprietario char(40)," +
                                            "motorista char(40)," +
                                            "freteFiscal char(40)," +
                                            "icms char(40)," +
                                            "freteMotorista char(40)," +
                                            "adicional char(40)," +
                                            "pedagio char(40)," +
                                            "classificacao char(40)," +
                                            "margem char(40)," +
                                            "adiantamento char(40)," +
                                            "meioPagamento char(40)," +
                                            "meioPagamentoDois char(40)," +
                                            "km char(40)," +
                                            "cliente char(40)," +
                                            "embarcador char(40)," +
                                            "destinatario char(40)," +
                                            "lload char(40)," +
                                            "mercadoria char(40)," +
                                            "peso char(40)," +
                                            "embalagem char(40)," +
                                            "observacao char(100)," +
                                            "frota char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean)", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public static Boolean alterarItemEmbarque(string eEmpresa, string fFilial, string uUnidadeEmbarque, string cCidadeOrigem, string eEstadoOrigem, string cCidadeDestino, string eEstadoDestino, string pPedido, string pPrevisaoEmbarque, string dDataEmbarque, string pPrevisaoEntrega, string dDataEntrega, string aAceite, string sStatus, string pPlacaCavalo, string pPlacaCarreta, string pPlacaSegundaCarreta, string pProprietario, string mMotorista, string fFreteFiscal, string iIcms, string fFreteMotorista, string aDdicional, string pPedagio, string cClassificacao, string aAdiantamento, string mMeioPagamento, string mMeioPagamentoDois, string kKm, string cCliente, string eEmbarcador, string dDestinatario, string lLoad, string mMercadoria, string pPeso, string eMmbalagem, string oObservacao, string fFrota, string empresa, string filial, string unidadeEmbarque, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino, string pedido, string previsaoEmbarque, string dataEmbarque, string previsaoEntrega, string dataEntrega, string aceite, string status, string placaCavalo, string placaCarreta, string placaSegundaCarreta, string proprietario, string motorista, string freteFiscal, string icms, string freteMotorista, string adicional, string pedagio, string classificacao, string margem, string adiantamento, string meioPagamento, string meioPagamentoDois, string km, string cliente, string embarcador, string destinatario, string load, string mercadoria, string peso, string embalagem, string observacao, string frota, string contexto, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes." + contexto + " SET empresa = '" + empresa + "' , filial = '" + filial + "' , unidadeEmbarque = '" + unidadeEmbarque + "' , cidadeOrigem = '" + cidadeOrigem + "' , estadoOrigem = '" + estadoOrigem + "' , cidadeDestino = '" + cidadeDestino + "' , estadoDestino = '" + estadoDestino + "' , pedido = '" + pedido + "' , previsaoEmbarque = '" + previsaoEmbarque + "' , dataEmbarque = '" + dataEmbarque + "' , previsaoEntrega = '" + previsaoEntrega + "' , dataEntrega = '" + dataEntrega + "' , aceite = '" + aceite + "' , sstatus = '" + status + "' , placaCavalo= '" + placaCavalo + "' , placaCarreta= '" + placaCarreta + "' , placaSegundaCarreta= '" + placaSegundaCarreta + "' , proprietario= '" + proprietario + "' , motorista= '" + motorista + "' , freteFiscal= '" + freteFiscal + "' , icms= '" + icms + "' , freteMotorista= '" + freteMotorista + "' , adicional= '" + adicional + "' , pedagio= '" + pedagio + "' , classificacao= '" + classificacao + "' , margem= '" + margem + "' , adiantamento= '" + adiantamento + "' , meioPagamento= '" + meioPagamento + "' , meioPagamentoDois= '" + meioPagamentoDois + "' , km= '" + km + "' , cliente= '" + cliente + "' , embarcador= '" + embarcador + "' , destinatario= '" + destinatario + "' , lload= '" + load + "' , mercadoria= '" + mercadoria + "' , peso= '" + peso + "' , embalagem= '" + embalagem + "' , observacao= '" + observacao + "' , frota= '" + frota + "' , usuario= '" + usuario + "'  WHERE empresa = '" + eEmpresa + "'" +
                                           " AND filial = '" + fFilial + "' AND unidadeEmbarque = '" + uUnidadeEmbarque + "' AND cidadeOrigem = '" + cCidadeOrigem + "' AND estadoOrigem  = '" + eEstadoOrigem + "' AND cidadeDestino = '" + cCidadeDestino + "' AND estadoDestino = '" + eEstadoDestino + "' AND pedido  = '" + pPedido + "' AND previsaoEmbarque = '" + pPrevisaoEmbarque + "' AND dataEmbarque = '" + dDataEmbarque + "' AND previsaoEntrega = '" + pPrevisaoEntrega + "' AND dataEntrega = '" + dDataEntrega + "' AND aceite = '" + aAceite + "' AND sstatus = '" + sStatus + "' AND placaCavalo = '" + pPlacaCavalo + "' AND placaCarreta = '" + pPlacaCarreta + "' AND placaSegundaCarreta = '" + pPlacaSegundaCarreta + "' AND proprietario = '" + pProprietario + "' AND motorista = '" + mMotorista + "' AND freteFiscal = '" + fFreteFiscal + "' AND icms = '" + iIcms + "' AND freteMotorista = '" + fFreteMotorista + "' AND adicional = '" + aDdicional + "' AND pedagio = '" + pPedagio + "' AND classificacao = '" + cClassificacao + "' AND adiantamento = '" + aAdiantamento + "' AND meioPagamento = '" + mMeioPagamento + "' AND meioPagamentoDois = '" + mMeioPagamentoDois + "' AND km = '" + kKm + "' AND cliente  = '" + cCliente + "' AND embarcador = '" + eEmbarcador + "' AND destinatario = '" + dDestinatario + "' AND lload = '" + lLoad + "' AND mercadoria = '" + mMercadoria + "' AND peso = '" + pPeso + "' AND embalagem = '" + eMmbalagem + "' AND observacao = '" + oObservacao + "' AND frota = '" + fFrota + "';", Conexao);
               
                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean deletarItemEmbarque(string eEmpresa, string fFilial, string uUnidadeEmbarque, string cCidadeOrigem, string eEstadoOrigem, string cCidadeDestino, string eEstadoDestino, string pPedido, string pPrevisaoEmbarque, string dDataEmbarque, string pPrevisaoEntrega, string dDataEntrega, string aAceite, string sStatus, string pPlacaCavalo, string pPlacaCarreta, string pPlacaSegundaCarreta, string pProprietario, string mMotorista, string fFreteFiscal, string iIcms, string fFreteMotorista, string aDdicional, string pPedagio, string cClassificacao, string mMargem, string aAdiantamento, string mMeioPagamento, string mMeioPagamentoDois, string kKm, string cCliente, string eEmbarcador, string dDestinatario, string lLoad, string mMercadoria, string pPeso, string eMmbalagem, string oObservacao, string fFrota, string contexto)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes." + contexto + " SET deletado = true WHERE empresa = '" + eEmpresa + "'" +
                                           " AND filial = '" + fFilial + "' AND unidadeEmbarque = '" + uUnidadeEmbarque + "' AND cidadeOrigem = '" + cCidadeOrigem + "' AND estadoOrigem  = '" + eEstadoOrigem + "' AND cidadeDestino = '" + cCidadeDestino + "' AND estadoDestino = '" + eEstadoDestino + "' AND pedido  = '" + pPedido + "' AND previsaoEmbarque = '" + pPrevisaoEmbarque + "' AND dataEmbarque = '" + dDataEmbarque + "' AND previsaoEntrega = '" + pPrevisaoEntrega + "' AND dataEntrega = '" + dDataEntrega + "' AND aceite = '" + aAceite + "' AND sstatus = '" + sStatus + "' AND placaCavalo = '" + pPlacaCavalo + "' AND placaCarreta = '" + pPlacaCarreta + "' AND placaSegundaCarreta = '" + pPlacaSegundaCarreta + "' AND proprietario = '" + pProprietario + "' AND motorista = '" + mMotorista + "' AND freteFiscal = '" + fFreteFiscal + "' AND icms = '" + iIcms + "' AND freteMotorista = '" + fFreteMotorista + "' AND adicional = '" + aDdicional + "' AND pedagio = '" + pPedagio + "' AND classificacao = '" + cClassificacao + "' AND margem = '" + mMargem + "' AND adiantamento = '" + aAdiantamento + "' AND meioPagamento = '" + mMeioPagamento + "' AND meioPagamentoDois = '" + mMeioPagamentoDois + "' AND km = '" + kKm + "' AND cliente  = '" + cCliente + "' AND embarcador = '" + eEmbarcador + "' AND destinatario = '" + dDestinatario + "' AND lload = '" + lLoad + "' AND mercadoria = '" + mMercadoria + "' AND peso = '" + pPeso + "' AND embalagem = '" + eMmbalagem + "' AND observacao = '" + oObservacao + "' AND frota = '" + fFrota + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean adicionarEmbarque(string empresa, string filial, string unidadeEmbarque, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino, string pedido, string previsaoEmbarque, string dataEmbarque, string previsaoEntrega, string dataEntrega, string aceite, string status, string placaCavalo, string placaCarreta, string placaSegundaCarreta, string proprietario, string motorista, string freteFiscal, string icms, string freteMotorista, string adicional, string pedagio, string classificacao, string margem, string adiantamento, string meioPagamento, string meioPagamentoDois, string km, string cliente, string embarcador, string destinatario, string load, string mercadoria, string peso, string embalagem, string observacao, string frota, string usuario, string contexto)
        {
            margem = margem + " %";

            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes." + contexto + "(empresa," +
                                            "filial," +
                                            "unidadeEmbarque," +
                                            "cidadeOrigem," +
                                            "estadoOrigem," +
                                            "cidadeDestino," +
                                            "estadoDestino," +
                                            "pedido," +
                                            "previsaoEmbarque," +
                                            "dataEmbarque," +
                                            "previsaoEntrega," +
                                            "dataEntrega," +
                                            "aceite," +
                                            "sstatus," +
                                            "placaCavalo," +
                                            "placaCarreta," +
                                            "placaSegundaCarreta," +
                                            "proprietario," +
                                            "motorista," +
                                            "freteFiscal," +
                                            "icms," +
                                            "freteMotorista," +
                                            "adicional," +
                                            "pedagio," +
                                            "classificacao," +
                                            "margem," +
                                            "adiantamento," +
                                            "meioPagamento," +
                                            "meioPagamentoDois," +
                                            "km," +
                                            "cliente," +
                                            "embarcador," +
                                            "destinatario," +
                                            "lload," +
                                            "mercadoria," +
                                            "peso," +
                                            "embalagem," +
                                            "observacao," +
                                            "frota," +
                                            "usuario," +
                                            "deletado)" +
                                           "VALUES('" + empresa + "', '" + filial + "', '" + unidadeEmbarque + "', '" + cidadeOrigem + "', '" + estadoOrigem + "', '" + cidadeDestino + "', '" + estadoDestino + "', '" + pedido + "', '" + previsaoEmbarque + "', '" + dataEmbarque + "','" + previsaoEntrega + "','" + dataEntrega + "', '" + aceite + "', '" + status + "', '" + placaCavalo + "', '" + placaCarreta + "', '" + placaSegundaCarreta + "', '" + proprietario + "', '" + motorista + "', '" + freteFiscal + "', '" + icms + "', '" + freteMotorista + "', '" + adicional + "', '" + pedagio + "', '" + classificacao + "', '" + margem + "', '" + adiantamento + "', '" + meioPagamento + "', '" + meioPagamentoDois + "', '" + km + "', '" + cliente + "', '" + embarcador + "', '" + destinatario + "', '" + load + "', '" + mercadoria + "', '" + peso + "', '" + embalagem + "', '" + observacao + "', '" + frota + "', '" + usuario + "', false); ", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
