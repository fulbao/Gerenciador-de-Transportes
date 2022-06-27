namespace Gerenciador_de_Transportes
{
    public interface IPedidoCs
    {
        string CidadeDestino { get; set; }
        string CidadeOrigem { get; set; }
        string Classificacao { get; set; }
        string Cliente { get; set; }
        string Destinatario { get; set; }
        string Embarcador { get; set; }
        string EstadoDestinatario { get; set; }
        string EstadoEmbarcador { get; set; }
        string FreteFiscal { get; set; }
        string FreteMotorista { get; set; }
        string Icms { get; set; }
        string Km { get; set; }
        string Pedagio { get; set; }
        string Pedido { get; set; }
        string TipoDeRota { get; set; }
    }
}