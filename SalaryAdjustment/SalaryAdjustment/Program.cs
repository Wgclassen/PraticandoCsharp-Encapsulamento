using SalaryAdjustment;

Funcionario f = new("Fernanda Lima", 4000);
f.ReajustarSalario(3500); // Inválido
f.ReajustarSalario(4200); // Válido
Console.WriteLine($"Funcionário: {f.Nome}\r\nSalário atual: R$ {f.Salario:F2}");