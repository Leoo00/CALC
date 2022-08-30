using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace First_Project
{
    class Program
    {
       
        enum Menu {Soma = 1,Subtracao , Divisao , Multiplicacao , Potencia , Raiz , Sair}

        static void Main(string[] args)
        {
            bool escolheusair = false;

            while(!escolheusair)//Enquanto o úsuario não escolher sair EXIBA o menu
            {
                Console.WriteLine("Bem vindo ao Calc,selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Multi();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheusair=true;
                        break;
                }
               

                Console.Clear();
            }

            
            
        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros:");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
       
        static void Sub()
        {
            Console.WriteLine("Subtração de dois numeros:");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Div()
        {
            Console.WriteLine("Divisão de dois numeros:");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b;
            Console.WriteLine($"O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Multi()
        {
            Console.WriteLine("Multiplicação de dois numeros:");
            Console.WriteLine("Digite o primeiro numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Pot()
        {
            Console.WriteLine("Potência de um numero ");
            Console.WriteLine("Digite a base:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz Quadrada de um numero:");
            Console.WriteLine("Digite o numero:");
            int a = int.Parse(Console.ReadLine());
            Double resultado = (int)Math.Sqrt(a);
            Console.WriteLine($"O resultado é : {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}

  