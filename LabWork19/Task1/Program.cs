using Task1;

Context context = new(new OperationAdd());
Console.WriteLine($"10 + 5 = {context.ExecuteStrategy(10, 5)}");

context = new(new OperationSubstract());
Console.WriteLine($"10 - 5 = {context.ExecuteStrategy(10, 5)}");

context = new(new OperationMultiply());
Console.WriteLine($"10 * 5 = {context.ExecuteStrategy(10, 5)}");

context = new(new OperationDivide());
Console.WriteLine($"10 / 5 = {context.ExecuteStrategy(10, 5)}");