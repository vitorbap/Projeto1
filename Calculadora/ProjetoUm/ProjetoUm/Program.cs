using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7}

        static void Main(string[] args)
        {


            bool escolheuSair = false;

            while (!escolheuSair) //Enquanto o user NÃO (!) escolher sair exiba o MENU
            {
                Console.WriteLine("Seja bem vindo ao CALC, seleciona uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair"); /*Perguntar para o user a opção que ele deseja escolher */

                /* string opcaoTXT = Console.ReadLine();
                int opcaoInt = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoInt;*/

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                
                Console.Clear();
            }

        }

        static void Soma() //Função
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}"); //Interpolação de cadeia de caracteres == "frase" + variável
            Console.WriteLine("Aperte  ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Subtracao() //Função
        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}"); //Interpolação de cadeia de caracteres == "frase" + variável
            Console.WriteLine("Aperte  ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Divisao() //Função
        {
            Console.WriteLine("Divisao de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b; //Conversões explicitas (casts) conversao de int(inteiro) para float(decimal)
            Console.WriteLine($"O resultado é: {resultado}"); //Interpolação de cadeia de caracteres é a mesma coisa que ("frase" + variável)
            Console.WriteLine("Aperte  ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Multiplicacao() //Função
        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}"); //Interpolação de cadeia de caracteres é a mesma coisa que ("frase" + variável)
            Console.WriteLine("Aperte  ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Potencia() //Função
        {
            Console.WriteLine("Potenciação de dois numeros: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é: {resultado}"); //Interpolação de cadeia de caracteres é a mesma coisa que ("frase" + variável)
            Console.WriteLine("Aperte  ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Raiz() //Função
        {
            Console.WriteLine("Raiz de um numeros: ");
            Console.WriteLine("Digite o numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a); //Square root = Raiz quadrada
            Console.WriteLine($"O resultado é: {resultado}"); //Interpolação de cadeia de caracteres é a mesma coisa que ("frase" + variável)
            Console.WriteLine("Aperte  ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}
