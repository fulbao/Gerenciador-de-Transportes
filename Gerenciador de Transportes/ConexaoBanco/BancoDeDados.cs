using Gerenciador_de_Transportes.ConexaoBanco;
using Gerenciador_de_Transportes.ConexaoBanco.BancoSelects;
using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                try
                {
                    Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                    Conexao.Open();

                    Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS gerenciadortransportes;", Conexao);

                    Comando.ExecuteNonQuery();

                    Conexao.Close();
                } catch (Exception ex)
                {
                    if (ex.GetType() != typeof(KeyNotFoundException))
                    {
                        ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro na criação do banco de dados, contate o desenvolvimento");
                        modal.ShowDialog();
                    }
                }

                BancoVeiculo.criarTabelaVeiculo();

                BancoUsuario.criarTabelaUsuario();

                BancoRota.criarTabelaRota();

                BancoPedido.criarTabelaPedido();

                BancoMotorista.criarTabelaMotorista();

                BancoEmbarque.criarTabelaEmbarque();

                BancoEmbarcador.criarTabelaEmbarcador();

                BancoEmpresas.criarTabelaEmpresas();

                BancoFilial.criarTabelaFilial();

                BancoUnidadeEmbarque.criarTabelaUnidadeEmbarque();

                BancoEmbalagem.criarTabelaEmbalagem();

                BancoStatus.criarTabelaStatus();

                BancoMeioPagamento.criarTabelaMeioPagamento();

                Conexao.Open();

                int primeiroUsuario = BancoUsuario.verificaUsuario("admin");

                if (primeiroUsuario == -1)
                {
                    BancoUsuario.cadastrarUsuario("admin", "2923", "true", "true", "true", "true", "true", "true", "true", "true", "true", "true");
                }

                Conexao.Close();
            }
            catch (Exception ex)
            {
                ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro na criação do banco de dados, contate o desenvolvimento");
                modal.ShowDialog();
            }
        }
    }
}
