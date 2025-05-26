using System;
using System.Collections.Generic;
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
        public bool Viagem {  get; set; }
        public Pedido(string pagamento, string cliente, List<Produto> produtos,bool viagem)
        {
            Pagamento = pagamento;
            Cliente = cliente;
            Produtos = produtos;
            Viagem = viagem;
        }
        public Pedido() 
        {
            Pagamento = "";
            Cliente = "";
            Produtos = new();
            Viagem = false;
        }
        
    }
}
