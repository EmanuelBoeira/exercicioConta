namespace exercicio1
{
    class ContaPoupança : Conta
    {
        public ContaPoupança(int agencia, int numero, string correntista, double saldo) : base(agencia, numero, correntista, saldo)
        {

        }

        public override void Saca(double valor)
        {
            if(valor < this.saldo)
            {
                this.Saldo -= valor;
            }
        }

        public void CalculaRendimento()
        {

        }
    }
}
