using System.Runtime.InteropServices.Marshalling;

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

            bool NaoSair = true;
            string Escolha;
            string MeuTexto = "Escolha uma das opções:";
            string NovoNome;
            string ExcluirNome;
            string NomeExistente;
            string NomePesquisa;
            bool NomeExiste = false;
            string NomeEncontrado = "ND";

            List<string> ListaDeNomes = new List<string>();


            ListaDeNomes.Add("Mirella");
            ListaDeNomes.Add("Lucas");
            ListaDeNomes.Add("Napoleão");
            ListaDeNomes.Add("Madalena");
            ListaDeNomes.Add("Rokson");
            ListaDeNomes.Add("Stark");
            ListaDeNomes.Add("Pepper");
            ListaDeNomes.Add("Pepita");

            do
            {
                Console.WriteLine(MeuTexto);
                Console.WriteLine("1 - Cadastre um nome.");
                Console.WriteLine("2 - Altere um nome.");
                Console.WriteLine("3 - Delete um nome.");
                Console.WriteLine("4 - Pesquise um nome.");
                Console.WriteLine("5 - Consulte todos os nomes.");
                Console.WriteLine("6 - Sair.");
                Console.WriteLine("7 - Liste os 5 primeiros nomes.");
                Console.WriteLine("Sua escolha:");
                Escolha = Console.ReadLine();

                switch (Escolha)
                {

                    case "1":
                        {

                            Console.WriteLine("Você escolheu a opção: " + Escolha + " - Cadastre um nome.");
                            Console.WriteLine("Escreva o novo nome:");

                            NovoNome = Console.ReadLine();
                            ListaDeNomes.Add(NovoNome);


                            break;

                        }

                    case "2":

                        Console.WriteLine("Você escolheu a opção: " + Escolha + " - Altere um nome.");

                        Console.WriteLine("Qual nome você quer Editar?");
                        NomeExistente = Console.ReadLine();

                        ListaDeNomes.Remove(NomeExistente);

                        Console.WriteLine("Qual o novo nome?");
                        NovoNome = Console.ReadLine();
                        ListaDeNomes.Add(NovoNome);


                        break;

                    case "3":

                        Console.WriteLine("Você escolheu a opção: " + Escolha + " - Delete um nome.");

                        Console.WriteLine("Escreva o nome para excluir.");

                        ExcluirNome = Console.ReadLine();
                        ListaDeNomes.Remove(ExcluirNome);


                        break;

                    case "4":

                        Console.WriteLine("Você escolheu a opção: " + Escolha + " - Pesquise um nome.");
                        Console.WriteLine("Escreva o nome.");
                        NomePesquisa = Console.ReadLine();

                        foreach (var Nome in ListaDeNomes)
                        {

                            if (NomePesquisa == Nome)
                            {
                                NomeExiste = true;
                                NomeEncontrado = Nome;


                            }



                        }

                        if (NomeExiste)
                        {
                            NomeExiste = false;
                            Console.WriteLine("Nome encontrado: " + NomeEncontrado);
                            NomeEncontrado = "ND";
                        }

                        else
                        {
                            Console.WriteLine("Nome NÃO encontrado. ");
                        }

                        break;

                    case "5":

                        Console.WriteLine("Você escolheu a opção: " + Escolha + " - Consulte todos os nomes.");

                        foreach (var Nome in ListaDeNomes)
                        {

                            Console.WriteLine(Nome);

                        }

                        break;


                    case "7":

                        for (int i = 0; i < 5; i++)
                        {

                            Console.WriteLine(ListaDeNomes[i]);

                        }

                        break;

                    case "6":

                        NaoSair = false;

                        break;

                }
                Console.ReadKey();
                Console.Clear();
            } while (NaoSair);
        }
    }
}


