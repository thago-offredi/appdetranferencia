using System;

{
    
}
namespace transf.bank
{
    public class Conta
    {
        private TipoConta TipoConta {get; set; }
        private double Saldo { get; set; }
        private double Credito{ get; set; }
        private string Nome { get; set; }
        
        public Conta(TipoConta tipoConta, double Saldo, double Credito, string Nome)
    {
        this.TipoConta = tipoConta;
        this.Saldo = Saldo;
        this.Credito = Credito;
        this.Nome = Nome;
        }
        public bool Sacar (double valorSaque)
        {
            //validação 
            if (this.Saldo - valorSaque < (this.Credito *-1)){
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            this.Saldo = this.Saldo - valorSaque;

            Console.WriteLine("O Saldo atual da conta de {0} e {1}" + this.Nome , this.Saldo);
            return true;    
        }

        public void Depositar (double valorDeposito)
        {

            this.Saldo = this.Saldo + valorDeposito;

            Console.WriteLine("O Saldo atual da conta de {0} e {1}" + this.Nome , this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }
        
        public override string ToString(){

        
        string retorno= "";
        retorno += "TipoConta " + this.TipoConta + "|";
        retorno += "Nome" + this.Nome + "|";
        retorno += "Saldo"+ this.Saldo + "|";
        return retorno;
        }

        internal void Transferir(double valorTransferencia)
        {
            throw new NotImplementedException();
        }
    }
}