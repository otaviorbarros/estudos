using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3
{
    class ProdutoVO
    {
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public void SomaValor(double valor, int qtde)
        {
            valor *= qtde;

        }
    }

}
