// See https://aka.ms/new-console-template for more information


//declarando e iniciando uma matriz com valores default
string[] matriz = new string[3];

//inserindo valores na matriz
matriz[0] = "Isac";
matriz[1] = "Pedro";
matriz[2] = "Davi";

//lendo valores da matriz
Console.WriteLine(matriz[0]);
Console.WriteLine(matriz[1]);
Console.WriteLine(matriz[2]);

matriz[0] = "Roberto";
Console.WriteLine($"O Novo valor da primeira posição é {matriz[0]}");

//outra forma de inicializar uma matriz
string[] matriz2 = {"A", "B"};

//lendo valores da matriz2
Console.WriteLine(matriz2[0]);
Console.WriteLine(matriz2[1]);
Console.WriteLine($"O tamanho da matriz 2 é {matriz2.Length}");

// outra forma de ler uma matriz. Usando foreach
foreach (var item in matriz)
{
    Console.WriteLine(item);
}

// outro exemplo
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine(sum);