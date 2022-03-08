using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasico.Aula08.Aulas
{
    public static class UsandoVarEMetodoSort
    {
        private static void UsandoVar()
        {
            var i = 1;

            var s = "texto";

            Console.WriteLine("UsandoVar:");
            Console.WriteLine($"Criação da variáve 'i' e lhe atribuindo valor numérico: {i}");
            Console.WriteLine($"Criação da variáve 's' e lhe atribuindo valor tipo string: {s}");

        }

        private static void MetodoSort()
        {
            var idades = new List<int>() {
                3,5,73,6,86,43,56,9,54
            };

            Console.WriteLine("Lista antes de ordenar:");
            foreach (var item in idades)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Lista depois de ordenar:");
            idades.Sort();
            foreach (var item in idades)
            {
                Console.WriteLine(item);
            }

            var nomes = new List<string>() {
                "Rafa", "F", "A", "Pam"
            };

            Console.WriteLine("Lista antes de ordenar:");
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Lista depois de ordenar:");
            nomes.Sort();
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }


        }

        public static void ExecutarAula()
        {
            Console.WriteLine(".");
            Console.WriteLine("************** Iniciando UsandoVarEMetodoSort **************");

            UsandoVar();
            MetodoSort();

            Console.WriteLine("************** Finalizando UsandoVarEMetodoSort **************");
            Console.WriteLine(".");
        }
    }
}
