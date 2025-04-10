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
                //opção de continuar
                Console.WriteLine("Deseja continuar? (S/N): ");
                
                Console.ReadLine();
            }
        }
        static bool Introducao(bool Impar)
        {
            //cabeçalho
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Vamos desenhar o seu diamante: ");
            Console.WriteLine("Digite o tamanho do diamante: ");

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

        }
    }
}
