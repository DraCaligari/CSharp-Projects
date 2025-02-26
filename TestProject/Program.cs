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

string permission = "Admin|Manager";
int level = 56;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level > 20)
    {
        Console.WriteLine("Contact an Admin for more information.");
    }
    else
    {
        Console.WriteLine("You don't have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You don't have permission to change the settings.");
}