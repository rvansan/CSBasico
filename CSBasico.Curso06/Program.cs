using System;
using System.Text.RegularExpressions;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            AulaRegex aulaRegex = new AulaRegex();
            aulaRegex.CalculaAulaRegex();
                        
            AulaClasseObject.CalculaAulaClasseObject();

            Console.ReadLine();
        }
    }
}
