using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tellinhas_cantina
{
    internal class Produto
    {
        public string nome { get; set; }
        public decimal valor { get; set; }
        public bool cozinha { get; set; } 

        public Produto(string nome, decimal valor)
        {
            this.nome = nome;
            this.valor = valor;
            
        }

        public override string ToString()
        {
            return $"{nome}-R${valor}";
        }
    }
}
