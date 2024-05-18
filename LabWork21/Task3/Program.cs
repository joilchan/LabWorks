string GetSize(int bytes)
{
    if (bytes >= 1 << 30 )
        return $"{bytes} Б = {bytes >> 30} ГБ";
    if (bytes >= 1 << 20)
        return $"{bytes} Б = {bytes >> 20} МБ";
    if (bytes >= 1 << 10)
        return $"{bytes} Б = {bytes >> 10} КБ";
    return $"{bytes} Б";
}

Console.WriteLine(GetSize(530));
Console.WriteLine(GetSize(12312));
Console.WriteLine(GetSize(924234235));
Console.WriteLine(GetSize(1234234234));