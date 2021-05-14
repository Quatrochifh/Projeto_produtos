using System;

namespace Aula_semana_10
{
    class Program
    { static int quantidademax = 10;
        static int i = 0;
        static int a = 0;
        static string[] nomeProduto = new string[quantidademax];
        static float[] preco = new float[quantidademax];
        static bool[] promocao = new bool[quantidademax];
        static bool inicio = true;
        static void Main(string[] args)
        {
            do
            {
                string partemenu = menu();
                switch (partemenu)
                {
                    
                    case "1":
                        cadastro();
                        break;
                   
                    case "2":
                        listar();
                        break;
                    
                    case "3":
                        inicio = false;
                        Console.WriteLine("obrigado por contar com o mercado _______ ");
                        break;
                    default:
                        Console.WriteLine("Eita? por favor insira uma opção valida:)");
                        break;
                }

            } while (inicio == true);
        }
        static string menu()
        {
            //Isso vai la pra cima, na parte do switch case
            Console.WriteLine(@"
            ____________________________________________
            |                     MENU                 |
            |             1 - cadastrar produtos       |
            |                2 - listar produtos       |
            |                   3 - Sair               |
            |__________________________________________|                   ");

            string resposta = Console.ReadLine().ToLower().Substring(0, 1);
            return resposta;
        }
        static void cadastro()
        {

            //Isso vai la pra cima, na parte do switch case
            for (i = 0; i <= quantidademax;)
            {
                Console.WriteLine($"você ainda pode fazer só mais {quantidademax + a} cadastros.");
                Console.WriteLine("O Nome do produto é:");
                nomeProduto[i] = Console.ReadLine();
                Console.WriteLine("O preço do produto é:");
                preco[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Este produto está em promoção?(s/n)");
                string promocaoSIMouNAO = Console.ReadLine().ToLower().Substring(0, 1);

                if (promocaoSIMouNAO == "s")
                {
                    promocao[i] = true;
                }
                else
                {
                    //se marcar n
                    promocao[i] = false;
                }

                Console.WriteLine("Deseja cadastrar mais um?(sim/não");
                string resposta2 = Console.ReadLine().ToLower().Substring(0, 1);

                if (resposta2 == "n")
                {
                    break;
                }
                else
                {
                    i++;
                    a--;
                }
            }
        }
        static void listar()
        {
            //Isso vai la pra cima, na parte do switch case
            for (int c = 0; c <= i; c++)
            {
                Console.WriteLine($@"
                 ______________________________________________________________________
                |                                                                      |
                |Nome: {nomeProduto[c]} | Preço: {preco[c]} | Promoção: {promocao[c]}  |
                |______________________________________________________________________|") ;
            }
        }
    }
}
