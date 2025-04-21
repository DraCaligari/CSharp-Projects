// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// int[] data;
// data = new int[5];

// int[] data = new int[5];

// int first = 2;
// string second = "4";
// int result = first + int.Parse(second);
// Console.WriteLine(result);

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// string message = "";
// double total = 0;

// foreach (string value in values)
// {
//     if (double.TryParse(value, out double number))
//     {
//         total += number;
//     }
//     else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Total: {total}");
// Console.WriteLine($"Invalid values: {message}");

int value1 = 11; 
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = (int)Math.Round(value1 / value2);

decimal result2 = value2 / (decimal)value3;

float result3 = value3 / value1;

Console.WriteLine($"Divide value1 by value2: {result1}");

Console.WriteLine($"Divide value2 by value3: {result2}");

Console.WriteLine($"Divide value3 by value1: {result3}");