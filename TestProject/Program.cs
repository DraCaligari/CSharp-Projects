// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;

// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// static string RandomNumber()
// {
//     Random random = new Random();
//     int coinValor = random.Next(0, 2);
//     string coin = coinValor == 0 ? "Cara" : "Cruz";

//     return coin;
// }

// Console.WriteLine(RandomNumber());

// string permission = "Admin|Manager";
// int level = 56;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level > 20)
//     {
//         Console.WriteLine("Contact an Admin for more information.");
//     }
//     else
//     {
//         Console.WriteLine("You don't have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You don't have permission to change the settings.");
// }


// string permission = "Admin|Manager";
// int level = 56;

// switch (permission)
// {
//     case string p when p.Contains("Admin") && level > 55:
//         Console.WriteLine("Welcome, Super Admin.");
//         break;
//     case string p when p.Contains("Admin"):
//         Console.WriteLine("Welcome, Admin.");
//         break;
//     case string p when p.Contains("Manager") && level > 20:
//         Console.WriteLine("Contact an Admin for more information.");
//         break;
//     case string p when p.Contains("Manager"):
//         Console.WriteLine("You don't have sufficient privileges.");
//         break;
//     default:
//         Console.WriteLine("You don't have permission to change the settings.");
//         break;
// }

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// bool found = false;
// int total = 0;

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//     {
//         found = true;
//     }
// }

// if (found)
// {
//     Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");


// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

// Console.WriteLine($"Product: {size} {color} {type}");


// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = product[0] switch
// {
//     "01" => "Sweat shirt",
//     "02" => "T-Shirt",
//     "03" => "Sweat pants",
//     _ => "Other"
// };

// string color = product[1] switch
// {
//     "BL" => "Black",
//     "MN" => "Maroon",
//     _ => "White"
// };

// string size = product[2] switch
// {
//     "S" => "Small",
//     "M" => "Medium",
//     "L" => "Large",
//     _ => "One Size Fits All"
// };

// Console.WriteLine($"Product: {size} {color} {type}");

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}