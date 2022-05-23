namespace exercicio1
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(int agencia, int numero, string correntista, double saldo) : base(agencia, numero, correntista, saldo)
        {

        }

        public override void Saca(double valor)
        {
            if(valor < this.saldo)
            {
                this.Saldo -= valor + 4;
            }
        }
    }
}
