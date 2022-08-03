// See https://aka.ms/new-console-template for more information
/*int[] IntegerArray = new int[11];
//int i = 0;
while (int i = 0; i < IntegerArray.Length)
Console.WriteLine("Hello, World!");
*/

using Collection_LINQ_Fundamentals_DIO.Helper;

OperacoesArray Operacao = new OperacoesArray();
OperacoesLista OperacaoLista = new OperacoesLista();
OperacoesLINQ OperacaoLINQ = new OperacoesLINQ();

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

int[] ArrayNum = new int[7] { 49, 7, 40, 4, 12, 16, 23};

Console.WriteLine("Imprimindo o Array Original Desordenado: \n");
Console.WriteLine("------------------------------------ \n");

 Operacao.ImprimirArray(ArrayNum);

Console.WriteLine("Ordenando Array: \n");
Console.WriteLine("------------------------------------ \n");

Operacao.DoBubbleSort(ref ArrayNum);

Operacao.Ordernar(ref ArrayNum);

Console.WriteLine("Imprimindo o Array Ordenado: \n");
Console.WriteLine("------------------------------------ \n");

Operacao.ImprimirArray(ArrayNum);

Console.WriteLine("Copiando um Array: \n");
Console.WriteLine("------------------------------------ \n");

int[] CopyArray = new int[10];

Console.WriteLine("Array Before the Copy Process: \n");
Console.WriteLine("------------------------------------ \n");
Operacao.ImprimirArray(CopyArray);

Operacao.ToCopyArray(ref ArrayNum, ref CopyArray);

Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Array After the Copy Process: \n");
Operacao.ImprimirArray(CopyArray);

Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Verifying Existence of value in an Array: \n");


Console.WriteLine("Please enter the value to be searched for in the Array: \n");
int ValueToSearch = int.Parse(Console.ReadLine());
bool Exists = Operacao.DoesItExist(ArrayNum, ValueToSearch);

if (Exists)
{
    Console.WriteLine("Value [{0}] Exist", ValueToSearch);
}
else 
{
    Console.WriteLine("Value [{0}] Does Not Exist", ValueToSearch);
}

Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Verifying all values in an Array for a specific condition: \n");

Console.WriteLine("Please enter the conditional value to be searched in the Array: \n");
int ValueToSearch2 = int.Parse(Console.ReadLine());
bool AllGreaterThan = Operacao.AllGreaterThan(ArrayNum, ValueToSearch2);

if (AllGreaterThan)
{
    Console.WriteLine("All Values are GREATER than [{0}]", ValueToSearch2);
}
else
{
    Console.WriteLine("There is values that are NOT GREATER than [{0}]", ValueToSearch2);
}

Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Searching for Value in array that matches with user specified value: \n");
int ValueToSearch3 = int.Parse(Console.ReadLine());
int ValueFound = Operacao.GetValue(ArrayNum, ValueToSearch3);

if (ValueFound > 0)
{
    Console.WriteLine("Value [{0}] Found", ValueToSearch3);
}
else
{
    Console.WriteLine("Value [{0}] Not Found", ValueToSearch3);
}

Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Searching for Index of a value in the array that matches with user specified value: \n");
int ValueToSearch4 = int.Parse(Console.ReadLine());
int Index = Operacao.GetIndexOf(ArrayNum, ValueToSearch4);
if (Index > -1)
{
    Console.WriteLine($"Index of Value [{ValueToSearch4}] is [{Index}]");
}
else
{
    Console.WriteLine("Value Not Found in the Array");
}

Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Searching for Index of a value in the array that matches with specific condition (Predicate): \n");
int ValueToSearch5 = int.Parse(Console.ReadLine());
int Index2 = Operacao.GetIndex(ArrayNum, ValueToSearch5);
if (Index2 > -1)
{
    Console.WriteLine($"Index of first Value smaller than [{ValueToSearch5}] is [{Index2}]");
}
else
{
    Console.WriteLine("Value Not Found in the Array");
}



string[] StringArray = Operacao.ConvertIntoStringArray(ArrayNum);

Console.WriteLine($"A Capacidade Atual do meu array é : [{ArrayNum.Length}]");

