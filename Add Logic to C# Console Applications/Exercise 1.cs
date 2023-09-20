//Task 1 - Use the equality operator
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1==2);

string myValue = "a";
Console.WriteLine(myValue == "a");

// Task 1.1 - Improve the check for string equality using the string's built-in helper methods
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Task 1.2 - Use the inequality operator
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

Console.WriteLine(myValue != "a");

// Task 1.3 - Use the Comparison operators
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

// Task 1.4 - Use a method that returns a Boolean
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// Task 1.5 - Use the Logical Negation operator
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

// Task 2 - Implement the conditional operator
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

// Task 2.1 - Use the conditional operator inline
int saleAmount = 1001;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100: 50)}");

// Task 3 - Conditional operator challenge - write code to display the result of a coin flip

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

// Task 4 - Complete a challenge activity using Boolean expressions

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin")) 
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact Admin for access.");
    }
    else 
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}