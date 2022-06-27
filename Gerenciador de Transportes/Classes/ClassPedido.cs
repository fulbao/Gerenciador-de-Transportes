namespace Gerenciador_de_Transportes
{
    public class PedidoCs : IPedidoCs
    {
        string pedido;
        string tipoDeRota;
        string freteFiscal;
        string icms;
        string pedagio;
        string classificacao;
        string km;
        string cliente;
        string embarcador;
        string estadoEmbarcador;
        string destinatario;
        string estadoDestinatario;
        string freteMotorista;
        string cidadeOrigem;
        string cidadeDestino;


        public PedidoCs() { }

        public PedidoCs(string pedido, string freteFiscal, string icms, string pedagio, string classificacao, string km, string cliente, string embarcador, string estadoEmbarcador, string destinatario, string estadoDestinatario, string freteMotorista, string cidadeOrigem, string cidadeDestino)
        {
            this.pedido = pedido;
            this.freteFiscal = freteFiscal;
            this.icms = icms;
            this.pedagio = pedagio;
            this.classificacao = classificacao;
            this.km = km;
            this.cliente = cliente;
            this.embarcador = embarcador;
            this.estadoEmbarcador = estadoEmbarcador;
            this.destinatario = destinatario;
            this.estadoDestinatario = estadoDestinatario;
            this.freteMotorista = freteMotorista;
            this.cidadeOrigem = cidadeOrigem;
            this.cidadeDestino = cidadeDestino;
        }
        public PedidoCs(string pedido, string tipoDeRota, string freteFiscal, string icms, string pedagio, string classificacao, string km, string cliente, string embarcador, string estadoEmbarcador, string destinatario, string estadoDestinatario, string freteMotorista, string cidadeOrigem, string cidadeDestino)
        {
            this.pedido = pedido;
            this.tipoDeRota = tipoDeRota;
            this.freteFiscal = freteFiscal;
            this.icms = icms;
            this.pedagio = pedagio;
            this.classificacao = classificacao;
            this.km = km;
            this.cliente = cliente;
            this.embarcador = embarcador;
            this.estadoEmbarcador = estadoEmbarcador;
            this.destinatario = destinatario;
            this.estadoDestinatario = estadoDestinatario;
            this.freteMotorista = freteMotorista;
            this.cidadeOrigem = cidadeOrigem;
            this.cidadeDestino = cidadeDestino;
        }

        public string Pedido { get => pedido; set => pedido = value; }
        public string TipoDeRota { get => tipoDeRota; set => tipoDeRota = value; }
        public string FreteFiscal { get => freteFiscal; set => freteFiscal = value; }
        public string Icms { get => icms; set => icms = value; }
        public string Pedagio { get => pedagio; set => pedagio = value; }
        public string Classificacao { get => classificacao; set => classificacao = value; }
        public string Km { get => km; set => km = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Embarcador { get => embarcador; set => embarcador = value; }
        public string EstadoEmbarcador { get => estadoEmbarcador; set => estadoEmbarcador = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string EstadoDestinatario { get => estadoDestinatario; set => estadoDestinatario = value; }
        public string FreteMotorista { get => freteMotorista; set => freteMotorista = value; }
        public string CidadeOrigem { get => cidadeOrigem; set => cidadeOrigem = value; }
        public string CidadeDestino { get => cidadeDestino; set => cidadeDestino = value; }
    }
}
