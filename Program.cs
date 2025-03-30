
Console.WriteLine("Digite uma frase e veja como o Cebolinha falaria:");
string Frase = Console.ReadLine() ?? "";
string cebolinha = Frase.Replace("r", "l").Replace("R", "L");

Console.WriteLine(cebolinha);

