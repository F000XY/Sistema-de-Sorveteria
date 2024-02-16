using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    class Saudacao
    {
        public static void menu()
        {
            Console.WriteLine("Bem vindo a sorveteria, olhe o nosso menu logo abaixo: ");
        }

        public static void selecao()
        {
            List<string> picolesSelecionados = new List<string>();
            List<int> picolesCusto = new List<int>();
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Digite: ");
                Console.WriteLine("1- Para selecionar a compra do picolé de Chocolate.");
                Console.WriteLine("2- Para selecionar a compra do picolé de Morango.");
                Console.WriteLine("3- Para selecionar a compra do picolé de Limão.");
                Console.WriteLine("4- Para selecionar a compra do sorvete de Casquinha.");
                Console.WriteLine("5- Para ver os picolés selecionados anteriormente e o valor da compra.");
                Console.WriteLine("6- Para escolher a forma de pagamento e finalizar a compra.");
                Console.WriteLine("Insira o número: ");
                Console.WriteLine("");

                string input = Console.ReadLine();

                // Convertendo a entrada em um número inteiro
                if (!int.TryParse(input, out int numero))
                {
                    Console.WriteLine("Entrada inválida, por favor digite um número válido.");
                    continue; // Volta ao início do loop para pedir uma nova entrada
                }
                Console.WriteLine("");


                switch (numero)
                {
                    case 1:
                        picolesSelecionados.Add("Picolé de Chocolate");
                        picolesCusto.Add(7);
                        Console.WriteLine("Você selecionou a compra do picolé de Chocolate.");
                        break;
                    case 2:
                        picolesSelecionados.Add("Picolé de Morango");
                        picolesCusto.Add(5);
                        Console.WriteLine("Você selecionou a compra do picolé de Morango.");
                        break;
                    case 3:
                        picolesSelecionados.Add("Picolé de Limão");
                        picolesCusto.Add(5);
                        Console.WriteLine("Você selecionou a compra do picolé de Limão.");
                        break;
                    case 4:
                        picolesSelecionados.Add("Sorvete de Casquinha");
                        picolesCusto.Add(10);
                        Console.WriteLine("Você selecionou a compra do sorvete de Casquinha.");
                        break;
                    case 5:
                        Console.WriteLine("Picolés selecionados anteriormente e seus respectivos valores:");
                        foreach (var picole in picolesSelecionados)
                        {
                            Console.WriteLine(picole);
                        }
                        foreach (var custo in picolesCusto)
                        {
                            Console.WriteLine("Os respectivos valores são: " +custo+ " reais");
                        }
                        int soma = picolesCusto.Sum();
                        Console.WriteLine("O valor a ser pago é de: " + soma);
                        break;
                    case 6:
                        while (true)
                        {
                            Console.WriteLine("Digite a forma de pagamento: ");
                            Console.WriteLine("1 - Dinheiro ");
                            Console.WriteLine("2 - Pix ");
                            Console.WriteLine("3 - Debito");
                            Console.WriteLine("4 - Credito");
                            string inputPagamento = Console.ReadLine();
                            if (!int.TryParse(inputPagamento, out int numeroPagamento))
                            {
                                 Console.WriteLine("Entrada inválida, por favor digite um número válido.");
                                 continue; // Volta ao início do loop para pedir uma nova entrada
                            }
                            else if (numeroPagamento > 4 || numeroPagamento < 1)
                            {
                                Console.WriteLine("Entrada inválida, por favor digite um número válido.");
                                continue; // Volta ao início do loop para pedir uma nova entrada
                            }
                            Console.WriteLine("Compra finalizada, e metodo de pagamento ja selecionado vá até o caixa para prosseguir com o pagamento.");
                            return; // Sai do método e encerra o programa
                        }
                    default:
                        Console.WriteLine("Opção inválida, por favor escolha uma opção válida.");
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
            }
        }
    }
}