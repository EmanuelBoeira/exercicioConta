namespace exercicio1
{
    class ContaCorrente : Conta, ITributavel
    {
        public ContaCorrente(int agencia, int numero, string correntista, double saldo) : base(agencia, numero, correntista, saldo)
        {

        }

        public override void Saca(double valor)
        {
            if(valor < this.Saldo)
            {
                this.Saldo -= valor + 4;
            }
        }

        public void Tributo()
        {
            double tributo = this.Saldo * 0.1;
            this.Saldo -= tributo;
        }
    }
}
