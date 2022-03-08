using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasico.Aula07
{
    public class AulaListaArray
    {
        public static void CalculaAulaListaArray01()
        {
            ListaDeInt lista = new ListaDeInt();
            lista.Adicionar(0);
            lista.Adicionar(1);
            lista.Adicionar(2);
            lista.Adicionar(3);
            lista.Adicionar(4);
            lista.Adicionar(0);
            lista.Adicionar(1);
            lista.Adicionar(2);
            lista.Adicionar(3);
            lista.Adicionar(4);
            lista.Adicionar(0);
            lista.Adicionar(1);
            lista.Adicionar(2);
            lista.Adicionar(3);
            lista.Adicionar(4);
            lista.Adicionar(0);
            lista.Adicionar(1);
            lista.Adicionar(2);
            lista.Adicionar(3);
            lista.Adicionar(4);
            lista.Adicionar(0);
            lista.Adicionar(1);
            lista.Adicionar(2);
            lista.Adicionar(3);
            lista.Adicionar(4);

        }

        public static void CalculaAulaListaArray02()
        {
            ListaDeInt lista = new ListaDeInt();
            lista.Adicionar(0);
            lista.Adicionar(1);
            lista.Adicionar(2);
            lista.Adicionar(3);
            
            lista.Remover(0);
            lista.Remover(2);

            Console.WriteLine(lista.GetItemNoIndice(1));
            Console.WriteLine(lista[0]);


        }

        public static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int n in numeros)
            {
                acumulador += n;
            }
            return acumulador;
        }
    }
}
