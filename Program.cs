Console.Clear();

Console.WriteLine("Soletrando");
Console.Write("Digite algo para ser soletrado: ");
string texto = Console.ReadLine()!;
Console.WriteLine(string.Join("-", texto.ToUpper().ToCharArray()));