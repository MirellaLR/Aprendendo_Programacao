namespace AprendendoProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //char Item = 'a';
            //string Nome = "Mirella";
            //int DiaDaIndependenciaDoBrasil = 7; // INTEIRO DO - AO +
            //long CPF = - 65458657878;  // INTEIRO DO - AO + 
            //float Preco = 1.50;
            //double Peso = 92.200;
            //decimal Altura = 1.63;
            //bool Escolha = true;

            bool SAIR = true;
            string Escolha;
            string MeuTexto = "Escolha uma das opções:";
            do
            {
                Console.WriteLine(MeuTexto);
                Console.WriteLine("1 - Cadastre um nome.");
                Console.WriteLine("2 - Altere um nome.");
                Console.WriteLine("3 - Delete um nome.");
                Console.WriteLine("4 - Pesquise um nome.");
                Console.WriteLine("5 - Consulte todos os nomes.");
                Console.WriteLine("6 - Sair.");
                Console.WriteLine("Sua escolha:");
                Escolha = Console.ReadLine();

                switch (Escolha)
                {

                    case "1":

                        Console.WriteLine("Você escolheu a opção: " + Escolha + " - Cadastre um nome.");

                        break;

                    case "2":

                        Console.WriteLine("Você escolheu a opção: " + Escolha + " - Altere um nome.");

                        break;

                    case "3":

                        Console.WriteLine("Você escolheu a opção: " + Escolha + " - Delete um nome.");

                        break;

                    case "4":

                        Console.WriteLine("Você escolheu a opção: " + Escolha + " - Pesquise um nome.");

                        break;

                    case "5":

                        Console.WriteLine("Você escolheu a opção: " + Escolha + " - Consulte todos os nomes.");

                        break;

                    case "6":

                        SAIR = false;

                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }while (SAIR);
        }
    }
}


