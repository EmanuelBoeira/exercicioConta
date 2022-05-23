namespace exercicio1
{
    internal class ContaInvestimento : Conta, IRendimento, ITributavel
    {
        public ContaInvestimento(int agencia, int numero, string correntista, double saldo) : base(agencia, numero, correntista, saldo)
        {

        }

        public override void Saca(double valor)
        {
            if (valor < this.Saldo)
            {
                this.Saldo -= valor;
            }
        }

        public void Rendimento()
        {
            double rendimento = this.Saldo * 0.02;
            this.Saldo += rendimento;
        }

        public void Tributo()
        {
            double tributo = this.Saldo * 0.1;
            this.Saldo -= tributo;
        }
    }
}
