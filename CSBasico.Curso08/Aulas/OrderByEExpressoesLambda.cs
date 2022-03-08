using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasico.Aula08.Aulas
{
    public static class OrderByEExpressoesLambda
    {
        public static void OrderBy()
        {
            var lista = new List<MinhaClasse>() {
                new MinhaClasse(38, "Pam"),
                new MinhaClasse(40, "Rafa"),
                new MinhaClasse(18, "Vitor"),
                new MinhaClasse(2, "Z"),
                new MinhaClasse(59, "A")
            };

            IOrderedEnumerable<MinhaClasse> nomesOrdenados = lista.OrderBy(minhaClasse => minhaClasse.Nome);
            foreach (var item in nomesOrdenados)
            {
                Console.WriteLine($"{item.Nome} tem {item.Idade} anos.");
            }

            IOrderedEnumerable<MinhaClasse> idadesOrdenadas = lista.OrderBy(MinhaClasse => MinhaClasse.Idade);
            Console.WriteLine("--------");
            foreach (var item in idadesOrdenadas)
            {
                Console.WriteLine($"{item.Nome} tem {item.Idade} anos.");
            }
        }

        public static void ExpressoesLambda()
        {
            var lista = new List<MinhaClasse>() {
                new MinhaClasse(38, "Pam"),
                new MinhaClasse(40, "Rafa"),
                new MinhaClasse(18, "Vitor"),
                new MinhaClasse(2, "Z"),
                new MinhaClasse(59, "A")
            };

            IOrderedEnumerable<MinhaClasse> idadesOrdenadas = lista.OrderBy(
                minhaClasse => {
                    if (minhaClasse.Idade < 20)
                        minhaClasse.Idade += 50;
                    return minhaClasse.Idade; 
            });
            Console.WriteLine("--------");
            foreach (var item in idadesOrdenadas)
            {
                Console.WriteLine($"{item.Nome} tem {item.Idade} anos.");
            }

        }

        public static void ExecutarAula()
        {
            Console.WriteLine(".");
            Console.WriteLine("************** Iniciando OrderByEExpressoesLambda **************");

            OrderBy();
            ExpressoesLambda();

            Console.WriteLine("************** Finalizando OrderByEExpressoesLambda **************");
            Console.WriteLine(".");
        }
    }

    public class MinhaClasse
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public MinhaClasse(int idade, string nome)
        {
            Idade = idade;
            Nome = nome;
        }
    }

}
