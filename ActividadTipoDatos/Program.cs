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

// int value1 = 11; 
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// int result1 = (int)Math.Round(value1 / value2);

// decimal result2 = value2 / (decimal)value3;

// float result3 = value3 / value1;

// Console.WriteLine($"Divide value1 by value2: {result1}");

// Console.WriteLine($"Divide value2 by value3: {result2}");

// Console.WriteLine($"Divide value3 by value1: {result3}");

// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] words = pangram.Split(' ');

// for (int i = 0; i < words.Length; i++)
// {
//     char[] letters = words[i].ToCharArray();
//     Array.Reverse(letters);
//     words[i] = new string(letters);
// }

// string result = string.Join(" ", words);
// Console.WriteLine(result);

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] orders = orderStream.Split(',');
// Array.Sort(orders);

// foreach (string orderId in orders)
// {
//     if (orderId.Length != 4)
//     {
//         Console.WriteLine($"{orderId}\t- Error");    
//     }
//     else 
//     {
//         Console.WriteLine(orderId); 
//     }
// }


// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int quantityStart = input.IndexOf(openSpan) + openSpan.Length; 
// int quantityEnd= input.IndexOf(closeSpan);
// int quantityLength = quantityEnd - quantityStart;
// quantity = input.Substring(quantityStart, quantityLength);
// quantity = $"Quantity: {quantity}";

// const string tradeSymbol = "&trade;";
// const string regSymbol = "&reg;";
// output = input.Replace(tradeSymbol, regSymbol);

// const string openDiv = "<div>";
// int divStart = output.IndexOf(openDiv);
// output = output.Remove(divStart, openDiv.Length);

// const string closeDiv = "</div>";
// int divCloseStart = output.IndexOf(closeDiv);
// output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

// Console.WriteLine(quantity);
// Console.WriteLine(output);

