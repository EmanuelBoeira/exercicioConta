namespace exercicio1
{
    class ContaPoupança : Conta, IRendimento
    {
        public ContaPoupança(int agencia, int numero, string correntista, double saldo) : base(agencia, numero, correntista, saldo)
        {

        }

        public override void Saca(double valor)
        {
<<<<<<< HEAD
            if(valor < this.saldo)
=======
            if(valor < this.Saldo)
>>>>>>> 2cc6e87748edaac5c02414c810f0e451cd509b24
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
