namespace Gerenciador_de_Transportes
{
    internal class EmbarcadoresCs : IEmbarcadoresCs
    {
        string embarcador;
        string destinatario;

        public EmbarcadoresCs() { }

        public EmbarcadoresCs(string embarcador, string destinatario)
        {
            this.embarcador = embarcador;
            this.destinatario = destinatario;
        }

        public string Embarcador { get => embarcador; set => embarcador = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
    }
}
