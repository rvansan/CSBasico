using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasico.Aula08.Aulas
{
    public static class ListEMetodosDeExtensao
    {
        public static void AdicionarVariosStatic(List<int> list, params int[] itens)
        {
            foreach (int item in itens)
            {
                list.Add(item);
            }
        }

        public static void AdicionarVariosInstancia(this List<int> list, params int[] itens)
        {
            AdicionarVariosStatic(list, itens);
        }

        public static void ImprimirStatic(List<int> list)
        {
            Console.WriteLine("imprimindo itens da lista:");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void ImprimirInstancia(this List<int> list)
        {
            ImprimirStatic(list);
        }

        public static void ExecutarAula()
        {
            Console.WriteLine(".");
            Console.WriteLine("************** Iniciando ListEMetodosDeExtensao **************");

            List<int> idades = new List<int>();
            AdicionarVariosStatic(idades, 12, 18, 16, 24, 30, 40);
            ImprimirStatic(idades);
            idades.AdicionarVariosInstancia(50, 65);
            idades.ImprimirInstancia();


            Console.WriteLine("************** Finalizando ListEMetodosDeExtensao **************");
            Console.WriteLine(".");
        }
    }
}
