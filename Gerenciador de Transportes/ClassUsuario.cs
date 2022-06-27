using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Transportes
{
    internal class ClassUsuario
    {
        string nome;
        string senha;
        bool gloria;
        bool paranavai;
        bool toledo;
        bool rioVerde;
        bool pedido;
        bool veiculos;
        bool rotas;
        bool cadastro;
        bool dashboard;
        bool obterUsuario;

        ClassUsuario() { }

        public ClassUsuario(string nome, string senha, bool gloria, bool paranavai, bool toledo, bool rioVerde, bool pedido, bool veiculos, bool rotas, bool cadastro, bool dashboard, bool obterUsuario)
        {
            this.nome = nome;
            this.senha = senha;
            this.gloria = gloria;
            this.paranavai = paranavai;
            this.toledo = toledo;
            this.rioVerde = rioVerde;
            this.pedido = pedido;
            this.veiculos = veiculos;
            this.rotas = rotas;
            this.cadastro = cadastro;
            this.dashboard = dashboard;
            this.obterUsuario = obterUsuario;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool Gloria { get => gloria; set => gloria = value; }
        public bool Paranavai { get => paranavai; set => paranavai = value; }
        public bool Toledo { get => toledo; set => toledo = value; }
        public bool RioVerde { get => rioVerde; set => rioVerde = value; }
        public bool Pedido { get => pedido; set => pedido = value; }
        public bool Veiculos { get => veiculos; set => veiculos = value; }
        public bool Rotas { get => rotas; set => rotas = value; }
        public bool Cadastro { get => cadastro; set => cadastro = value; }
        public bool Dashboard { get => dashboard; set => dashboard = value; }
        public bool ObterUsuario { get => obterUsuario; set => obterUsuario = value; }
    }
}
