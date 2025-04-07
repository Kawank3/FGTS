Console.WriteLine("Cálculo do FGTS");
Console.WriteLine("Informe o salário: ");
string? input = Console.ReadLine();

decimal salário = Convert.ToDecimal(input);
decimal FGTS = salário * 0.08m;

Console.WriteLine($"FGTS: R$ {FGTS:F2}");
