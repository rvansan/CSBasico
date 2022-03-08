using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasico.Aula08.Aulas
{
    public static class LinqEOperadorWhere
    {
        
        public static void UsandoLinqEOperadorWhere()
        {
            var lista = new List<MinhaClasse>() {
                new MinhaClasse(38, "Pam"),
                new MinhaClasse(40, "Rafa"),
                new MinhaClasse(18, "Vitor"),
                null,
                null,
                new MinhaClasse(2, "Z"),
                null,
                new MinhaClasse(59, "A")
            };
            
            foreach (var item in lista)
            {
                if(item == null)
                    Console.WriteLine("null");
                else
                    Console.WriteLine($"{item.Nome} tem {item.Idade} anos.");
            }


            var ordenadosSemNull = lista
                .Where(minhaClasse => minhaClasse != null)
                .OrderBy(minhaClasse => minhaClasse.Idade);

            Console.WriteLine("--------");
            foreach (var item in ordenadosSemNull)
            {
                Console.WriteLine($"{item.Nome} tem {item.Idade} anos.");
            }
        }

        public static void ExecutarAula()
        {
            Console.WriteLine(".");
            Console.WriteLine("************** Iniciando LinqEOperadorWhere **************");

            UsandoLinqEOperadorWhere();

            Console.WriteLine("************** Finalizando LinqEOperadorWhere **************");
            Console.WriteLine(".");
        }
    }
}