Operacao.ResizeArray(ref ArrayNum, ArrayNum.Length * 3);

Console.WriteLine($"A Capacidade Atual do meu array após redimensionamento é : [{ArrayNum.Length}]");

Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Exploring Lists from C# Collections Generic \n");

List<string> BrazilStates = new List<string>();
string[] States = new string[2] { "MT", "CE" };

BrazilStates.Add("MG");
BrazilStates.Add("SC");
BrazilStates.Add("SP");
BrazilStates.Add("BA");


Console.WriteLine($"Number of Entries on Brazil States List -> [{BrazilStates.Count}]");

foreach (var item in BrazilStates)
{
    Console.WriteLine($"[{item}]");
}


// /*
Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Imprimindo a Lista de Estados Brasileiros");

OperacaoLista.PrintStringList(BrazilStates);
Console.WriteLine("------------------------------------ \n");

Console.WriteLine("Removendo o Estado da Bahia da Lista");
BrazilStates.Remove("BA");

Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Adding the values from State Array to Brazil States List");

BrazilStates.AddRange(States);
BrazilStates.Insert(2, "RJ");

Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Imprimindo a Lista de Estados Brasileiros Atualizada");

OperacaoLista.PrintStringList(BrazilStates);
Console.WriteLine("------------------------------------ \n");



Console.WriteLine("------------------------------------ \n");
Console.WriteLine("Doing some Queue & Stack Shenanigans \n");

Queue<string> MyQueue = new Queue<string>();

MyQueue.Enqueue("André Celso");
MyQueue.Enqueue("Fernanda Dias Lima");
MyQueue.Enqueue("João Roberto");
MyQueue.Enqueue("Felipe Martins");
MyQueue.Enqueue("Marta Rocha");

Console.WriteLine($"People in the current Queue: [{MyQueue.Count()}]\n ");

while (MyQueue.Count() > 0)
{
    Console.WriteLine("----------------------------------------------------------------------------- \n");
    Console.WriteLine($"Calling Mr.(s) [{MyQueue.Peek()}] to come to the counter to be attended \n");
    string LastPerson = MyQueue.Peek();
    Console.WriteLine($"Currently Attending Mr.(s) [{MyQueue.Dequeue()}] \n");
    Console.WriteLine($"Attending of Mr.(s) [{LastPerson}] Completed \n");
    Console.WriteLine($"Calling Next Person to come to the counter to be attended \n");
    Console.WriteLine("----------------------------------------------------------------------------- \n");

}

Console.WriteLine($"People in the current Queue: [{MyQueue.Count()}]");

Console.WriteLine("----------------------------------------------------------------------------- \n");

Stack<string> GameStack = new Stack<string>();

GameStack.Push("Sonic CD 2011");
GameStack.Push("Rockman X5");
GameStack.Push("Sonic & The Fallen Star");
GameStack.Push("Sonic Triple Trouble");

Console.WriteLine($"Count of Games to be Played [{GameStack.Count()}]");

while (GameStack.Count() > 0)
{
    Console.WriteLine("----------------------------------------------------------------------------- \n");
    Console.WriteLine($"Next Game to be Played on Stream will be [{GameStack.Peek()}] \n");
    string LastPlayedGame = GameStack.Peek();
    Console.WriteLine($" Currently Playing: [{GameStack.Pop()}] \n");
    Console.WriteLine($"Last Played Game: [{LastPlayedGame}] \n");
    Console.WriteLine("----------------------------------------------------------------------------- \n");
}

Console.WriteLine($"Count of Games to be Played [{GameStack.Count()}]");

Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.WriteLine("Doing some Dictionary Shenanigans This time \n");

Dictionary<string, string> GameDictionary = new Dictionary<string, string>();

GameDictionary.Add("STT", "Sonic Triple Trouble");
GameDictionary.Add("IE", "Inazuma Eleven");
GameDictionary.Add("IE2013", "Inazuma Eleven GO Strikers 2013");
GameDictionary.Add("S1F", "Sonic 1 Forever");
GameDictionary.Add("S2A", "Sonic 2 Absolute");
GameDictionary.Add("S3K", "Sonic 3 & Knuckles");
GameDictionary.Add("SCD2011", "Sonic CD 2011");

