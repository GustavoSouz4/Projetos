using System;
namespace Calculadora
{
    class programa
    {
        static void Main(string[] args)
        {
            string name;
            string x = "não";
            int choose;
            double num1, num2, sum, subt, div;
            while (x == "não" || x == "Não")
            {
                Console.WriteLine("ola Como voce esta? \nPoderia dizer seu nome?");
                name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Então seu nome é " + name);
                Console.WriteLine("Posso confirmar?\nDigite sim ou não");
                x = Console.ReadLine();

                x = "2";
                while (x == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Como este e o meu primeiro projeto, tende a ser simples, a ideia do projeto e aprender a utilizar operadores aritimeticos e estruturas de repetição para resolução de problemas matematicos.");
                    Console.WriteLine("Para iniciar a preciso que selecione alguma das opções abaixo:\n1-Soma\n2-subtração\n3-divisão\n \n");
                    choose = int.Parse(Console.ReadLine());
                    Console.Clear();

                    x = "1";
                    while (x == "1")
                        switch (choose)
                        {
                            case 1:
                                Console.WriteLine("Opção selecionada é Soma");
                                Console.WriteLine("Digite o primeiro numero");
                                num1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o segundo numero");
                                num2 = double.Parse(Console.ReadLine());
                                sum = num1 + num2;
                                Console.WriteLine("A soma de" + num1 + " + " + num2 + " é " + sum);
                                Console.WriteLine("Deseja fazer uma nova conta (1), ou voltar ao menu?(2)");
                                x = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Opção selecionada é Soma");
                                Console.WriteLine("Digite o primeiro numero");
                                num1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o segundo numero");
                                num2 = double.Parse(Console.ReadLine());
                                subt = num1 - num2;
                                Console.WriteLine("A Subtração de " + num1 + " - " + num2 + "é" + subt);
                                Console.WriteLine("Deseja fazer uma nova conta (1), ou voltar ao menu?(2)");
                                x = Console.ReadLine();
                                break;
                        }
                }
            }
        }

    }
}