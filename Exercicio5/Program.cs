int A, B, C;
int maior;
int soma;

Console.Write("Digite o valor de A: ");
A = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de B: ");
B = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de C: ");
C = int.Parse(Console.ReadLine());

if (A > B && A > C)
{
    maior = A;
}
else if (B > A && B > C)
{
     maior = B;
}
else
{     
    maior = C;
}

Console.WriteLine("O maior número é: " + maior);

soma = A + B + C;

if  (soma % 2 == 0)
{
    Console.WriteLine("A soma dos números é par.");
}
else
{
    Console.WriteLine("A soma dos números é ímpar.");
}