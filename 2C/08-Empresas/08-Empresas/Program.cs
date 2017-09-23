using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipo;
            Console.WriteLine("Os tipos de funcionários são: empregado (1), gerente (2), terceirizado (3)");
            tipo = int.Parse(Console.ReadLine());

            string email, nome, data, registro, setor, empresa;
            int cpf;
            Console.WriteLine("Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("CPF:");
            cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de registro:");
            registro = Console.ReadLine();

            Console.WriteLine("E-mail:");
            email = Console.ReadLine();

            Console.WriteLine("Data :");
            data = Console.ReadLine();

            Console.WriteLine("Setor:");
            setor = Console.ReadLine();

            Console.WriteLine("Empresa:");
            empresa = Console.ReadLine();


            Funcionario f = new Funcionario(nome, cpf, registro, email, data);
            Gerente g = new Gerente(nome, cpf, registro, email, data, setor);
            Empregado e = new Empregado(nome, cpf, registro, email, data);
            Terceirizado t = new Terceirizado(nome, cpf, registro, email, data, empresa);

            if (tipo == 1)
            {
                Console.Write(e.formulario(nome, cpf, registro, email, data));
            }

            else if (tipo == 2)
            {
                Console.Write(g.formulario(nome, cpf, registro, email, data, setor));
            }

            else if (tipo == 3)
            {
                Console.Write(t.formulario(nome, cpf, registro, email, data, empresa));
            }        
         
        }
    }
}
