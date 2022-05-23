namespace exercicio1
{
    class ContaCorrente : Conta, ITributavel
    {
        public ContaCorrente(int agencia, int numero, string correntista, double saldo) : base(agencia, numero, correntista, saldo)
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
