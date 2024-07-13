using System;

class Program
{
    static void Main()
    {
        double nota;

        do
        {
            Console.Write("Digite uma nota entre zero e dez: ");
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota invalida. Por favor, digite novamente. ");
            }

        } while (nota < 0 || nota > 10);

        Console.WriteLine("Nota válida!");
    }
}