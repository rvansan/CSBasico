using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasico.Aula08.Aulas
{
    public static class IComparableEIComparer
    {
        private static void UsandoIComparable()
        {
            var lista = new List<ClasseIComparable>() {
                new ClasseIComparable(40, "Rafa"),
                new ClasseIComparable(38, "Pam"),
                new ClasseIComparable(66, "Zé"),
                new ClasseIComparable(90, "Ana")
            };

            Console.WriteLine("Lista antes de ordenar:");
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Nome}: {item.Idade} anos");
            }

            Console.WriteLine("Lista depois de ordenar:");
            lista.Sort();
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Nome}: {item.Idade} anos");
            }
        }
        private static void UsandoIComparer ()
        {
            var lista = new List<ClasseIComparable>() {
                new ClasseIComparable(40, "Rafa"),
                new ClasseIComparable(38, "Pam"),
                new ClasseIComparable(66, "Zé"),
                new ClasseIComparable(90, "Ana")
            };

            Console.WriteLine("Lista antes de ordenar:");
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Nome}: {item.Idade} anos");
            }

            Console.WriteLine("Lista depois de ordenar:");
            lista.Sort(new ClasseIComparer());
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Nome}: {item.Idade} anos");
            }
        }


        public static void ExecutarAula()
        {
            Console.WriteLine(".");
            Console.WriteLine("************** Iniciando IComparableEIComparer **************");

            UsandoIComparable();
            UsandoIComparer();

            Console.WriteLine("************** Finalizando IComparableEIComparer **************");
            Console.WriteLine(".");
        }
    }

    public class ClasseIComparable : IComparable
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        
        public ClasseIComparable(int idade, string nome)
        {
            Idade = idade;
            Nome = nome;
        }
        public int CompareTo(object obj)
        {
            var objeto = obj as ClasseIComparable;

            if (objeto == null)
                return 1;

            if (objeto.Idade > Idade)
                return -1;

            if (objeto.Idade == Idade)
                return 0;

            return 1;
        }
    }

    public class ClasseIComparer : IComparer<ClasseIComparable>
    {
        public int Compare(ClasseIComparable x, ClasseIComparable y)
        {
            if (x == y)
                return 0;

            return x.Nome.CompareTo(y.Nome);
        }
    }
}
