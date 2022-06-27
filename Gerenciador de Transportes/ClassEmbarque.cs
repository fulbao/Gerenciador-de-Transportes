using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Transportes
{
    public class EmbarqueCs
    {
        PedidoCs pedido = new PedidoCs();
        VeiculoCs veiculo = new VeiculoCs();
        string empresa;
        string filial;
        string unidadeEmbarque;
        string previsaoEmbarque;
        string dataEmbarque;
        string previsaoEntrega;
        string dataEntrega;
        string aceite;
        string adicional;
        string adiantamento;
        string meioPagamento;
        string meioPagamentoDois;
        string load;
        string mercadoria;
        string peso;
        string embalagem;
        string observacao;
        string frota;
        string status;
        string margem;

        public EmbarqueCs()
        { }

        public EmbarqueCs(PedidoCs pedido,
        VeiculoCs veiculo,
        string empresa,
        string filial,
        string unidadeEmbarque,
        string previsaoEmbarque,
        string dataEmbarque,
        string previsaoEntrega,
        string dataEntrega,
        string aceite,
        string adicional,
        string adiantamento,
        string meioPagamento,
        string meioPagamentoDois,
        string load,
        string mercadoria,
        string peso,
        string embalagem,
        string observacao,
        string frota,
        string status,
        string margem)
        {
            this.pedido = pedido;
            this.veiculo = veiculo;
            this.empresa = empresa;
            this.filial = filial;
            this.unidadeEmbarque = unidadeEmbarque;
            this.previsaoEmbarque = previsaoEmbarque;
            this.dataEmbarque = dataEmbarque;
            this.previsaoEntrega = previsaoEntrega;
            this.dataEntrega = dataEntrega;
            this.aceite = aceite;
            this.adicional = adicional;
            this.adiantamento = adiantamento;
            this.meioPagamento = meioPagamento;
            this.meioPagamentoDois = meioPagamentoDois;
            this.load = load;
            this.mercadoria = mercadoria;
            this.peso = peso;
            this.embalagem = embalagem;
            this.observacao = observacao;
            this.frota = frota;
            this.status = status;
            this.margem = margem;
        }

        public PedidoCs Pedido { get => pedido; set => pedido = value; }
        public VeiculoCs Veiculo { get => veiculo; set => veiculo = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Filial { get => filial; set => filial = value; }
        public string UnidadeEmbarque { get => unidadeEmbarque; set => unidadeEmbarque = value; }
        public string PrevisaoEmbarque { get => previsaoEmbarque; set => previsaoEmbarque = value; }
        public string DataEmbarque { get => dataEmbarque; set => dataEmbarque = value; }
        public string PrevisaoEntrega { get => previsaoEntrega; set => previsaoEntrega = value; }
        public string DataEntrega { get => dataEntrega; set => dataEntrega = value; }
        public string Aceite { get => aceite; set => aceite = value; }
        public string Adicional { get => adicional; set => adicional = value; }
        public string Adiantamento { get => adiantamento; set => adiantamento = value; }
        public string MeioPagamento { get => meioPagamento; set => meioPagamento = value; }
        public string MeioPagamentoDois { get => meioPagamentoDois; set => meioPagamentoDois = value; }
        public string Load { get => load; set => load = value; }
        public string Mercadoria { get => mercadoria; set => mercadoria = value; }
        public string Peso { get => peso; set => peso = value; }
        public string Embalagem { get => embalagem; set => embalagem = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Frota { get => frota; set => frota = value; }
        public string Status { get => status; set => status = value; }

        public string Margem { get => margem; set => margem = value; }
    }
}
