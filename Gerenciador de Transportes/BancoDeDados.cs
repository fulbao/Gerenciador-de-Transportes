using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    internal class BancoDeDados
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void conectar()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS GerenciadorTransportes; use GerenciadorTransportes", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS usuario" +
                                            "(id integer auto_increment primary key," +
                                            "usuario char(20)," +
                                            "senha char(20)," +
                                            "gloria boolean," +
                                            "paranavai boolean," +
                                            "toledo boolean," +
                                            "rioVerde boolean," +
                                            "pedido boolean," +
                                            "veiculos boolean," +
                                            "rotas boolean," +
                                            "cadastro boolean," +
                                            "dashboard boolean," +
                                            "obterUsuario boolean)", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS rotas" +
                                            "(id integer auto_increment primary key," +
                                            "rota char(40)," +
                                            "cidadeOrigem char(40)," +
                                            "estadoOrigem char(40)," +
                                            "cidadeDestino char(40)," +
                                            "estadoDestino char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean," +
                                            "destinatario char(40))", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS embarcadores" +
                                            "(id integer auto_increment primary key," +
                                            "nome char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean)", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS veiculos" +
                                            "(id integer auto_increment primary key," +
                                            "placaCavalo char(40)," +
                                            "placaCarreta char(40)," +
                                            "placaCarretaDois char(40)," +
                                            "proprietario char(40)," +
                                            "motorista char(40)," +
                                            "motorista2 char(40)," +
                                            "motorista3 char(40)," +
                                            "motorista4 char(40)," +
                                            "motorista5 char(40)," +
                                            "motorista6 char(40)," +
                                            "motorista7 char(40)," +
                                            "motorista8 char(40)," +
                                            "motorista9 char(40)," +
                                            "motorista10 char(40)," +
                                            "motorista11 char(40)," +
                                            "motorista12 char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean)", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS pedido" +
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

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS embarqueGloria" +
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

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS embarqueParanavai" +
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

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS embarqueToledo" +
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

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS embarqueRioVerde" +
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

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS embarqueTodos" +
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

                int primeiroUsuario = verificaUsuario("admin");

                if (primeiroUsuario == -1)
                {
                    cadastrarUsuario("admin", "2923", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true");
                }

                Conexao.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static Boolean obterUsuarioEmbarque(string eEmpresa, string fFilial, string uUnidadeEmbarque, string cCidadeOrigem, string eEstadoOrigem, string cCidadeDestino, string eEstadoDestino, string pPedido, string pPrevisaoEmbarque, string dDataEmbarque, string pPrevisaoEntrega, string dDataEntrega, string aAceite, string sStatus, string pPlacaCavalo, string pPlacaCarreta, string pPlacaSegundaCarreta, string pProprietario, string mMotorista, string fFreteFiscal, string iIcms, string fFreteMotorista, string aDdicional, string pPedagio, string cClassificacao, string mMargem, string aAdiantamento, string mMeioPagamento, string mMeioPagamentoDois, string kKm, string cCliente, string eEmbarcador, string dDestinatario, string lLoad, string mMercadoria, string pPeso, string eMmbalagem, string oObservacao, string fFrota, string contexto)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes." + contexto + " WHERE empresa = '" + eEmpresa + "'" +
                                           " AND filial = '" + fFilial + "' AND unidadeEmbarque = '" + uUnidadeEmbarque + "' AND cidadeOrigem = '" + cCidadeOrigem + "' AND estadoOrigem  = '" + eEstadoOrigem +"' AND cidadeDestino = '" + cCidadeDestino +"' AND estadoDestino = '" + eEstadoDestino +"' AND pedido  = '" + pPedido +"' AND previsaoEmbarque = '" + pPrevisaoEmbarque +"' AND dataEmbarque = '" + dDataEmbarque +"' AND previsaoEntrega = '" + pPrevisaoEntrega +"' AND dataEntrega = '" + dDataEntrega + "' AND aceite = '" + aAceite +"' AND sstatus = '" + sStatus +"' AND placaCavalo = '" + pPlacaCavalo + "' AND placaCarreta = '" + pPlacaCarreta+"' AND placaSegundaCarreta = '" + pPlacaSegundaCarreta +"' AND proprietario = '" + pProprietario +"' AND motorista = '" + mMotorista +"' AND freteFiscal = '" + fFreteFiscal +"' AND icms = '" + iIcms +"' AND freteMotorista = '" + fFreteMotorista +"' AND adicional = '" + aDdicional +"' AND pedagio = '" + pPedagio +"' AND classificacao = '" +cClassificacao +"' AND margem = '" + mMargem +"' AND adiantamento = '" + aAdiantamento +"' AND meioPagamento = '" + mMeioPagamento +"' AND meioPagamentoDois = '" + mMeioPagamentoDois +"' AND km = '" + kKm +"' AND cliente  = '" + cCliente +"' AND embarcador = '" + eEmbarcador +"' AND destinatario = '" + dDestinatario +"' AND lload = '" + lLoad +"' AND mercadoria = '" + mMercadoria +"' AND peso = '" + pPeso +"' AND embalagem = '" + eMmbalagem +"' AND observacao = '" + oObservacao +"' AND frota = '" + fFrota + "';";
                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();
                readerUsuario = usuarioQuery.ExecuteReader();


                if (!readerUsuario.HasRows) { return true; }
                readerUsuario.Read();

                string usuario = readerUsuario.GetString(40);

                MessageBox.Show("Usuario: " + usuario);

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean obterUsuarioVeiculo(string placaCavalo, string placaCarreta, string placaCarretaSegunda, string proprietario, string motorista)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.veiculos WHERE placaCavalo = '" + placaCavalo + "'" +
                                       " AND placaCarreta = '" + placaCarreta + "' AND placaCarretaDois = '" + placaCarretaSegunda + "' AND proprietario = '" + proprietario + "' AND motorista = '" + motorista + "';";

                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();
                if (!readerUsuario.HasRows) { return true; }
                readerUsuario.Read();

                string usuario = readerUsuario.GetString(17);

                MessageBox.Show("Usuario: " + usuario);

                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean obterUsuarioEmbarcadores(string nome)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.embarcadores WHERE nome = '" + nome + "';";

                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();
                if (!readerUsuario.HasRows) { return true; }
                readerUsuario.Read();

                string usuario = readerUsuario.GetString(2);

                MessageBox.Show("Usuario: " + usuario);

                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean obterUsuarioRota(string rota, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.rotas WHERE rota = '" + rota + "'" +
                                       " AND cidadeOrigem = '" + cidadeOrigem + "' AND estadoOrigem = '" + estadoOrigem + "' AND cidadeDestino = '" + cidadeDestino + "' AND estadoDestino = '" + estadoDestino + "';";
                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();
                if (!readerUsuario.HasRows) { return true; }
                readerUsuario.Read();

                string usuario = readerUsuario.GetString(6);

                MessageBox.Show("Usuario: " + usuario);

                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean obterUsuarioPedido(string pedido, string tipoRota, string freteFiscal, string icms, string pedagio, string classificacao, string km, string cliente, string  embarcador, string embarcadorEstado, string destinatario, string destinatarioEstado, string freteMotorista, string cidadeOrigem, string cidadeDestino)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.pedido WHERE pedido = '" + pedido + "'" +
                                       " AND tipoDeRota = '" + tipoRota + "' AND freteFiscal = '" + freteFiscal + "' AND icms = '" + icms + "' AND pedagio = '" + pedagio + "' AND classificacao = '" + classificacao + "' AND km = '" + km + "' AND cliente = '" + cliente + "' AND embarcador = '" + embarcador + "' AND embarcadorEstado = '" + embarcadorEstado + "' AND destinatario = '" + destinatario + "' AND destinatarioEstado = '" + destinatarioEstado + "' AND freteMotorista = '" + freteMotorista + "' AND cidadeOrigem = '" + cidadeOrigem + "' AND cidadeDestino = '" + cidadeDestino + "';";
                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();
                if (!readerUsuario.HasRows) { return true; }
                readerUsuario.Read();

                string usuario = readerUsuario.GetString(16);

                MessageBox.Show("Usuario: " + usuario);

                conn.Close();


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean cadastrarUsuario (string usuario, string senha, string gloria, string paranavai, string toledo, string rioVerde, string pedido, string veiculos, string rotas, string cadastroUsuario, string dashboard, string obterUsuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.usuario(usuario,senha,gloria,paranavai,toledo,rioVerde,pedido,veiculos,rotas,cadastro,dashboard, obterUsuario)" +
                                           "VALUES('" + usuario + "', '" + senha + "', " + gloria + ", " + paranavai + ", " + toledo + ", " + rioVerde + ", " + pedido + ", " + veiculos + ", " + rotas + ", " +  cadastroUsuario + ", " + dashboard + ", " + obterUsuario + "); ", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean alterarItemRota(string rRota, string cCidadeOrigem, string eEstadoOrigem, string cCidadeDestino, string eEstadoDestino, string rota, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.rotas SET rota = '" + rRota + "' , cidadeOrigem = '" + cCidadeOrigem + "' , estadoOrigem = '" + eEstadoOrigem +"' , cidadeDestino = '" + cCidadeDestino + "' , estadoDestino = '" + eEstadoDestino + "' , usuario = '" + usuario + "'  WHERE rota = '" + rota + "'" +
                                           " AND cidadeOrigem = '" + cidadeOrigem + "' AND estadoOrigem = '" + estadoOrigem + "' AND cidadeDestino = '" + cidadeDestino + "' AND estadoDestino = '" + estadoDestino + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean alterarItemVeiculos(string pPlacaCavalo, string pPlacaCarreta, string pPlacaCarretaSegunda, string pProprietario, string mMotorista, string placaCavalo, string placaCarreta, string placaCarretaSegunda, string proprietario, string motorista, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.veiculos SET placaCavalo = '" + pPlacaCavalo + "' , placaCarreta = '" + pPlacaCarreta + "' , placaCarretaDois = '" + pPlacaCarretaSegunda + "' , proprietario = '" + pProprietario + "' , motorista = '" + mMotorista + "' , usuario = '" + usuario + "'  WHERE placaCavalo = '" + placaCavalo + "'" +
                                           " AND placaCarreta = '" + placaCarreta + "' AND placaCarretaDois = '" + placaCarretaSegunda + "' AND proprietario = '" + proprietario + "' AND motorista = '" + motorista + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean alterarItemEmbarcadores(string embarcador, string eembarcador, string destinatario, string ddestinatario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.embarcadores SET nome = '" + embarcador + "', destinatario = '" + destinatario +"'  WHERE nome = '" + eembarcador + "' AND destinatario = '" + ddestinatario + "';", Conexao);
             
                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean alterarItemMotorista(string placa, string motorista1, string motorista2, string motorista3, string motorista4, string motorista5, string motorista6, string motorista7, string motorista8, string motorista9, string motorista10, string motorista11, string motorista12, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.veiculos SET motorista = '" + motorista1 + "' , motorista2 = '" + motorista2 + "' , motorista3 = '" + motorista3 + "' , motorista4 = '" + motorista4 + "' , motorista5 = '" + motorista5 + "' , motorista6 = '" + motorista6 + "' , motorista7 = '" + motorista7 + "' , motorista8 = '" + motorista8 + "' , motorista9 = '" + motorista9 + "' , motorista10 = '" + motorista10 + "' , motorista11 = '" + motorista11 + "' , motorista12 = '" + motorista12 + "' , usuario = '" + usuario + "'  WHERE placaCavalo = '" + placa + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean alterarItemPedido(string pPedido, string pTipoDeRota, string fFreteFiscal, string iIcms, string pPedagio, string cClassificacao, string kKm, string cCliente, string eEmbarcador, string eEmbarcadorEstado, string dDestinatario, string dDestinatarioEstado, string fFreteMotorista, string cCidadeOrigem, string cCidadeDestino, string pedido, string tipoDeRota, string freteFiscal, string icms, string pedagio, string classificacao, string km, string cliente, string embaracador, string estadoEmbarcador, string destinatario, string estadoDestinatario, string freteMotorista, string CidadeOrigem, string cidadeDestino, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.pedido SET pedido = '" + pedido + "' , tipoDeRota = '" + tipoDeRota + "' , freteFiscal = '" + freteFiscal + "' , icms = '" + icms + "' , pedagio = '" + pedagio + "' , classificacao = '" + classificacao + "' , km = '" + km + "' , cliente = '" + cliente + "' , embarcador = '" + embaracador + "' , embarcadorEstado = '" + estadoEmbarcador + "' , destinatario = '" + destinatario + "' , destinatarioEstado = '" + estadoDestinatario + "' , freteMotorista = '" + freteMotorista + "' , cidadeOrigem = '" + CidadeOrigem + "' , cidadeDestino = '" + cidadeDestino + "' , usuario = '" + usuario + "' WHERE pedido = '" + pPedido + "'" +
                                       " AND tipoDeRota = '" + pTipoDeRota + "' AND freteFiscal = '" + fFreteFiscal + "' AND icms = '" + iIcms + "' AND pedagio = '" + pPedagio + "' AND classificacao = '" + cClassificacao + "' AND km = '" + kKm + "' AND cliente = '" + cCliente + "' AND embarcador = '" + eEmbarcador + "' AND embarcadorEstado = '" + eEmbarcadorEstado + "' AND destinatario = '" + dDestinatario + "' AND destinatarioEstado = '" + dDestinatarioEstado + "' AND freteMotorista = '" + fFreteMotorista + "' AND cidadeOrigem = '" + cCidadeOrigem + "' AND cidadeDestino = '" + cCidadeDestino + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean alterarItemEmbarque(string eEmpresa, string fFilial, string uUnidadeEmbarque, string cCidadeOrigem, string eEstadoOrigem, string cCidadeDestino, string eEstadoDestino, string pPedido, string pPrevisaoEmbarque, string dDataEmbarque, string pPrevisaoEntrega, string dDataEntrega, string aAceite, string sStatus, string pPlacaCavalo, string pPlacaCarreta, string pPlacaSegundaCarreta, string pProprietario, string mMotorista, string fFreteFiscal, string iIcms, string fFreteMotorista, string aDdicional, string pPedagio, string cClassificacao, string aAdiantamento, string mMeioPagamento, string mMeioPagamentoDois, string kKm, string cCliente, string eEmbarcador, string dDestinatario, string lLoad, string mMercadoria, string pPeso, string eMmbalagem, string oObservacao, string fFrota, string empresa, string filial, string unidadeEmbarque, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino, string pedido, string previsaoEmbarque, string dataEmbarque, string previsaoEntrega, string dataEntrega, string aceite, string status, string placaCavalo, string placaCarreta, string placaSegundaCarreta, string proprietario, string motorista, string freteFiscal, string icms, string freteMotorista, string adicional, string pedagio, string classificacao, string margem, string adiantamento, string meioPagamento, string meioPagamentoDois, string km, string cliente, string embarcador, string destinatario, string load, string mercadoria, string peso, string embalagem, string observacao, string frota, string contexto, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes." + contexto + " SET empresa = '" + empresa + "' , filial = '" + filial + "' , unidadeEmbarque = '" + unidadeEmbarque + "' , cidadeOrigem = '" + cidadeOrigem + "' , estadoOrigem = '" + estadoOrigem + "' , cidadeDestino = '" + cidadeDestino + "' , estadoDestino = '" + estadoDestino + "' , pedido = '" + pedido + "' , previsaoEmbarque = '" + previsaoEmbarque + "' , dataEmbarque = '" + dataEmbarque + "' , previsaoEntrega = '" + previsaoEntrega + "' , dataEntrega = '" + dataEntrega + "' , aceite = '" + aceite + "' , sstatus = '" + status + "' , placaCavalo= '" + placaCavalo+ "' , placaCarreta= '" + placaCarreta + "' , placaSegundaCarreta= '" + placaSegundaCarreta + "' , proprietario= '" + proprietario + "' , motorista= '" + motorista + "' , freteFiscal= '" + freteFiscal + "' , icms= '" + icms + "' , freteMotorista= '" + freteMotorista+ "' , adicional= '" + adicional + "' , pedagio= '" + pedagio + "' , classificacao= '" + classificacao + "' , margem= '" + margem+ "' , adiantamento= '" + adiantamento + "' , meioPagamento= '" + meioPagamento + "' , meioPagamentoDois= '" + meioPagamentoDois+ "' , km= '" + km + "' , cliente= '" + cliente + "' , embarcador= '" + embarcador + "' , destinatario= '" + destinatario + "' , lload= '" + load+ "' , mercadoria= '" + mercadoria+ "' , peso= '" + peso + "' , embalagem= '" + embalagem + "' , observacao= '" + observacao + "' , frota= '" + frota + "' , usuario= '" + usuario + "'  WHERE empresa = '" + eEmpresa + "'" +
                                           " AND filial = '" + fFilial + "' AND unidadeEmbarque = '" + uUnidadeEmbarque + "' AND cidadeOrigem = '" + cCidadeOrigem + "' AND estadoOrigem  = '" + eEstadoOrigem + "' AND cidadeDestino = '" + cCidadeDestino + "' AND estadoDestino = '" + eEstadoDestino + "' AND pedido  = '" + pPedido + "' AND previsaoEmbarque = '" + pPrevisaoEmbarque + "' AND dataEmbarque = '" + dDataEmbarque + "' AND previsaoEntrega = '" + pPrevisaoEntrega + "' AND dataEntrega = '" + dDataEntrega + "' AND aceite = '" + aAceite + "' AND sstatus = '" + sStatus + "' AND placaCavalo = '" + pPlacaCavalo + "' AND placaCarreta = '" + pPlacaCarreta + "' AND placaSegundaCarreta = '" + pPlacaSegundaCarreta + "' AND proprietario = '" + pProprietario + "' AND motorista = '" + mMotorista + "' AND freteFiscal = '" + fFreteFiscal + "' AND icms = '" + iIcms + "' AND freteMotorista = '" + fFreteMotorista + "' AND adicional = '" + aDdicional + "' AND pedagio = '" + pPedagio + "' AND classificacao = '" + cClassificacao + "' AND adiantamento = '" + aAdiantamento + "' AND meioPagamento = '" + mMeioPagamento + "' AND meioPagamentoDois = '" + mMeioPagamentoDois + "' AND km = '" + kKm + "' AND cliente  = '" + cCliente + "' AND embarcador = '" + eEmbarcador + "' AND destinatario = '" + dDestinatario + "' AND lload = '" + lLoad + "' AND mercadoria = '" + mMercadoria + "' AND peso = '" + pPeso + "' AND embalagem = '" + eMmbalagem + "' AND observacao = '" + oObservacao + "' AND frota = '" + fFrota + "';", Conexao);
                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean deletarItemRota(string rota, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.rotas SET deletado = true WHERE rota = '" + rota + "'" +
                                           " AND cidadeOrigem = '" + cidadeOrigem + "' AND estadoOrigem = '" + estadoOrigem + "' AND cidadeDestino = '" + cidadeDestino + "' AND estadoDestino = '" + estadoDestino + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean deletarItemVeiculos(string placaCavalo, string placaCarreta, string placaCarretaSegunda, string proprietario, string motorista)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.veiculos SET deletado = true WHERE placaCavalo = '" + placaCavalo + "'" +
                                           " AND placaCarreta = '" + placaCarreta + "' AND placaCarretaDois = '" + placaCarretaSegunda + "' AND proprietario = '" + proprietario + "' AND motorista = '" + motorista + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean deletarItemEmbarcadores(string eembarcador, string destinatario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.embarcadores SET deletado = true WHERE nome = '" + eembarcador + "' AND destinatario = '" + destinatario +"';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean adicionarRota(string rota, string cidadeOrigem, string estadoOrigen, string cidadeDestino, string estadoDestino, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.rotas(rota, cidadeOrigem, estadoOrigem, cidadeDestino, estadoDestino, usuario, deletado)" +
                                           "VALUES('" + rota + "', '" + cidadeOrigem + "', '" + estadoOrigen + "', '" + cidadeDestino + "', '" + estadoDestino + "', '" + usuario + "', false); ", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean adicionarEmbarcador(string nome, string usuario, string destinatario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.embarcadores(nome, usuario, deletado, destinatario)" +
                                           "VALUES('" + nome + "', '" + usuario + "', false, '" + destinatario + "'); ", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean adicionarVeiculos(string placaCavalo, string placaCarreta, string placaCarretaDois, string proprietario, string motorista, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.veiculos(placaCavalo, placaCarreta, placaCarretaDois, proprietario, motorista, usuario, deletado)" +
                                           "VALUES('" + placaCavalo + "', '" + placaCarreta + "', '" + placaCarretaDois + "', '" + proprietario + "', '" + motorista + "', '" + usuario + "', false); ", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean deletarItemPedido(string pedido, string tipoRota, string freteFiscal, string icms, string pedagio, string classificacao, string km, string cliente, string embarcador, string embarcadorEstado, string destinatario, string destinatarioEstado, string freteMotorista, string cidadeOrigem, string cidadeDestino)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.pedido SET deletado = true WHERE pedido = '" + pedido + "'" +
                                       " AND tipoDeRota = '" + tipoRota + "' AND freteFiscal = '" + freteFiscal + "' AND icms = '" + icms + "' AND pedagio = '" + pedagio + "' AND classificacao = '" + classificacao + "' AND km = '" + km + "' AND cliente = '" + cliente + "' AND embarcador = '" + embarcador + "' AND embarcadorEstado = '" + embarcadorEstado + "' AND destinatario = '" + destinatario + "' AND destinatarioEstado = '" + destinatarioEstado + "' AND freteMotorista = '" + freteMotorista + "' AND cidadeOrigem = '" + cidadeOrigem + "' AND cidadeDestino = '" + cidadeDestino + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean deletarItemEmbarque(string eEmpresa, string fFilial, string uUnidadeEmbarque, string cCidadeOrigem, string eEstadoOrigem, string cCidadeDestino, string eEstadoDestino, string pPedido, string pPrevisaoEmbarque, string dDataEmbarque, string pPrevisaoEntrega, string dDataEntrega, string aAceite, string sStatus, string pPlacaCavalo, string pPlacaCarreta, string pPlacaSegundaCarreta, string pProprietario, string mMotorista, string fFreteFiscal, string iIcms, string fFreteMotorista, string aDdicional, string pPedagio, string cClassificacao, string mMargem, string aAdiantamento, string mMeioPagamento, string mMeioPagamentoDois, string kKm, string cCliente, string eEmbarcador, string dDestinatario, string lLoad, string mMercadoria, string pPeso, string eMmbalagem, string oObservacao, string fFrota, string contexto)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes." + contexto + " SET deletado = true WHERE empresa = '" + eEmpresa + "'" +
                                           " AND filial = '" + fFilial + "' AND unidadeEmbarque = '" + uUnidadeEmbarque + "' AND cidadeOrigem = '" + cCidadeOrigem + "' AND estadoOrigem  = '" + eEstadoOrigem + "' AND cidadeDestino = '" + cCidadeDestino + "' AND estadoDestino = '" + eEstadoDestino + "' AND pedido  = '" + pPedido + "' AND previsaoEmbarque = '" + pPrevisaoEmbarque + "' AND dataEmbarque = '" + dDataEmbarque + "' AND previsaoEntrega = '" + pPrevisaoEntrega + "' AND dataEntrega = '" + dDataEntrega + "' AND aceite = '" + aAceite + "' AND sstatus = '" + sStatus + "' AND placaCavalo = '" + pPlacaCavalo + "' AND placaCarreta = '" + pPlacaCarreta + "' AND placaSegundaCarreta = '" + pPlacaSegundaCarreta + "' AND proprietario = '" + pProprietario + "' AND motorista = '" + mMotorista + "' AND freteFiscal = '" + fFreteFiscal + "' AND icms = '" + iIcms + "' AND freteMotorista = '" + fFreteMotorista + "' AND adicional = '" + aDdicional + "' AND pedagio = '" + pPedagio + "' AND classificacao = '" + cClassificacao + "' AND margem = '" + mMargem + "' AND adiantamento = '" + aAdiantamento + "' AND meioPagamento = '" + mMeioPagamento + "' AND meioPagamentoDois = '" + mMeioPagamentoDois + "' AND km = '" + kKm + "' AND cliente  = '" + cCliente + "' AND embarcador = '" + eEmbarcador + "' AND destinatario = '" + dDestinatario + "' AND lload = '" + lLoad + "' AND mercadoria = '" + mMercadoria + "' AND peso = '" + pPeso + "' AND embalagem = '" + eMmbalagem + "' AND observacao = '" + oObservacao + "' AND frota = '" + fFrota + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean adicionarPedido(string pedido, string tipoDeRota, string freteFiscal, string icms, string pedagio, string classificacao, string km, string cliente, string embarcador, string estadoEmbarcador, string destinatario, string estadoDestinatario, string freteMotorista, string cidadeOrigem, string cidadeDestino, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.pedido(pedido, tipoDeRota, freteFiscal, icms, pedagio, classificacao, km,cliente, embarcador, embarcadorEstado, destinatario, destinatarioEstado, freteMotorista, cidadeOrigem, cidadeDestino,usuario, deletado)" +
                                           "VALUES('" + pedido + "', '" + tipoDeRota + "', '" + freteFiscal + "', '" + icms + "', '" + pedagio + "', '" + classificacao + "', '" + km + "', '" + cliente + "', '" + embarcador + "', '" + estadoEmbarcador + "', '" + destinatario + "', '" + estadoDestinatario + "', '" + freteMotorista + "', '" + cidadeOrigem + "', '" + cidadeDestino + "', '" + usuario + "', false); ", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static Boolean adicionarEmbarque(string empresa, string filial, string unidadeEmbarque, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino, string pedido, string previsaoEmbarque, string dataEmbarque, string previsaoEntrega, string dataEntrega, string aceite, string status, string placaCavalo, string placaCarreta, string placaSegundaCarreta, string proprietario, string motorista, string freteFiscal, string icms, string freteMotorista, string adicional, string pedagio, string classificacao, string margem, string adiantamento, string meioPagamento, string meioPagamentoDois, string km, string cliente, string embarcador, string destinatario, string load, string mercadoria, string peso, string embalagem, string observacao, string frota,  string usuario, string contexto)
        {
            margem = margem + " %";

            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

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
                                           "VALUES('" + empresa + "', '" + filial + "', '" + unidadeEmbarque + "', '" + cidadeOrigem + "', '" + estadoOrigem+ "', '" + cidadeDestino + "', '" + estadoDestino + "', '" + pedido + "', '" + previsaoEmbarque + "', '" + dataEmbarque + "','" + previsaoEntrega + "','" + dataEntrega + "', '" + aceite+ "', '" + status + "', '" + placaCavalo + "', '" + placaCarreta+ "', '" + placaSegundaCarreta + "', '" + proprietario + "', '" + motorista + "', '" + freteFiscal + "', '" + icms + "', '" + freteMotorista + "', '" + adicional + "', '" + pedagio + "', '" + classificacao + "', '" + margem + "', '" + adiantamento + "', '" + meioPagamento + "', '" + meioPagamentoDois + "', '" + km + "', '" + cliente + "', '" + embarcador + "', '" + destinatario + "', '" + load + "', '" + mercadoria + "', '" + peso + "', '" + embalagem + "', '" + observacao + "', '" + frota + "', '" + usuario + "', false); ", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static int verificaUsuario (string usuario)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.usuario WHERE usuario = @usuario";
                usuarioQuery.Parameters.AddWithValue("@usuario", usuario);
                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();
                

                if (!readerUsuario.HasRows) { return -1; }

                conn.Close();

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int verificaSenha(string senha)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand senhaQuery = new MySqlCommand();
                MySqlDataReader readerSenha;

                senhaQuery.CommandText = "SELECT * FROM gerenciadortransportes.usuario WHERE senha = @senha";
                senhaQuery.Parameters.AddWithValue("@senha", senha);
                senhaQuery.CommandType = CommandType.Text;
                senhaQuery.Connection = conn;

                conn.Open();

                readerSenha = senhaQuery.ExecuteReader();


                if (!readerSenha.HasRows) { return -1; }

                conn.Close();

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int verificaLogin(string usuario, string senha)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand senhaQuery = new MySqlCommand();
                MySqlDataReader readerSenha;

                senhaQuery.CommandText = "SELECT * FROM gerenciadortransportes.usuario WHERE senha = @senha AND usuario = @usuario";
                senhaQuery.Parameters.AddWithValue("@senha", senha);
                senhaQuery.Parameters.AddWithValue("@usuario", usuario);
                senhaQuery.CommandType = CommandType.Text;
                senhaQuery.Connection = conn;

                conn.Open();

                readerSenha = senhaQuery.ExecuteReader();


                if (!readerSenha.HasRows) { return -1; }

                conn.Close();

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int lePermissaoUsuario (string usuario, int contexto)
        {
            string nivelPermissao;
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.usuario WHERE usuario = @usuario";
                usuarioQuery.Parameters.AddWithValue("@usuario", usuario);
                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();
                readerUsuario.Read();

                nivelPermissao = readerUsuario.GetString(contexto);

                conn.Close();

                if (nivelPermissao == "True")
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
