using System;

namespace Atividade01
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularDescontoINSS();
            DetalharData();

        }

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Ola, {nome}! Digite o seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario <= 1212)
            {
                double reajuste = 7.5 * salario / 100;
                double newSalario = salario - reajuste;
                double salarioAnualDesc = newSalario * 12;
                Console.WriteLine(" ");
                Console.WriteLine($"{nome}, sua contribuição é de 7,5%, ou R${reajuste:c2} reais");
                Console.WriteLine($"Seu salário com o desconto do INSS é R${newSalario:c2}");
                Console.WriteLine($"Seu salário anual com os descontos é R${salarioAnualDesc:c2}");
                Console.WriteLine(" ");
                Console.ReadKey();

            }
            else
            {
                if (salario >= 1212.01 && salario <= 2427.35)
                {
                    double reajuste = 9 * salario / 100;
                    double newSalario = salario - reajuste;
                    double salarioAnualDesc = newSalario * 12;
                    Console.WriteLine(" ");
                    Console.WriteLine($"{nome}, sua contribuição é de 9%, ou RS{reajuste:c2} reais");
                    Console.WriteLine($"Seu salário com o desconto do INSS é R${newSalario:c2}");
                    Console.WriteLine($"Seu salário anual com os descontos é R${salarioAnualDesc:c2}");
                    Console.WriteLine(" ");
                    Console.ReadKey();
                }
                else
                {
                    if (salario >= 2427.36 && salario <= 3641.03)
                    {
                        double reajuste = 12 * salario / 100;
                        double newSalario = salario - reajuste;
                        double salarioAnualDesc = newSalario * 12;
                        Console.WriteLine(" ");
                        Console.WriteLine($"{nome}, sua contribuição é de 12%, ou RS{reajuste:c2} reais");
                        Console.WriteLine($"Seu salário com o desconto do INSS é R${newSalario:c2}");
                        Console.WriteLine($"Seu salário anual com os descontos é R${salarioAnualDesc:c2}");
                        Console.WriteLine(" ");
                        Console.ReadKey();
                    }
                    else
                    {
                        double reajuste = 14 * salario / 100;
                        double newSalario = salario - reajuste;
                        double salarioAnualDesc = newSalario * 12;
                        Console.WriteLine(" ");
                        Console.WriteLine($"{nome}, sua contribuição é de 14%, ou RS{reajuste:c2} reais");
                        Console.WriteLine($"Seu salário com o desconto do INSS é R${newSalario:c2}");
                        Console.WriteLine($"Seu salário anual com os descontos é R${salarioAnualDesc:c2}");
                        Console.WriteLine(" ");
                        Console.ReadKey();

                    }
                }
            }
        }
        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                string frase = string.Format("Hoje é {0:dddd}, dia {0:dd} de {0:MMMM},  do ano de {0:yyyy} e são exatamente {1:HH:mm:ss}", data, DateTime.Now);
                Console.WriteLine(frase.ToUpper());
            }
            else
            {
                string frase = string.Format("Hoje é {0:dddd}, dia {0:dd} de {0:MMMM}, do ano de {0:yyyy}", data);
                Console.WriteLine(frase.ToUpper());
            }
        }

        
    }
}