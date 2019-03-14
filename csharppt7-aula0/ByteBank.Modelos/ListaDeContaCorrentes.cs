using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ListaDeContaCorrentes
    {

        private ContaCorrente[] _itens;
        private int _proximaPosicao;
        
        
        
        public int Tamanho
        {
            get
            {
                //a nossa _proximaPosicao coincide com o número de elementos que já existem no nosso array. 
                return _proximaPosicao;
            }
        }

        public ListaDeContaCorrentes()
        {
            _itens = new ContaCorrente[5];
            _proximaPosicao = 0;

        }
        public void Adicionar(ContaCorrente item)
        {
            verificarCapacidade(_proximaPosicao + 1);
            Console.WriteLine($"Adicionando no índice {_proximaPosicao} conta {item.Agencia}/{item.Numero}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
            
        }
        public void remover( ContaCorrente item)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente itemAtual = _itens[i];
                //o Equals sobre um override
                if (itemAtual.Equals(item))
                {
                    // aqui tem o indice real do objeto que se deseja excluir
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao -1 ; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;

            _itens[_proximaPosicao] = null;
        }
        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente conta = _itens[i];
                Console.WriteLine($"Conta  ----- indice{i}  agência :  {conta.Agencia} numero : {conta.Numero}");
            }
        }

        public void verificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length>=tamanhoNecessario)
            {
                return;
            }
            int novoTamanho = _itens.Length * 2;
          
                // se for necessário mais espaço    
            if (novoTamanho<tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
               
            }
            Console.WriteLine("aumentando capacidade da lista...");
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];
            //repassando os itens contidos em _itens para novoArray
            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                //_itens passa a ser o array principal recebendo todos os dados de novoArray

            }
            _itens = novoArray;

        }
        // Método para realizar a soma de números dentro de um vetor 
        // utilizando a sintaxe no for, serve tqanto para números pares como ímpares
        public static void SomarNumeros(int[] numeros)
        {
            int soma = 0;
           
                for (int i = 0; i < numeros.Length -1; i = i+2)
                {
                  
                    soma = numeros[i] + numeros[i + 1];
                    Console.WriteLine(" a soma " + numeros[i]+" + " + numeros[i + 1] + " = "+ soma  );
                }         
        }
        // chamar uma conta corrente pelo índice
        public ContaCorrente GetItemNoIndice (int indice)
        {
            if (indice <0 || indice >= _proximaPosicao )
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }
        // indexador (acesso por meio de índices)
        public ContaCorrente this[string texto]
        {
            get
            {
                return null;
            }
        }

        //indexador (acesso por meio de índices)
        public ContaCorrente this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
           
        }
        // com utilização do params, pode-se realizar a inserção de vários objetos por meio do método Adcionar
        // sem que precise criar sobrecargas
        public void AdicionarVarios(params ContaCorrente[] itens)
        {
            foreach (ContaCorrente conta in itens)
            {
                Adicionar(conta);
            }
        }
    }
}
