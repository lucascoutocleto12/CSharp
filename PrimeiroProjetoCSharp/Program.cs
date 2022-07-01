using System; 
namespace PrimeiroProjetoCSharp
{
    class Program
    {
        static void Main(String[] args)
        {
            //Conta 1
            ContaCorrente conta_1 = new ContaCorrente ("Lucas", 12345, 116, 356);
            Console.WriteLine("O nome do(a) Titular é " + conta_1.Titular + 
                              ", o número da Agência é " + conta_1.Agencia + 
                              " e o número da conta é " + conta_1.Numero + ".");
            //Escreve informacoes da conta 1
            
            //Conta 2
            ContaCorrente conta_2 = new ContaCorrente ("Bárbara", 12345, 117, 830);
            Console.WriteLine("O nome do(a) Titular é " + conta_2.Titular + 
                              ", o número da Agência é " + conta_2.Agencia + 
                              " e o número da conta é " + conta_2.Numero + ".");
            //Escreve informacoes da conta 2

            //Conta 3
            ContaCorrente conta_3 = new ContaCorrente ("Kléber", 12345, 118, 8567);
            Console.WriteLine("O nome do(a) Titular é " + conta_3.Titular + 
                              ", o número da Agência é " + conta_3.Agencia + 
                              " e o número da conta é " + conta_3.Numero + ".");
            //Escreve informacoes da conta 3

        }
    }
}

