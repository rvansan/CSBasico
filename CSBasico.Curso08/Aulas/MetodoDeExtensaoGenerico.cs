using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasico.Aula08.Aulas
{
    public static class MetodoDeExtensaoGenerico
    {
        private static void AdicionarVarios<T>(this List<T> list, params T[] itens)
        {
            foreach (T item in itens)
            {
                list.Add(item);
            }
        }

        public static void ExecutarAula()
        {
            Console.WriteLine(".");
            Console.WriteLine("************** Iniciando MetodoDeExtensaoGenerico **************");

            List<int> idadesGenerica = new List<int>();
            idadesGenerica.AdicionarVarios(1, 2, 3, 4, 5, 6);
            idadesGenerica.ImprimirInstancia();

            Console.WriteLine("************** Finalizando MetodoDeExtensaoGenerico **************");
            Console.WriteLine(".");
        }


    }
}
