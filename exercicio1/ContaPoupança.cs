namespace exercicio1
{
    class ContaPoupança : Conta, IRendimento
    {
        public ContaPoupança(int agencia, int numero, string correntista, double saldo) : base(agencia, numero, correntista, saldo)
        {

        }

        public override void Saca(double valor)
        {

            if(valor < this.Saldo)

            if(valor < this.Saldo)

            {
                this.Saldo -= valor;
            }
        }

        public void CalculaRendimento()
        {

        }

        public void Rendimento()
        {
            double rendimento = this.Saldo * 0.005;
            this.Saldo += rendimento;
        }
    }
}
