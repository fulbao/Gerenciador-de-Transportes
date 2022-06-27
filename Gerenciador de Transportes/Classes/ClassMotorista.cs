namespace Gerenciador_de_Transportes
{
    internal class MotoristaCs : IMotoristaCs
    {
        string nome;

        string numeroTelefone;

        string contatoEmergencia;

        string numeroContatoEmergencia;

        MotoristaCs () { }

        public MotoristaCs (string nome, string numeroTelefone, string contatoEmergencia, string numeroContatoEmergencia)
        {
            this.nome = nome;

            this.numeroTelefone = numeroTelefone;

            this.contatoEmergencia = contatoEmergencia;

            this.numeroContatoEmergencia = numeroContatoEmergencia;
        }

        public string Nome { get => nome; set => nome = value; }

        public string NumeroTelefone { get => numeroTelefone; set => numeroTelefone = value; }

        public string ContatoEmergencia { get => contatoEmergencia; set => contatoEmergencia = value; }

        public string NumeroContatoEmergencia { get => numeroContatoEmergencia; set => numeroContatoEmergencia = value; }
    }
}
