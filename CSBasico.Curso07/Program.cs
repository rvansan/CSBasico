using System;

namespace CSBasico.Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            //AulaArray.CalculaAulaArray();
            //AulaListaArray.CalculaAulaListaArray01();
            //AulaListaArray.CalculaAulaListaArray02();
            
            int soma = AulaListaArray.SomarVarios(1, 2, 3, 4, 5, 6, 6, 7);
            Console.WriteLine(soma);
            
            
            Console.ReadLine();
        }
    }
}
