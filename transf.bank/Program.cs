using System;
using System.Collections.Generic;
namespace transf.bank

{
    class Program
    {

            static List<Conta>listContas =  new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();  

            while(opcaoUsuario.ToUpper()!="S")
            {

                switch(opcaoUsuario)
                {
                    case "1":
                    //LISTARCONTAS();
                    break;
                
                    case "2":
                    INSERIRCONTA();
                    break;
                
                    case "3":
                    Transferir();
                    break;
                
                    case "4":
                    Sacar();
                    break;
                
                    case "5":
                    Depositar();
                    break;
                
                    //case "L":
                    //CONSOLE.CLEAR();
                    //break;

                default:
                throw new ArgumentOutOfRangeException();    
            
                
                }
                opcaoUsuario = ObterOpcaoUsuario();
                {
                    Console.WriteLine("Obrigado por utilizar nossos serviços. ");
                    Console.ReadLine();
                }

            }
        }

        private static void Sacar()
        {
            
            Console.Write("Digite o número da conta ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta] .Sacar(valorSaque);

        }
         private static void Depositar()
        {
            
            Console.Write("Digite o número da conta ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta] .Depositar(valorDeposito);

        }

             private static void Transferir()
        {
            
            Console.Write("Digite o número da conta de origem  ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino ");
            int indiceContaDestino = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor a ser transferido ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem] .Transferir(valorTransferencia, listContas[indiceContaDestino]);

        }



        private static void INSERIRCONTA()
        {
            throw new NotImplementedException();
        }
 private static void InserirConta()
        {
                Console.WriteLine("Inserir nova conta ");
                
                Console.Write("Digite 1 para conta fisica ou 2 para conta juridica: *");
                int entradaTipoConta = int.Parse(Console.ReadLine());
                
                Console.Write("Digite o nome do cliente: ");
                
                string entradaNome = Console.ReadLine();
                
                Console.Write("Digite o saldo inicial:");
                double entradaSaldo = double.Parse(Console.ReadLine());
                
                Console.Write("Digite o credito:");
                double entradaCredito = double.Parse(Console.ReadLine());

                Conta novaConta = new Conta (tipoConta: (TipoConta)entradaTipoConta,
                                             Saldo: entradaSaldo,
                                             Credito: entradaCredito,
                                             Nome: entradaNome);
                listContas.Add (novaConta);
                
                
        }
        private static void LISTARCONTAS()
        {
            Console.WriteLine("Listar contas ");
        
            if(listContas.Count ==0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return; 
            }

            for(int i = 0 ; i < listContas.Count; i ++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", + i);
                Console.WriteLine(conta);
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("TRANS BANK  AO SEU DISPOR!* ");
            Console.WriteLine("INFORME A OPÇÃO DESEJADA:*");
            Console.WriteLine("*1- LISTAR CONTAS");
            Console.WriteLine("*2- INSERIR NOVA CONTA");
            Console.WriteLine("*3- TRANSFERIR");
            Console.WriteLine("*4- SACAR");
            Console.WriteLine("*5- DEPOSITAR");
            Console.WriteLine("*L- LIMPA A TELA");
            Console.WriteLine("*S- SAIR");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
         }

       

    }
}

