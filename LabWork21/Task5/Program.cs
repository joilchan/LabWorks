Console.WriteLine(GetPower(5, 3));

int GetPower(int x, int n)
{
    if (n == 0)
        return 1;
    if (n < 0)
        return -1;
    if (n % 2 == 1)
        return x * GetPower(x, n - 1);
    int temp = GetPower(x, n / 2);
    return temp * temp;
}