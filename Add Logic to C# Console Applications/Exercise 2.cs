// Task 1 - Create a variable inside of a code block

bool flag = true;
if(flag)
{
    int value = 10;
    Console.WriteLine($"Inside of a code block: {value}");
}

// Task 1.1 - Attempt to access the variable outside of the code block - Notice the error

bool flag = true;
if(flag)
{
    int value = 10;
    Console.WriteLine($"Inside of a code block: {value}");
}
Console.WriteLine($"outside of code block: {value}"); //error CS0103: The name 'value' does not exist in the current context

// Task 1.2 - Move the variable outside - Notice the error

bool flag = true;
int value;

if(flag)
{
    value = 10;
    Console.WriteLine($"Inside of a code block: {value}");
}
Console.WriteLine($"outside of code block: {value}"); //error CS0165: Use of unassigned local variable 'value'

// Task 1.3 - Initialize the variable with a value

bool flag = true;
int value = 0;

if(flag)
{
    value = 10;
    Console.WriteLine($"Inside of a code block: {value}");
}
Console.WriteLine($"outside of code block: {value}");

// Task 2 - Create an example of an if statement that uses a code block
bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}

// Task 2.1 - Remove the curly braces
bool flag = true;
if (flag)
    Console.WriteLine(flag);

// Task 2.2 - Examine the readability of single-line form if statements
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

// Task 2.3 - Make it easier to read
string name = "steve";

if (name == "bob") 
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else 
    Console.WriteLine("Found Chuck");

// Task 3 - update problematic code in the code editor 

int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total+= number;

    if (number ==42)
    {
        bool found = true
    }

}

if (found)
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"TotalL {total}");
// This is the code they would like corrected.

// Task 3 - update problematic code in the code editor - Completed version

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total {total}");