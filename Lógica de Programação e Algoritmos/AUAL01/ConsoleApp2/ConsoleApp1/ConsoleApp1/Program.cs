//Declaraçao de variaveis 
double largura;
double comprimento;
double area;
double valor;
double preco;

//Entrda de dados 
Console.Write("Digite a largura do terreno");
largura = double.Parse(Console.ReadLine());
Console.Write("Digite o comprimento do terreno: ");
comprimento = double.Parse(Console.ReadLine());
Console.Write("digite o valor do metro quadrado do terreno");
valor = double.Parse(Console.ReadLine());

//Processamento de dados
area = largura * comprimento;
preco = area * valor;

//saida de dados 
Console.WriteLine($"À`rea do terreno: {area:n}\nPreço do terreno: R$ {preco:n}");