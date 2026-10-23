Console.Write("Digite a sua primeira nota");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Digite a sua segunda nota");
double n2 = double.Parse(Console.ReadLine());

Console.Write("Digite a sua terceira nota");
double n3 = double.Parse(Console.ReadLine());

Console.Write("Digite a sua quarta nota");
double n4 = double.Parse(Console.ReadLine());

Console.Write("Digite a sua quinta nota");
double n5 = double.Parse(Console.ReadLine());

double media = (n1 + n2 + n3 + n4 + n5) / 5;

Console.Write($"A média das notas é: {media.ToString("F2")}");