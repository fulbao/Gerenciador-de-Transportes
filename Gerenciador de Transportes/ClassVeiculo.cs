using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Transportes
{
    public class VeiculoCs
    {
        string placaCavalo;
        string placaCarreta;
        string placaCarretaSegunda;
        string proprietario;
        string motorista;
        string motorista2;
        string motorista3;
        string motorista4;
        string motorista5;
        string motorista6;
        string motorista7;
        string motorista8;
        string motorista9;
        string motorista10;
        string motorista11;
        string motorista12;

        public VeiculoCs() { }
        public VeiculoCs(string placaCavalo, string placaCarreta, string placaCarretaSegunda, string proprietario, string motorista)
        {
            this.placaCavalo = placaCavalo;
            this.placaCarreta = placaCarreta;
            this.placaCarretaSegunda = placaCarretaSegunda;
            this.proprietario = proprietario;
            this.motorista = motorista;
        }
        public VeiculoCs(string placaCavalo, string placaCarreta, string placaCarretaSegunda, string proprietario, string motorista, string motorista2, string motorista3, string motorista4, string motorista5, string motorista6, string motorista7, string motorista8, string motorista9, string motorista10, string motorista11, string motorista12)
        {
            this.placaCavalo = placaCavalo;
            this.placaCarreta = placaCarreta;
            this.placaCarretaSegunda = placaCarretaSegunda;
            this.proprietario = proprietario;
            this.motorista = motorista;
            this.motorista2 = motorista2;
            this.motorista3 = motorista3;
            this.motorista4 = motorista4;
            this.motorista5 = motorista5;
            this.motorista6 = motorista6;
            this.motorista7 = motorista7;
            this.motorista8 = motorista8;
            this.motorista9 = motorista9;
            this.motorista10 = motorista10;
            this.motorista11 = motorista11;
            this.motorista12 = motorista12;
        }

        public string PlacaCavalo { get => placaCavalo; set => placaCavalo = value; }
        public string PlacaCarreta { get => placaCarreta; set => placaCarreta = value; }
        public string PlacaCarretaSegunda { get => placaCarretaSegunda; set => placaCarretaSegunda = value; }
        public string Proprietario { get => proprietario; set => proprietario = value; }
        public string Motorista { get => motorista; set => motorista = value; }
        public string Motorista2 { get => motorista2; set => motorista2 = value; }
        public string Motorista3 { get => motorista3; set => motorista3 = value; }
        public string Motorista4 { get => motorista4; set => motorista4 = value; }
        public string Motorista5 { get => motorista5; set => motorista5 = value; }
        public string Motorista6 { get => motorista6; set => motorista6 = value; }
        public string Motorista7 { get => motorista7; set => motorista7 = value; }
        public string Motorista8 { get => motorista8; set => motorista8 = value; }
        public string Motorista9 { get => motorista9; set => motorista9 = value; }
        public string Motorista10 { get => motorista10; set => motorista10 = value; }
        public string Motorista11 { get => motorista11; set => motorista11 = value; }
        public string Motorista12 { get => motorista12; set => motorista12 = value; }
    }
}
