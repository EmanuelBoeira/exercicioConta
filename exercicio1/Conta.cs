namespace exercicio1
{
    abstract class Conta
    {
        private int agencia;
        private int numero;
        private string correntista;
        private double saldo;

        public int Agencia
        {
            get
            {
                return this.agencia;
            }
            set
            {
                this.agencia = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public string Correntista
        {
            get
            {
                return this.correntista;
            }
            set
            {
                this.correntista = value;
            }
        }

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

        public abstract void Saca(double valor);

        public Conta(int agencia, int numero, string correntista, double saldo)
        {
            this.agencia = agencia;
            this.numero = numero;
            this.correntista = correntista;
            this.saldo = saldo;
        }

        public  void Deposita(double valor)
        {
            saldo += valor;
        }

    }
}
