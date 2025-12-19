using System;

class Program
{
    static void Main()
    {
        //Caixas de texto para entrada de dados
        double numeroAtual = 0;
        double maior = 0;
        double menor = 0;
        double media = 0;
        double soma = 0;
        //Solicitar ao usuário que digite 5 números
        Console.WriteLine("Digite 5 números:");
        for (int i = 1; i <= 5; i++)
        {
            //Ler o número digitado
            Console.Write($"Digite o {i} numero: ");
            //Converter o número lido para double
            numeroAtual = Convert.ToDouble(Console.ReadLine());
            //Acumular a soma dos números
            soma += numeroAtual;

            if (i == 1)
            {
                maior = numeroAtual;
                menor = numeroAtual;
            }
            else if (numeroAtual > maior)
            {
                maior = numeroAtual;
            }
            else if (numeroAtual < menor)
            {
                menor = numeroAtual;
            }
        }
        //Calcular a média dos números
            media = soma / 5;
        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
        Console.WriteLine($"A média dos números é: {media}");
        }
    } 