foreach (KeyValuePair<string, string> item in GameDictionary)
{
    Console.WriteLine($" Key: [{item.Key}] - Value [{item.Value}] \n");
}

Console.WriteLine("----------------------------------------------------------------------------- \n");

string ValueToSearch7 = "S3K";

Console.WriteLine("Original Value");
Console.WriteLine($"Value Found in the Dictionary : [{GameDictionary[ValueToSearch7]}] \n");
Console.WriteLine("----------------------------------------------------------------------------- \n");

GameDictionary[ValueToSearch7] = "Sonic 3 & Knuckles Angel Island Revisited";

Console.WriteLine("Changed Value");
Console.WriteLine($"Value Found in the Dictionary : [{GameDictionary[ValueToSearch7]}] \n");
Console.WriteLine("----------------------------------------------------------------------------- \n");

Console.WriteLine("Removing Dictionary Entries");

ValueToSearch7 = "SCD2011";

GameDictionary.Remove(ValueToSearch7);

foreach (KeyValuePair<string, string> item in GameDictionary)
{
    Console.WriteLine($" Key: [{item.Key}] - Value [{item.Value}] \n");
}

if (GameDictionary.TryGetValue("IE2013", out string ValueFound8))
{
    Console.WriteLine(ValueFound8);
}
else
{
    Console.WriteLine($"Game [{ValueToSearch7}] Not Found");
}

Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.WriteLine("Doing some LINQ Shenanigans This time \n");

int[] ArrayNum2 = new int[16] {24, 1, 3, 4, 5, 6, 0, 8, 10, 11, 15, 16, 16, 7, 14, 7};

var EvenNumberQuery = 
        from Num in ArrayNum2
        where Num % 2 == 0
        orderby Num
        select Num;

var OddNumberMethod = ArrayNum2.Where(x => x % 2 != 0).OrderBy(x => x).ToList();

Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.WriteLine("Imprimindo os Valores do vetor ArrayNum2");
Console.WriteLine("----------------------------------------------------------------------------- \n");

Operacao.ImprimirArray(ArrayNum2);

Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.ReadLine();
Console.Clear();

Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.WriteLine("Imprimindo somente os Valores Pares do vetor ArrayNum2 pelo método da Sintaxe de Query do LINQ\n");
Console.WriteLine("----------------------------------------------------------------------------- \n");

OperacaoLINQ.PrintLINQuery(EvenNumberQuery);

Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.ReadLine();
Console.Clear();

Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.WriteLine("Imprimindo somente os Valores Ímpares do vetor ArrayNum2 pelo método da Sintaxe de Método do LINQ (Ordem Ascendente)\n");
Console.WriteLine("----------------------------------------------------------------------------- \n");

OperacaoLista.PrintList(OddNumberMethod);

Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.ReadLine();
Console.Clear();

Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.WriteLine("Imprimindo somente os Valores Ímpares do vetor ArrayNum2 pelo método da Sintaxe de Método do LINQ (Ordem Descendente)\n");

OddNumberMethod = ArrayNum2.Where(x => x % 2 != 0).OrderByDescending(x => x).ToList();

Console.WriteLine("----------------------------------------------------------------------------- \n");
OperacaoLista.PrintList(OddNumberMethod);

Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.ReadLine();
Console.Clear();

var MinValue = ArrayNum2.Min();
var MaxValue = ArrayNum2.Max();
var Average = ArrayNum2.Average();
var Sum = ArrayNum2.Sum();
var UniqueArrayNum2 = ArrayNum2.Distinct().ToArray();


Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.WriteLine($"Minimum Value : [{MinValue}]");
Console.WriteLine($"Maximum Value : [{MaxValue}]");
Console.WriteLine($"Average Value : [{Average}]");
Console.WriteLine($"Sum : [{Sum}]");
Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.WriteLine("Imprimindo Array Original");
Operacao.ImprimirArray(ArrayNum2);
Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.WriteLine("Imprimindo Array Distinto");
Operacao.ImprimirArray(UniqueArrayNum2);


Console.WriteLine("----------------------------------------------------------------------------- \n");
Console.ReadLine();
Console.Clear();

