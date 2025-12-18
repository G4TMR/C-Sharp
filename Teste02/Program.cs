using System;

class Principal
{
    static void Main()
    {
        double nota1, nota2, nota3, media;
        Console.WriteLine("Digite a primeira nota:");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota:");
        nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota:");
        nota3 = Convert.ToDouble(Console.ReadLine());
        media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine ("A média é: " + media.ToString("F2"));
        if (media >= 6.0)
        { Console.WriteLine("Aprovado");}
        else
        { Console.WriteLine("Reprovado");}

    }
}
