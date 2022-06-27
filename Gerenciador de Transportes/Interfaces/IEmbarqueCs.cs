namespace Gerenciador_de_Transportes
{
    public interface IEmbarqueCs
    {
        string Aceite { get; set; }
        string Adiantamento { get; set; }
        string Adicional { get; set; }
        string DataEmbarque { get; set; }
        string DataEntrega { get; set; }
        string Embalagem { get; set; }
        string Empresa { get; set; }
        string Filial { get; set; }
        string Frota { get; set; }
        string Load { get; set; }
        string Margem { get; set; }
        string MeioPagamento { get; set; }
        string MeioPagamentoDois { get; set; }
        string Mercadoria { get; set; }
        string Observacao { get; set; }
        PedidoCs Pedido { get; set; }
        string Peso { get; set; }
        string PrevisaoEmbarque { get; set; }
        string PrevisaoEntrega { get; set; }
        string Status { get; set; }
        string UnidadeEmbarque { get; set; }
        VeiculoCs Veiculo { get; set; }
    }
}