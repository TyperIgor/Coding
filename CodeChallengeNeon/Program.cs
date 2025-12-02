

Console.WriteLine("Digite o valor de saque");
int saque = int.Parse(Console.ReadLine());

int qtdcedulas = 0;

int[] array = { 100, 50, 20, 10, 5, 2 };

List<int> listaDeCedulasSaque =new List<int>();

int tempSolution = 0;

for (int i = 0; i < array.Length-1; i++)
{
    if (saque == array[i])
    {
        qtdcedulas++;
        listaDeCedulasSaque.Add(array[i]);
        break;
    }

    if (array[i] + array[i] == saque)
    {
        qtdcedulas++;
        listaDeCedulasSaque.Add(array[i]);
        break;
    }
    while (saque >= array[i])
    {
        qtdcedulas++;
        listaDeCedulasSaque.Add(array[i]);
        saque -= array[i];
    }

    continue;
    
}


Console.WriteLine($"Quantidade de celulas necessárias para o saque {qtdcedulas}");

foreach (var cedulasSaque in listaDeCedulasSaque)
{
    Console.WriteLine($"Notas a serem devolvidas do Saque{cedulasSaque}");
}

Console.WriteLine($"Fim");
