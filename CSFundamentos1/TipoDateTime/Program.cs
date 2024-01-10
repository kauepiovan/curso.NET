Console.WriteLine("Struct DateTime");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

DateTime DataHoje = new DateTime(2024, 01, 09);
Console.WriteLine(DataHoje);

DateTime DataHoraHoje = new DateTime(2024, 01, 09, 23, 49, 30);
Console.WriteLine(DataHoraHoje);

// Extraindo informações do DateTime
DateTime hoje = DateTime.Now;
Console.WriteLine(hoje);
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);
Console.WriteLine(hoje.Microsecond);

Console.WriteLine();

// Adicionando valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(30));
Console.WriteLine(hoje.AddYears(30));
Console.WriteLine(hoje.AddHours(30));
Console.WriteLine(hoje.AddMinutes(30));
Console.WriteLine(hoje.AddSeconds(30));
Console.WriteLine(hoje.AddMilliseconds(30));
Console.WriteLine(hoje.AddMicroseconds(30));

Console.WriteLine();

// Obter o dia da semana e o dia do ano 
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

Console.WriteLine();

// Data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());
