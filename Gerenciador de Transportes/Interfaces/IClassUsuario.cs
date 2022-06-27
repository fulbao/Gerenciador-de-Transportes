namespace Gerenciador_de_Transportes
{
    internal interface IClassUsuario
    {
        bool Cadastro { get; set; }
        bool Dashboard { get; set; }
        bool Gloria { get; set; }
        string Nome { get; set; }
        bool ObterUsuario { get; set; }
        bool Paranavai { get; set; }
        bool Pedido { get; set; }
        bool RioVerde { get; set; }
        bool Rotas { get; set; }
        string Senha { get; set; }
        bool Toledo { get; set; }
        bool Veiculos { get; set; }
    }
}