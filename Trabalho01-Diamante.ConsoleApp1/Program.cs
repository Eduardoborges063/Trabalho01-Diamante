namespace Trabalho01_Diamante.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                bool Impar = false;
                bool par = false;
                //chama o método introdução 
                Impar = Introducao(Impar);
                //chama o método diamante
                Diamante();
                //chama o método continuar
                continuar();

                Console.ReadLine();
            }
        }
        static bool Introducao(bool Impar)
        {
            //cabeçalho
            Console.WriteLine("-------------Bem vindo-------------");
            Console.WriteLine("************************************");
            Console.WriteLine(" - Vamos desenhar o seu diamante: :)(: ");
            Console.WriteLine("************************************");
            Console.WriteLine(" - Digite o tamanho do diamante: ");
            Console.WriteLine("------------------------------------");

            //par ou impar/tamanho
            decimal tamanho = Convert.ToDecimal(Console.ReadLine());
            if (tamanho % 2 == 0)
            {
                Console.WriteLine("--------------- O número é par,por favor escolha outro numero! --------------- ");
                return false;
            }
            else
            {
               Impar = true;
                Console.WriteLine("--------------- O número é impar, vamos continuar! --------------- ");
            }
            return Impar;
        }
        static void Diamante()
        {
            //desenha o diamante
            Console.WriteLine("    *");
            Console.WriteLine("   * *");
            Console.WriteLine("  * * *");
            Console.WriteLine(" * * * *");
            Console.WriteLine("  * * *");
            Console.WriteLine("   * *");
            Console.WriteLine("    * ");
            Console.WriteLine("------------------------------------");

        }
        static void continuar()
        {
            //opção de continuar
            Console.WriteLine("Deseja continuar? (S/N): ");
            string continuar = Console.ReadLine();
            if (continuar.ToUpper() != "S")
            {
                Environment.Exit(0);
            }
        }
    }
}
