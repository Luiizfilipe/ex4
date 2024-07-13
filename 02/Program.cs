using System;

class Program
{
    static void Main()
    {
        string usuario, senha;

    
        {
            Console.Write("Digite o nome de usuário: ");
            usuario = Console.ReadLine();

            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();

            if (senha == usuario)
            {
                Console.WriteLine("Erro: a senha não pode ser igual ao nome de usuário! ");
            }

        } while (senha == usuario);

        Console.WriteLine("Usuário e senha validos!");
    }
}
