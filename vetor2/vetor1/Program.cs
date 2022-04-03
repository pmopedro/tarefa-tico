//  Crie um programa em c# que leia um vetor de 10
// números inteiros e gere um segundo vetor (que deve ser
// impresso), cujas posições pares são o dobro do vetor
// original e as ímpares são o triplo.


int[] entrada = new int[10];
int[] saida = new int[10];

Console.WriteLine("Entre com 10 valores");
for (int i=0; i < 10; i++){
    entrada[i] = Convert.ToInt32(Console.ReadLine());
};

for (int i=0; i < 10; i++){
    if (i%2 == 1){ //quando ele é impar!! 
        saida[i]=entrada[i]*3;
    }else{ // caso contrário (caso par)
        saida[i]=entrada[i] *2;
    }
};

Console.WriteLine("Os valores entrantes foram:");
for (int i=0; i < 10; i++) {
    Console.WriteLine(saida[i]);
};