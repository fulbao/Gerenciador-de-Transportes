namespace Gerenciador_de_Transportes
{
    internal interface IClassRotas
    {
        string CidadeDestino { get; set; }
        string CidadeOrigem { get; set; }
        string EstadoDestino { get; set; }
        string EstadoOrigem { get; set; }
        string Rota { get; set; }
    }
}