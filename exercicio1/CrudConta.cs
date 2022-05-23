using System.Collections.Generic;
using System;

namespace exercicio1
{
    class CrudConta
    {
        private static List<Conta> contas = new List<Conta>(); 

        public static void Adicionar(Conta conta)
        {
            contas.Add(conta);
        }

        public static void Excluir(Conta conta)
        {
            int numConta = conta.Numero;

            foreach(Conta c in contas)
            {
                if(c.Numero == numConta)
                {
                    contas.Remove(c);
                    Console.WriteLine("excluido");
                }
                else
                {
                    Console.WriteLine("valor inválido");
                }
            }
        }

        public static Conta ConsultarPorNum(int numero)
        {
            foreach(Conta elemento in contas)
            {
                if (elemento.Numero == numero)
                {
                    return elemento;

                }
                else
                {
                    return null;
                }
            }
            //podem haver situações em que não executa nem o if nem o else, como se a list estivesse vazia
            return null;
        }

        public static void Editar(Conta conta, int agencia, string correntista, double saldo)
        {
            foreach(var elemento in contas)
            {
                if (conta == elemento)
                {
                    elemento.Agencia = agencia;
                    elemento.Correntista = correntista;
                    elemento.Saldo = saldo;
                }
            }
        }

        public static void MostrarContas()
        {
            Console.WriteLine("\tAgência|\tNúmero|\tCorrentista|\tSaldo");
            foreach(Conta conta in contas)
            {
                Console.WriteLine($"\t{conta.Agencia}|\t{conta.Numero}|\t{conta.Correntista}|\t{conta.Saldo}");
            }
        }
    }
}
