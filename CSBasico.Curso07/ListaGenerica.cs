using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasico.Aula07
{
    public class ListaGenerica<T>
    {
        private T[] _itens;
        private int _proximaPosicao;

        public ListaGenerica(int capacidadeInicial = 5)
        {
            _itens = new T[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionando o item {item} na posicao {_proximaPosicao}");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(T item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(item))
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
            //_itens[_proximaPosicao] = 0;
        }

        public T GetItemNoIndice(int indice)
        {
            if (indice < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return _itens[indice];
        }

        public T this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            Console.WriteLine("Aumentando a capacidade da lista");

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            T[] novoArray = new T[novoTamanho];

            for (int i = 0; i < _itens.Length; i++)
            {
                Console.WriteLine(".");
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }
    }
}
