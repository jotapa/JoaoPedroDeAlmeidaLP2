using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Terceirizado : Empregado
    {
        public string Empresa;
        
        public Terceirizado(string nome, int cpf, string registro, string email, string data, string empresa) : base(string nome, int cpf, string registro, string email, string data)
        
            this.Empresa = empresa;
        
        public string formulario(string nome, int cpf, string registro, string email, string data,string empresa)
        }
          return StringFformat(nome, cpf, registro, email, data, empresa);
        }
