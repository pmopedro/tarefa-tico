int soma = 0;

Console.WriteLine("Entre com 10 numeros (um de cada vez e intercalado de enter):");

for (int i=1; i < 11; i++) 
{
    int data = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Entre com mais "+(10-i)+" valores: ");
    soma = soma + i*data;
};

Console.WriteLine("A soma ponderada desejada é: "+ Convert.ToString(soma));