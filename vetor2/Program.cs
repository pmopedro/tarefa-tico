// Crie um programa em c# que leia um vetor de 10 alturas e
// elabore um algoritmo que permita calcular:
// A média das alturas

double[] entrada = new double[10];
double media=0;

Console.WriteLine("Entre com 10 valores");
for (int i=0; i < 10; i++){
    entrada[i] = Convert.ToInt32(Console.ReadLine());
    media = entrada[i]/10 + media;
    Console.WriteLine("A parcela da média é: " + entrada[i]/10);
    Console.WriteLine("Escreva mais " + (9-i));
};

Console.WriteLine("Sua média é " + media+" valores");
