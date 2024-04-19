// Faça um programa que receba a idade de 10 pessoas e mostre a quantidade de maiores e menores de idade

int idades = 0, maior = 0, menor = 0;
int option;

do
{
    Console.WriteLine("Digite a idade de 10 pessoas:\n");

    for (int i = 1; i <= 10; i++)
    {
        do
        {
            Console.WriteLine($"Pessoa {i}:");
            idades = int.Parse(Console.ReadLine());
            if (idades < 0)
            {
                Console.WriteLine("\nIdade não pode ser negativa\n");
            }
        } while (idades < 0);

        if (idades < 18)
        {
            menor++;
        }
        else
        {
            maior++;
        }

    }

    Console.WriteLine($"\nMenores de idade: {menor}");
    Console.WriteLine($"\nMaiores de idade: {maior}");

    menor = 0;
    maior = 0;

    do
    {
        Console.WriteLine("\nDeseja sair?");
        Console.WriteLine("1 - sim");
        Console.WriteLine("2 - não");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);