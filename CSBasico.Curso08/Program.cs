using System;
using System.Collections.Generic;
using CSBasico.Aula08.Aulas;

namespace CSBasico.Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            ListEMetodosDeExtensao.ExecutarAula();
            MetodoDeExtensaoGenerico.ExecutarAula();
            UsandoVarEMetodoSort.ExecutarAula();
            IComparableEIComparer.ExecutarAula();
            OrderByEExpressoesLambda.ExecutarAula();
            LinqEOperadorWhere.ExecutarAula();

            Console.ReadLine();
        }
    }
}
