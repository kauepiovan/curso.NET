Console.WriteLine("Nullable Types");

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

int? i1 = null;
double? d1 = null;
bool? b1 = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

Console.WriteLine(i1);  
Console.WriteLine(d1);
Console.WriteLine(b1);

int? a = null;
int b2 = a ??  0;
Console.WriteLine(b2);

if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui um valor");
}