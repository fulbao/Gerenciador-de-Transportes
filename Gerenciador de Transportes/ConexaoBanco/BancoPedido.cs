using MySql.Data.MySqlClient;
using System;

namespace Gerenciador_de_Transportes
{
    internal class BancoPedido
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void criarTabelaPedido()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

            Conexao.Open();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.pedido" +
                                            "(id integer auto_increment primary key," +
                                            "pedido char(40)," +
                                            "tipoDeRota char(40)," +
                                            "freteFiscal char(40)," +
                                            "icms char(40)," +
                                            "pedagio char(40)," +
                                            "classificacao char(40)," +
                                            "km char(40)," +
                                            "cliente char(40)," +
                                            "embarcador char(40)," +
                                            "embarcadorEstado char(40)," +
                                            "destinatario char(40)," +
                                            "destinatarioEstado char(40)," +
                                            "freteMotorista char(40)," +
                                            "cidadeOrigem char(40)," +
                                            "cidadeDestino char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean)", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public static Boolean alterarItemPedido(string pPedido, string pTipoDeRota, string fFreteFiscal, string iIcms, string pPedagio, string cClassificacao, string kKm, string cCliente, string eEmbarcador, string eEmbarcadorEstado, string dDestinatario, string dDestinatarioEstado, string fFreteMotorista, string cCidadeOrigem, string cCidadeDestino, string pedido, string tipoDeRota, string freteFiscal, string icms, string pedagio, string classificacao, string km, string cliente, string embaracador, string estadoEmbarcador, string destinatario, string estadoDestinatario, string freteMotorista, string CidadeOrigem, string cidadeDestino, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.pedido SET pedido = '" + pedido + "' , tipoDeRota = '" + tipoDeRota + "' , freteFiscal = '" + freteFiscal + "' , icms = '" + icms + "' , pedagio = '" + pedagio + "' , classificacao = '" + classificacao + "' , km = '" + km + "' , cliente = '" + cliente + "' , embarcador = '" + embaracador + "' , embarcadorEstado = '" + estadoEmbarcador + "' , destinatario = '" + destinatario + "' , destinatarioEstado = '" + estadoDestinatario + "' , freteMotorista = '" + freteMotorista + "' , cidadeOrigem = '" + CidadeOrigem + "' , cidadeDestino = '" + cidadeDestino + "' , usuario = '" + usuario + "' WHERE pedido = '" + pPedido + "'" +
                                       " AND tipoDeRota = '" + pTipoDeRota + "' AND freteFiscal = '" + fFreteFiscal + "' AND icms = '" + iIcms + "' AND pedagio = '" + pPedagio + "' AND classificacao = '" + cClassificacao + "' AND km = '" + kKm + "' AND cliente = '" + cCliente + "' AND embarcador = '" + eEmbarcador + "' AND embarcadorEstado = '" + eEmbarcadorEstado + "' AND destinatario = '" + dDestinatario + "' AND destinatarioEstado = '" + dDestinatarioEstado + "' AND freteMotorista = '" + fFreteMotorista + "' AND cidadeOrigem = '" + cCidadeOrigem + "' AND cidadeDestino = '" + cCidadeDestino + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean deletarItemPedido(string pedido, string tipoRota, string freteFiscal, string icms, string pedagio, string classificacao, string km, string cliente, string embarcador, string embarcadorEstado, string destinatario, string destinatarioEstado, string freteMotorista, string cidadeOrigem, string cidadeDestino)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.pedido SET deletado = true WHERE pedido = '" + pedido + "'" +
                                       " AND tipoDeRota = '" + tipoRota + "' AND freteFiscal = '" + freteFiscal + "' AND icms = '" + icms + "' AND pedagio = '" + pedagio + "' AND classificacao = '" + classificacao + "' AND km = '" + km + "' AND cliente = '" + cliente + "' AND embarcador = '" + embarcador + "' AND embarcadorEstado = '" + embarcadorEstado + "' AND destinatario = '" + destinatario + "' AND destinatarioEstado = '" + destinatarioEstado + "' AND freteMotorista = '" + freteMotorista + "' AND cidadeOrigem = '" + cidadeOrigem + "' AND cidadeDestino = '" + cidadeDestino + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean adicionarPedido(string pedido, string tipoDeRota, string freteFiscal, string icms, string pedagio, string classificacao, string km, string cliente, string embarcador, string estadoEmbarcador, string destinatario, string estadoDestinatario, string freteMotorista, string cidadeOrigem, string cidadeDestino, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.pedido(pedido, tipoDeRota, freteFiscal, icms, pedagio, classificacao, km,cliente, embarcador, embarcadorEstado, destinatario, destinatarioEstado, freteMotorista, cidadeOrigem, cidadeDestino,usuario, deletado)" +
                                           "VALUES('" + pedido + "', '" + tipoDeRota + "', '" + freteFiscal + "', '" + icms + "', '" + pedagio + "', '" + classificacao + "', '" + km + "', '" + cliente + "', '" + embarcador + "', '" + estadoEmbarcador + "', '" + destinatario + "', '" + estadoDestinatario + "', '" + freteMotorista + "', '" + cidadeOrigem + "', '" + cidadeDestino + "', '" + usuario + "', false); ", Conexao);

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
