using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Produtos
{
    class Produto
    {
       private int id;
        public int Id 
        {
            get { return id; }
        }
        public double preco { get; set; }
      
        private string nome;
        public string Nome {
            get { return nome; }
        }
        public int Quant;

        public Produto (int id ,string nome , double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.Quant = 0;
        }
        public void Receber(int qtd)
        {
            
                Quant += qtd;
            
        }
         public void Retirada (int qtd)
        {
             if (Quant >=qtd)
             {
                 Quant -= qtd;
             }
             else
             {
                 throw new Exception();

             } 

        }
        public string Imprimir()
         {
             return String.Format("ID {0} - NOME {1} - PREÇO {2;0,00} ", id, nome, preco,Quant);
         }
    }
}
