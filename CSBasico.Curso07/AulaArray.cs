using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasico.Aula07
{
    public class AulaArray
    {

        public static void CalculaAulaArray()
        {
            int[] idades = new int[5];

            double[] minhasContas = null;
            minhasContas = new double[8];

            bool[] meuByte = new bool[]
            {
                true,
                true,
                false,
                false,
                false,
                false,
                true,
                false
            };

            Console.WriteLine($"{meuByte[0]} {meuByte[1]} {meuByte[2]} {meuByte[3]} {meuByte[4]} {meuByte[5]} {meuByte[6]} {meuByte[7]}");

            idades[0] = 18;
            idades[1] = 22;
            idades[2] = 27;
            idades[3] = 30;
            idades[4] = 40;

            int acumulador = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                acumulador += idades[i];
                Console.WriteLine($"Iterando no índice {i} : [{i}] = {idades[i]}");
            }

            double media = (double)acumulador / idades.Length;

            Console.WriteLine(media);


        }
    }
}
