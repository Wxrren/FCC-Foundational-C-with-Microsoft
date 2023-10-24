// Task 1 - Create an array of pallets, then sort them
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Task 1.1 - Reverse the order of the pallets
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Task 2 - Use array methods to clear and resize an array
string [] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Task 2.1 - Empty string versus null
string [] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Task 2.2 - Call a string helper method on a cleared element
string [] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Task 2.3 - Resize the array to add more elements
string [] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... Count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Task 2.4 - Resize the array to remove elements
string [] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... Count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resising 3 ... Count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Task 3 - Use the ToCharArray() to reverse a string
string value = "abc123";
char[] valueArray = value.ToCharArray();

//Task 3.1 - Reverse, then combine the char array into a new string
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

// Task 3.2 - Combine all of the chars into a new comma-separated-value string using Join()
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = string.Join(",", valueArray);
Console.WriteLine(result);

// Task 3.2 - Split() the comma-separated-value string into an array of strings
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = string.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

// Task 4 - Complete a challenge to reverse words in a sentence
string pangram = "The quick brown fox jumps over the lazy dog";
string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i<message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);

// Task 5 - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);


foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}