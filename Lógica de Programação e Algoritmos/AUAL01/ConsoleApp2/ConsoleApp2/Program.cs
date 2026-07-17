using System.Net.Http.Headers;

double x, y, media;
Console.WriteLine("digite o propio numero:");
x = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundop nimero: ");
y = double.Parse(Console.ReadLine());
media = (x + y) / 2.0;
Console.WriteLine("Media=" + media);
