// Task 1 - Write a basic for statement

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//Task 1.1 - Change the iteration conditions
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

//Task 1.2 - Experiment with the iterator's pattern
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

//Task 1.3 - Use the break keyword to break the iteration statement
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i==7) break;
}

//Task 1.4 - Loop through each element of an array
string [] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

//Task 1.5 - Change the iteration conditions
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);

//Task 2 - FizzBuzz Challenge

for (int i = 1; i < 1001; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
       Console.WriteLine("FizzBuzz"); 
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz"); 
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz"); 
    }
    else{
        Console.WriteLine($"{i}"); 
    }
}