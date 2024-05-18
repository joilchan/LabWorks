double r1 = 2;
double r2 = 1.2;
double s = Math.PI * (r1 + r2) * (r1 - r2);
if (s < 0)
    s = -s;

Console.WriteLine(s);

Console.WriteLine();

int n = 5;
int sum = n * (n + 1) / 2;
Console.WriteLine(sum);