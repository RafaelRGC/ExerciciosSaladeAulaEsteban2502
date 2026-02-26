double nota1, nota2, nota3, media;

Console.WriteLine("Digite a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
nota3 = double.Parse(Console.ReadLine());

media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / (2 + 3 + 5);

Console.WriteLine("A média ponderada é: " + media);