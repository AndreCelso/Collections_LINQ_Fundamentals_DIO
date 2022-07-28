// See https://aka.ms/new-console-template for more information
/*int[] IntegerArray = new int[11];
//int i = 0;
while (int i = 0; i < IntegerArray.Length)
Console.WriteLine("Hello, World!");
*/
int ArrayLength;
Console.WriteLine("Olá, Bem Vindo ao Projeto Array de Tamanho variável \n");

Console.WriteLine("Por favor, informe quantas entradas deseja inserir no Array \n");
ArrayLength = int.Parse(Console.ReadLine());

int[] IntegerArray = new int[ArrayLength];

for (int i = 0; i < ArrayLength; i++)
{
    Console.WriteLine("Agora, Por Favor digite o número inteiro que deseja inserir no Array\n");
    IntegerArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("-----------------------------");
Console.WriteLine("Imprimindo o Array de Inteiros");
Console.WriteLine("O Tamanho do Array é - {0} Posições", IntegerArray.Length.ToString());

for (int i = 0; i < ArrayLength; i++)
{
    Console.WriteLine("[{0}]", IntegerArray[i]);
}

Console.WriteLine("-----------------------------");

Console.WriteLine("Criando Array de Tamanho Variável, Auto Preenchido com Números Pares Negativos até o Range máximo especificado pelo usuário");

Console.WriteLine("Digite o tamanho do Novo Array");
int ArrayLength2 = int.Parse(Console.ReadLine());

int[] NegativeEvenArray = new int[ArrayLength2];

for (int i = 0; i < ArrayLength2; i++)
{
    int functionEven = i * -2;
    NegativeEvenArray[i] = functionEven;
}

Console.WriteLine("Imprimindo Array de Números Pares Negativos\n");

foreach (int num in NegativeEvenArray)
{
    Console.WriteLine("[{0}]", num);
}

Console.WriteLine("Criando Array de Tamanho Variável, Auto Preenchido com Números Ímpares Negativos até o Range máximo especificado pelo usuário");

Console.WriteLine("Digite o tamanho do Novo Array");
int ArrayLength3 = int.Parse(Console.ReadLine());

int[] NegativeOddArray = new int[ArrayLength3];

for (int i = 0; i < ArrayLength3; i++)
{
    int functionOdd = ((i + 1) * -2) + 1;
    NegativeOddArray[i] = functionOdd;
}

Console.WriteLine("Imprimindo Array de Números Ímpares Negativos \n");

foreach (int num in NegativeOddArray)
{
    Console.WriteLine("[{0}]", num);
}

Console.WriteLine("--------------------------------------- \n");
Console.WriteLine("Criando um Array Multidimensional (Matriz)");

int[,] Matriz5x5 = new int[5, 5]
{
    {5, 10, 15, 20, 25},
    {30, 35, 40, 45 ,50},
    {65, 60, 75, 80, 85},
    {90, 95, 100, 105, 110},
    {115, 120, 125, 130, 135}
};

for (int i = 0; i < Matriz5x5.GetLength(0); i++)
{
    for (int j = 0; j < Matriz5x5.GetLength(1); j++)
    {
        Console.WriteLine(Matriz5x5[i, j]);
    }
}
