Console.Clear();

int numero;

Console.Write("Digite um número para realizar a tabuada: ");
numero = Convert.ToInt32(Console.ReadLine());

for(int n = 0; n <= 10; n++){
    Console.WriteLine($"{numero} * {n} = {numero * n}");
}