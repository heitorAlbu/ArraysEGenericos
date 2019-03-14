using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrentes lista = new ListaDeContaCorrentes();

            ContaCorrente ContadoGui = new ContaCorrente(123, 00999);
            lista.Adicionar(ContadoGui);
            /*
            lista.Adicionar(new ContaCorrente(345, 23462));
            lista.Adicionar(new ContaCorrente(363, 22451));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(735, 23552));
            */
            // lista.EscreverListaNaTela();

            // lista.remover(ContadoGui);

            // Console.WriteLine("após remover o item...");
            // lista.EscreverListaNaTela();
            /*
             int[] numeros = { 1, 2, 3, 4 };

             ListaDeContaCorrentes.SomarNumeros(numeros);
             */

            //método GetItemNoIndice visa mostrar o elemento no array dentro da estrutura 
            // de repetição for a  partir do encapsulamento do atributo Tamanho em listaDeContaCorrentes 


            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente teste = lista["texto"]; // acessar um item por meio de qualquer tipo de indice (indexador)
                ContaCorrente itemAtual = lista.GetItemNoIndice(i); 
                Console.WriteLine($"Item na posição {i}= Conta {itemAtual.Numero}/{itemAtual.Agencia} ");
            }

            //utilizando o params
            lista.AdicionarVarios(ContadoGui, new ContaCorrente(735, 23552));


            Console.ReadKey();
        }
    }
}
