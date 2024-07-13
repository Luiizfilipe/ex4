using System;

class Program
{
    static void Main()
    {
        string nome, sexo, estadoCivil;
        int idade;
        double salario;

        do
        {
            Console.Write("Digite o nome (mais de 3 caracteres): ");
            nome = Console.ReadLine();

            if (nome.Length <= 3)
            {
                Console.WriteLine("Erro: o nome deve ter mais de 3 caracteres.");
            }

        } while (nome.Length <= 3);

        do
        {
            Console.Write("Digite a idade (entre 0 e 150): ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 0 || idade > 150)
            {
                Console.WriteLine("Erro: a idade deve ser entre 0 e 150.");
            }

        } while (idade < 0 || idade > 150);

        do
        {
            Console.Write("Digite o salário (maior que zero): ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario <= 0)
            {
                Console.WriteLine("Erro: o salário deve ser maior que zero.");
            }

        } while (salario <= 0);

        do
        {
            Console.Write("Digite o sexo ('f' para feminino, 'm' para masculino): ");
            sexo = Console.ReadLine().ToLower();

            if (sexo != "f" && sexo != "m")
            {
                Console.WriteLine("Erro: o sexo deve ser 'f' ou 'm'.");
            }

        } while (sexo != "f" && sexo != "m");

        do
        {
            Console.Write("Digite o estado civil ('s' para solteiro, 'c' para casado, 'v' para viúvo, 'd' para divorciado): ");
            estadoCivil = Console.ReadLine().ToLower();

            if (estadoCivil != "s" && estadoCivil != "c" && estadoCivil != "v" && estadoCivil != "d")
            {
                Console.WriteLine("Erro: o estado civil deve ser 's', 'c', 'v' ou 'd'.");
            }

        } while (estadoCivil != "s" && estadoCivil != "c" && estadoCivil != "v" && estadoCivil != "d");

        Console.WriteLine("Informações válidas:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Salário: {salario}");
        Console.WriteLine($"Sexo: {sexo}");
        Console.WriteLine($"Estado Civil: {estadoCivil}");
    }
}
