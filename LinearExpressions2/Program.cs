double m, n;
Console.Write("Введiть додатнє m: ");
m = double.Parse(Console.ReadLine());
Console.Write("Введiть невiд'ємне n: ");
n = double.Parse(Console.ReadLine());

double z1, z2;
z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m*m*m*n) + n*m + m*m - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"z1 = {z1}, z2 = {z2}");

double a, b, x;
Console.Write("Введiть ненульове a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Введiть b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Введiть x: ");
x = double.Parse(Console.ReadLine());

double y;
y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b) * Math.Sin(a - b) + 0.01 * (x - b);
Console.WriteLine($"y = {y}");