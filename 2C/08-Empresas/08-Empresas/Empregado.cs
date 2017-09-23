using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Empregado :Funcionario
    {   
        
        public Empregado(string nome, int cpf, string registro, string email, string data) : base(string nome, int cpf, string registro, string email, string data)
          
          public string fomulario(string nome, int cpf, string registro, string email, string data);
          
        
            return String.Format(nome, cpf, registro, email, data);
        
