using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasico.Aula07
{
    public class ListaDeInt
    {
        private int[] _itens;
        private int _proximaPosicao;

        public ListaDeInt(int capacidadeInicial = 5)
        {
            _itens = new int[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(int item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionando o item {item} na posicao {_proximaPosicao}");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(int item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if(_itens[i] == item)
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = 0;
        }

        public int GetItemNoIndice(int indice)
        {
            if(indice < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return _itens[indice];
        }

        public int this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }



        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            Console.WriteLine("Aumentando a capacidade da lista");

            int novoTamanho = _itens.Length * 2;
            if(novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            int[] novoArray = new int[novoTamanho];

            for (int i = 0; i < _itens.Length; i++)
            {
                Console.WriteLine(".");
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }
    }
}
