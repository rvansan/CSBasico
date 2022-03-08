using System;
using System.Text.RegularExpressions;

namespace Aula06
{
    public class AulaRegex
    {
        string padrao = null;

        public void CalculaAulaRegex()
        {
            padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"; // T(8765-4321), F, T(8765-4321), F
            padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"; // T(8765-4321), F, T(8765-4321), F
            padrao = "[0-9]{4}[-][0-9]{4}"; // T(8765-4321), F, T(8765-4321), F
            padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}"; // T(8765-4321), T(87654321), T(98765-4321), T(987654321) 
            padrao = "[0-9]{4,5}-?[0-9]{4}"; // T(8765-4321), T(87654321), T(98765-4321), T(987654321)

            string texto1 = "Meu telefone antigo cel era 8765-4321.";
            string texto2 = "Meu telefone antigo cel era 87654321.";
            string texto3 = "Meu novo cel é 98765-4321.";
            string texto4 = "Meu novo cel é 987654321";

            bool isMatch1 = Regex.IsMatch(texto1, padrao);
            bool isMatch2 = Regex.IsMatch(texto2, padrao);
            bool isMatch3 = Regex.IsMatch(texto3, padrao);
            bool isMatch4 = Regex.IsMatch(texto4, padrao);
            Console.WriteLine(isMatch1);
            Console.WriteLine(isMatch2);
            Console.WriteLine(isMatch3);
            Console.WriteLine(isMatch4);

            Match match1 = Regex.Match(texto1, padrao);
            Match match2 = Regex.Match(texto2, padrao);
            Match match3 = Regex.Match(texto3, padrao);
            Match match4 = Regex.Match(texto4, padrao);
            Console.WriteLine(match1.Value);
            Console.WriteLine(match2.Value);
            Console.WriteLine(match3.Value);
            Console.WriteLine(match4.Value);

        }
    }
}
