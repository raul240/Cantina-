using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tellinhas_cantina
{

    internal class Pedido
    {
        public string Pagamento { get; set; }
        public string Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
        public bool Viagem { get; set; }
        //public Status testes { get; set; }

        public Status.status status { get; set; }
       
        public Pedido(string pagamento, string cliente, List<Produto> produtos, bool viagem, Status status)
        {
            Pagamento = pagamento;
            Cliente = cliente;
            Produtos = produtos;
            Viagem = viagem;
            this.status = Status.status.PEDINDO;

        }
        public Pedido()
        {
            Pagamento = "";
            Cliente = "";
            Produtos = new();
            Viagem = false;
            status = Status.status.PEDINDO;


        }
        public override string ToString()
        {
            string novo= " ";
            foreach (Produto produto in Produtos)
            {
                novo = String.Concat(novo , produto. nome);
            }
            return $" {Cliente} - { novo } ";


        }
        
    }
}
