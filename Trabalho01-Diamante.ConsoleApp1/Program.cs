namespace Trabalho01_Diamante.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Introducao();

            Diamante();
            
 
            Console.ReadLine();
        }
        static void Introducao()
        {
            //cabeçalho
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Vamos desenhar o seu diamante: ");
            Console.WriteLine("Digite o tamanho do diamante: ");

            //tamanho
            int tamanho = Convert.ToInt32(Console.ReadLine());

            //par ou impar
            decimal D = Convert.ToDecimal(Console.ReadLine());
            if (D % 2 == 0)
            {
                Console.WriteLine("ele é par");
            }
            else
            {
                Console.WriteLine("ele é impar");
            }
        }
        static void Diamante()
        {
        
        }
    }
}
