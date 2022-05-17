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

        }

        //este método usa o método CrudConta.Editar da classe CrudConta, para alterar as propriedade de uma Conta selecionada
        static void EditarConta()
        {

        }

        //esse método...
        static void ListarTodasContas()
        {

        }

        //este método usa o método CrudConta.ConsultaPorNum da classe CrudConta, para procurar por uma Conta com o Conta.Numero igual ao fornecido
        static void ConsultarConta()
        {

        }

        //este método usa o método CrudConta.Editar da classe CrudConta, para excluir a conta fornecida
        static void ExcluirConta()
        {

        }
    }
}
