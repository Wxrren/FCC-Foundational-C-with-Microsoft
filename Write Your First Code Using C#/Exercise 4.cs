
//Task 1 - Add two numeric values
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// Task 1.1 - Mix data types to force implicit type conversions
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// Task 1.3 - Attempt a more advanced case of adding numbers and concatenating strings
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

// Task 1.4 - Add parentheses to clarify your intention to the compiler
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// Task 2 - Write code to perform addition, subtraction, multiplication, and division with integers - Notice the error
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// Task 2.1 - Add code to perform division using literal decimal data
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// Tasks 2.2 - Add code to perform division using literal decimal data
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

// Task 2.3 - Write code to determine the remainder after integer division
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// Task 2.4 - Write code to exercise C#'s order of operations
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

// Task 3 - Write code to increment and decrement a value
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

// Task 3.1 - Use the increment operator before and after the value
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

// Code Challenge - Calculate Celsius given the current temperature in Fahrenheit
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m/9m);
Console.WriteLine("The temperature is " + celsius + " Celsius");

