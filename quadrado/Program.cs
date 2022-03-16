Console.WriteLine("Escreva um número n, vou te retornar o n, vou te retornar n*(1/n)^2: ");
double data = Convert.ToDouble(Console.ReadLine());

data = data * (1/data) * (1/data);  

Console.WriteLine("Seu resultado é: " + data);