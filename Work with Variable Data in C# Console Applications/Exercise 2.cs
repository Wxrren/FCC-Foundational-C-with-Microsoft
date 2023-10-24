// Task 1 - Write code that attempts to add an int and a string and save the result in an int - notice the error
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);

// Task 1.1  - change the data type of the result variable from int to string - Notice the output is mathematically incorrect but completes by combining the values as the characters "2" and "4".
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

//Task 1.2 - Write code that converts an int to decimal
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
  
//Task 1.3 - Perform a cast
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

//Task 1.4 - Lose precision in a cast
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

//Task 1.5 - Use ToString() to convert a number to a string
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

//Task 1.6 - Convert a string to an int using the Parse() helper method
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

//Task 1.7 - Convert a string to a int using the Convert class
string Value1 = "5";
string Value2 = "7";
int result = Convert.ToInt32(Value1) * Convert.ToInt32(Value2);
Console.WriteLine(result);

//Task 1.8 - Compare casting and converting a decimal into an int
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m);  // converting rounds up
Console.WriteLine(value2);

//Task 2 - TryParse() a string into an int
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

// Task 2.1 - Use the parsed int later in code
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
 
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//Task 2.2 - Modify the string variable to a value that can't be parsed
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
 
if (result > 0)
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Task 3 - Complete a challenge to combine string array values as strings and as integers
string[] values = { "12.3", "45", "ABC", "11", "DEF"};

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else




    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total:  {total}");

//Task 4 - Complete a challenge to output math operations as specific number types
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");