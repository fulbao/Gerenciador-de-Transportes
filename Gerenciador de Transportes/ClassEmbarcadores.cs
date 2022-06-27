using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Transportes
{
    internal class ClassEmbarcadores
    {
        string embarcador;
        string destinatario;

        public ClassEmbarcadores() { }

        public ClassEmbarcadores(string embarcador, string destinatario)
        {
            this.embarcador = embarcador;
            this.destinatario = destinatario;
        }

        public string Embarcador { get => embarcador; set => embarcador = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
    }
}
