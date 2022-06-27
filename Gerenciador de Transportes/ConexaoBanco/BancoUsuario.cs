using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    internal class BancoUsuario
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void criarTabelaUsuario ()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

            Conexao.Open();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.usuario" +
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

            Conexao.Close();
        }

        public static int verificaUsuario(string usuario)
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
            catch (Exception)
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
            catch (Exception)
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
            catch
            {
                return 0;
            }
        }

        public static int lePermissaoUsuario(string usuario, int contexto)
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
            catch (Exception)
            {
                return 0;
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
                                           " AND filial = '" + fFilial + "' AND unidadeEmbarque = '" + uUnidadeEmbarque + "' AND cidadeOrigem = '" + cCidadeOrigem + "' AND estadoOrigem  = '" + eEstadoOrigem + "' AND cidadeDestino = '" + cCidadeDestino + "' AND estadoDestino = '" + eEstadoDestino + "' AND pedido  = '" + pPedido + "' AND previsaoEmbarque = '" + pPrevisaoEmbarque + "' AND dataEmbarque = '" + dDataEmbarque + "' AND previsaoEntrega = '" + pPrevisaoEntrega + "' AND dataEntrega = '" + dDataEntrega + "' AND aceite = '" + aAceite + "' AND sstatus = '" + sStatus + "' AND placaCavalo = '" + pPlacaCavalo + "' AND placaCarreta = '" + pPlacaCarreta + "' AND placaSegundaCarreta = '" + pPlacaSegundaCarreta + "' AND proprietario = '" + pProprietario + "' AND motorista = '" + mMotorista + "' AND freteFiscal = '" + fFreteFiscal + "' AND icms = '" + iIcms + "' AND freteMotorista = '" + fFreteMotorista + "' AND adicional = '" + aDdicional + "' AND pedagio = '" + pPedagio + "' AND classificacao = '" + cClassificacao + "' AND margem = '" + mMargem + "' AND adiantamento = '" + aAdiantamento + "' AND meioPagamento = '" + mMeioPagamento + "' AND meioPagamentoDois = '" + mMeioPagamentoDois + "' AND km = '" + kKm + "' AND cliente  = '" + cCliente + "' AND embarcador = '" + eEmbarcador + "' AND destinatario = '" + dDestinatario + "' AND lload = '" + lLoad + "' AND mercadoria = '" + mMercadoria + "' AND peso = '" + pPeso + "' AND embalagem = '" + eMmbalagem + "' AND observacao = '" + oObservacao + "' AND frota = '" + fFrota + "';";
                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();
                readerUsuario = usuarioQuery.ExecuteReader();


                if (!readerUsuario.HasRows) { return true; }
                readerUsuario.Read();

                string usuario = readerUsuario.GetString(40);

                UsuarioSelecionado modalUser = new UsuarioSelecionado(readerUsuario.GetString(40));
                modalUser.ShowDialog();

                Conexao.Close();

                return true;
            }
            catch (Exception)
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

                UsuarioSelecionado modalUser = new UsuarioSelecionado(usuario);
                modalUser.ShowDialog();

                conn.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean obterUsuarioMotorista(string nome)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.motoristas WHERE nome = '" + nome +  "';";

                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();
                if (!readerUsuario.HasRows) { return true; }
                readerUsuario.Read();

                string usuario = readerUsuario.GetString("usuario");

                UsuarioSelecionado modalUser = new UsuarioSelecionado(usuario);
                modalUser.ShowDialog();

                conn.Close();

                return true;
            }
            catch (Exception)
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

                UsuarioSelecionado modalUser = new UsuarioSelecionado(usuario);
                modalUser.ShowDialog();

                conn.Close();

                return true;
            }
            catch (Exception)
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

                UsuarioSelecionado modalUser = new UsuarioSelecionado(usuario);
                modalUser.ShowDialog();

                conn.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public static Boolean obterUsuarioPedido(string pedido, string tipoRota, string freteFiscal, string icms, string pedagio, string classificacao, string km, string cliente, string embarcador, string embarcadorEstado, string destinatario, string destinatarioEstado, string freteMotorista, string cidadeOrigem, string cidadeDestino)
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

                UsuarioSelecionado modalUser = new UsuarioSelecionado(usuario);
                modalUser.ShowDialog();

                conn.Close();


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public static Boolean cadastrarUsuario(string usuario, string senha, string gloria, string paranavai, string toledo, string rioVerde, string pedido, string veiculos, string rotas, string cadastroUsuario, string dashboard, string obterUsuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.usuario(usuario,senha,gloria,paranavai,toledo,rioVerde,pedido,veiculos,rotas,cadastro,dashboard, obterUsuario)" +
                                           "VALUES('" + usuario + "', '" + senha + "', " + gloria + ", " + paranavai + ", " + toledo + ", " + rioVerde + ", " + pedido + ", " + veiculos + ", " + rotas + ", " + cadastroUsuario + ", " + dashboard + ", " + obterUsuario + "); ", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean alterarUsuario(string usuarioAntigo, string usuario, string gloria, string paranavai, string toledo, string rioVerde, string pedido, string veiculos, string rotas, string cadastroUsuario, string dashboard, string obterUsuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.usuario SET usuario = '" + usuario  + "', gloria = " + gloria + ", paranavai = " + paranavai + ", toledo = " + toledo + ", rioVerde = " + rioVerde + ", pedido = " + pedido + ", veiculos = " + veiculos + ", rotas = " + rotas + ", cadastro = " + cadastroUsuario + ", dashboard = " + dashboard + ", obterUsuario = " + obterUsuario + " WHERE usuario = '" + usuarioAntigo + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean alteraSenha (string login, string senha)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.usuario SET senha = '" + senha + "'  WHERE usuario = '" + login + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public static Boolean deletar (string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("DELETE from gerenciadortransportes.usuario WHERE usuario = '" + usuario + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<UsuarioCs> leUsuarios ()
        {
            List<UsuarioCs> users = new List<UsuarioCs>();

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                conn.Open();

                string query = "SELECT* FROM gerenciadortransportes.usuario";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "table_name");
                DataTable dt = ds.Tables["table_name"];

                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new UsuarioCs((string)row[1], (bool)row[3], (bool)row[4], (bool)row[5], (bool)row[6], (bool)row[7], (bool)row[8], (bool)row[9], (bool)row[10], (bool)row[11], (bool)row[12]));
                }

                conn.Close();

                return users;
            }
            catch (Exception)
            {
                ModalErro modal = new ModalErro("Atenção!", "Erro ao buscar os Usuários.");
                modal.ShowDialog();
                return users;
            }
        }
    }
}
