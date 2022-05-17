using System.Collections.Generic;

namespace exercicio1
{
    class CrudConta
    {
        private List<Conta> contas = new List<Conta>(); 

        public void Adicionar(Conta conta)
        {
            contas.Add(conta);
        }

        public void Excluir(Conta conta)
        {
            foreach(var elemento in contas)
            {
                if(elemento == conta)
                {
                    contas.Remove(elemento);
                }
            }
        }

        public Conta ConsultarPorNum(int numero)
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

        public void Editar(Conta conta, int agencia, string correntista, double saldo)
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
    }
}
