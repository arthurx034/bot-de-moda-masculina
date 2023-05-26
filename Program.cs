using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Timers;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o produto de roupa masculino: ");
        string produto = Console.ReadLine();
        
        if (produto == "calça" || produto == "calças")
        {
            Console.WriteLine("Digite o estilo de calça: ");
            string estilo = Console.ReadLine();

            if (estilo == "calça cargo" || estilo == "cargo")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(120.00f);
                Console.WriteLine();
            }
            else if (estilo == "calça jeans" || estilo == "jeans")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(135.50f);
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Estilo de calça fora de estoque.");
                Console.WriteLine();
            }
        }
        else if (produto == "bermuda" || produto == "bermudas")
        {
            Console.WriteLine("Digite o estilo de bermuda: ");
            string estilo = Console.ReadLine();

            if (estilo == "bermuda cargo" || estilo == "cargo")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(70.50f);
                Console.WriteLine();
            }
            else if (estilo == "calça jeans" || estilo == "jeans")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(80.50f);
                Console.WriteLine();
            }
            else if (estilo == "bermuda de praia" || estilo == "praia")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(55.00f);
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Estilo de bermuda fora de estoque.");
                Console.WriteLine();
            }
        }
        else if (produto == "camiseta" || produto == "camisetas")
        {
            Console.WriteLine("Digite o estilo de camiseta: ");
            string estilo = Console.ReadLine();

            if (estilo == "streetwear" || estilo == "estilo de rua")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(80.50f);
                Console.WriteLine();
            }
            else if (estilo == "camiseta de praia" || estilo == "praia")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(50.50f);
                Console.WriteLine();
            }
            else if (estilo == "regata" || estilo == "regatas")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(55.50f);
                Console.WriteLine();
            }
            else if (estilo == "big size" || estilo == "big")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(90.50f);
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Estilo de camiseta fora de estoque.");
                Console.WriteLine();
            }
        }
        else if (produto == "moletom" || produto == "moletons")
        {
            Console.WriteLine("Digite o estilo de moletom: ");
            string estilo = Console.ReadLine();

            if (estilo == "streetwear" || estilo == "estilo de rua")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(150.50f);
                Console.WriteLine();
            }
            else if (estilo == "big size" || estilo == "big")
            {
                Console.WriteLine();
                Console.Write("O preço do produto selecionado é R$");
                preco(200.50f);
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Estilo de moletom fora de estoque.");
                Console.WriteLine();
            }
        }
        else if (produto == "cueca" || produto == "cuecas")
        {
            Console.WriteLine();
            Console.Write("O conjunto do produto selecionado está saindo por R$");
            preco(40.50f);
            Console.WriteLine();
        }
        else if (produto == "meias" || produto == "meia")
        {
            Console.WriteLine();
            Console.Write("O conjunto do produto selecionado está saindo por R$");
            preco(20.50f);
            Console.WriteLine();
        }
        else if (produto == "tenis" || produto == "tennis")
        {
            Console.WriteLine("Digite uma marca de tenis: ");
            string estilo = Console.ReadLine();

            if (estilo == "air nike" || estilo == "nike")
            {
                Console.WriteLine("Digite o modelo do tenis nike: ");
                string tenis = Console.ReadLine();

                if (tenis == "air jordan" || tenis == "jordan")
                {
                    Console.WriteLine();
                    Console.WriteLine("O preco do produto digitado é R$");
                    preco(900.50f);
                    Console.WriteLine();
                }
                else if (tenis == "air force")
                {
                    Console.WriteLine();
                    Console.WriteLine("O preco do produto digitado é R$");
                    preco(600.50f);
                    Console.WriteLine();
                }
                else if (tenis == "air max")
                {
                    Console.WriteLine();
                    Console.WriteLine("O preco do produto digitado é R$");
                    preco(400.00f);
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Modelo de tenis nike fora de estoque.");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Marca de tenis fora de estoque, trabalhamos somente com tenis Nike.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Produto fora de estoque.");
            Console.WriteLine();
        }
        Console.ResetColor();
        Console.ReadLine();
    }

    static void preco(float preco)
    {
        Console.WriteLine(preco);
    }
}