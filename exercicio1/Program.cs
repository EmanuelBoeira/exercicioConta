using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool aux = true;
            //local onde todo o programa é executado.
            while(aux)
            {
                Console.WriteLine("Escolha uma das opções:\n1 - Adicionar Conta\n2 - Editar Conta\n3 - Listar as Contas\n4 - Consultar Conta\n5 - Excluir Conta\n6 - Sair");

                char resposta = Console.ReadLine()[0];

                //veruficação da resposta do usuário usando o switch case.
                switch(resposta)
                {
                    case '1': Program.AdicionarConta(); break;
                    case '2': Program.EditarConta(); break;
                    case '3': Program.ListarTodasContas(); break;
                    case '4': Program.ConsultarConta(); break;
                    case '5': Program.ExcluirConta(); break;
                    case '6': aux = false; break;
                    default : Console.WriteLine("valor inválido"); break; 
                }
            }

        }

        //este método usa o método CrudConta.Adicionar da classe CrudConta, para adicionar um novo objeto do tipo Conta no list em CrudConta 
        static void AdicionarConta()
        {
            Console.WriteLine("Escolha uma das opções:\n 1 - Conta Poupança.\n 2 - Conta Corrente");
            string resposta = Console.ReadLine();

            switch (resposta[0])
            {
                case '1': 
                    {
                        Console.Write("Qual o número da agencia: ");
                        int agencia = Int32.Parse(Console.ReadLine());
                        
                        Console.Write("Qual o número da conta: ");
                        int numConta = Int32.Parse(Console.ReadLine());
                        
                        Console.Write("Qual o correntista: ");
                        string correntista = Console.ReadLine();
                        
                        Console.Write("Qual o valor: ");
                        Double valor = Double.Parse(Console.ReadLine());
                        
                        ContaPoupança conta = new ContaPoupança(agencia, numConta, correntista, valor);

                        CrudConta.Adicionar(conta);
                        break;
                    }
                case '2':
                    {
                        Console.Write("Qual o número da agencia: ");
                        int agencia = Int32.Parse(Console.ReadLine());
                        
                        Console.Write("Qual o número da conta: ");
                        int numConta = Int32.Parse(Console.ReadLine());
                        
                        Console.Write("Qual o correntista: ");
                        string correntista = Console.ReadLine();
                        
                        Console.Write("Qual o valor: ");
                        Double valor = Double.Parse(Console.ReadLine());
                        
                        ContaCorrente conta = new ContaCorrente(agencia, numConta, correntista, valor);

                        CrudConta.Adicionar(conta);
                        break;
                    }
                default : Console.WriteLine("valor inválido"); break;
            }
        }

        //este método usa o método CrudConta.Editar da classe CrudConta, para alterar as propriedade de uma Conta selecionada
        static void EditarConta()
        {
            Console.Write("\nMe informe o número da conta: ");
            int numConta = Int32.Parse(Console.ReadLine());

            Conta conta = CrudConta.ConsultarPorNum(numConta);

            if(conta != null)
            {
                Console.Write("\nMe informe a nova agência: ");
                int novaAgencia = Int32.Parse(Console.ReadLine());
                conta.Agencia = novaAgencia;

                Console.Write("\nMe informe o novo correntista: ");
                string novoCorrentista = Console.ReadLine();
                conta.Correntista = novoCorrentista;

                Console.Write("\nMe informe o novo saldo: ");
                Double novoSaldo = Double.Parse(Console.ReadLine());
                conta.Saldo = novoSaldo;
            }
            else
            {
                Console.WriteLine("valor inválido");
            }
        }

        //esse método mostra todas as contas que estiverem no list de contas em CrudConta.
        static void ListarTodasContas()
        {
            CrudConta.MostrarContas();
        }

        //este método usa o método CrudConta.ConsultaPorNum da classe CrudConta, para procurar por uma Conta com o Conta.Numero igual ao fornecido
        static void ConsultarConta()
        {
            Console.Write("\nMe informe o número da conta: ");
            int numConta = Int32.Parse(Console.ReadLine());

            Conta conta = CrudConta.ConsultarPorNum(numConta);

            if(conta != null)
            {
                Console.WriteLine($"Agência: {conta.Agencia}\nNúmero: {conta.Numero}\nCorrentista: {conta.Correntista}\nSaldo: {conta.Saldo}");
            }
            else
            {
                Console.WriteLine("valor inválido");
            }
        }

        //este método usa o método CrudConta.Editar da classe CrudConta, para excluir a conta fornecida
        static void ExcluirConta()
        {
            Console.Write("\nMe informe o número da conta: ");
            int numConta = Int32.Parse(Console.ReadLine());

            Conta conta = CrudConta.ConsultarPorNum(numConta);

            if(conta != null)
            {
                CrudConta.Excluir(conta);
                Console.WriteLine("Conta excluida com sucesso!");
            }
            else
            {
                Console.WriteLine("valor inválido");
            }
        }
    }
}
