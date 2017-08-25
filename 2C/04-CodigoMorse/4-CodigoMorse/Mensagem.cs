,using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CodigoMorse
{
    class Mensagem
    {
        public string texto;
        string[] tabela = new string [1]
        {
          ".-","-...","-.-.",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","...","-","..-","...-",".--", "-..-","-.--","--.."
        };

        char[] tabela2 = new char [26]
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
        };

        public string codificar ()  
        {
                int i = 0;
                int[] pos = new int[26];
                while (i<texto.Length)
                {
                    pos[i] = texto[i] - 'A';
                     i++;
                }
                i = 0;
              
         while (i<texto.Length)
         {
             retorno [i] = tabela[pos[i]
         
        }

        public void decodificar ()
        {
         int i = 0;
         while
        }


        }

    }
}
