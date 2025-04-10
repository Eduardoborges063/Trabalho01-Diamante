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
                int linhas = Introducao();
                //chama o método diamante
                Diamante(linhas);
                //chama o método continuar
                continuar();

                Console.ReadLine();
            }
        }
        static int Introducao()
        {
            //cabeçalho
            Console.WriteLine("-------------Bem-vindo-------------");
            Console.WriteLine("************************************");
            Console.WriteLine(" - Vamos desenhar o seu diamante :) ");
            Console.WriteLine("************************************");
            Console.WriteLine(" - Digite o tamanho do diamante (Deve ser ímpar): ");
            Console.WriteLine("------------------------------------");

            int tamanho = 0;
            //par ou impar/tamanho
            while (true)
            {
                bool sucesso = int.TryParse(Console.ReadLine(), out tamanho);
                if (sucesso && tamanho % 2 != 0 && tamanho > 0)
                {
                    Console.WriteLine("--------------- O número é ímpar, vamos continuar! --------------- ");
                    break;
                }
                else
                {
                    Console.WriteLine("--------------- O número é inválido. Por favor, insira um número ímpar maior que zero! --------------- ");
                }
            }
            return tamanho;
        }
        static void Diamante(int linhas)
        {
            int meio = linhas / 2;

            // Parte superior
            for (int i = 0; i <= meio; i++)
            {
                Console.Write(new string(' ', meio - i));
                Console.WriteLine(new string('x', 2 * i + 1));
            }
            // Parte inferior
            for (int i = meio - 1; i >= 0; i--)
            {
                Console.Write(new string(' ', meio - i));
                Console.WriteLine(new string('x', 2 * i + 1));
            }
        }
        static void continuar()
        {
          
            Console.WriteLine("Deseja continuar? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                Console.Clear();   
                Console.WriteLine("Você escolheu continuar!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Você escolheu sair. Até a próxima!");
                Environment.Exit(0);
            }
        } 
    }
}
