using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Gerente : Funcionario
    {
        public double Bônus { get; set; }
      public string Setor { get; set; }
      public Gerente(string nome, int cpf, string registro, string email, string data,string setor): base(string nome, int cpf, string registro, string email, string data)
      
          this.Setor = setor;
      
      public string fomulario(string nome, int cpf, string registro, string email, string data,string setor)
      {   
       return String.Format(nome, cpf, registro, email, data,setor);
       }
    }
}
