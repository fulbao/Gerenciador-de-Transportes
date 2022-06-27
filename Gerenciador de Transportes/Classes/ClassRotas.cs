namespace Gerenciador_de_Transportes
{
    internal class ClassRotas : IClassRotas
    {
        string rota;
        string cidadeOrigem;
        string estadoOrigem;
        string cidadeDestino;
        string estadoDestino;

        public ClassRotas() { }
        public ClassRotas(string rota, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino)
        {
            this.rota = rota;
            this.cidadeOrigem = cidadeOrigem;
            this.estadoOrigem = estadoOrigem;
            this.cidadeDestino = cidadeDestino;
            this.estadoDestino = estadoDestino;
        }

        public string Rota { get => rota; set => rota = value; }
        public string CidadeOrigem { get => cidadeOrigem; set => cidadeOrigem = value; }
        public string EstadoOrigem { get => estadoOrigem; set => estadoOrigem = value; }
        public string CidadeDestino { get => cidadeDestino; set => cidadeDestino = value; }
        public string EstadoDestino { get => estadoDestino; set => estadoDestino = value; }
    }
}
