// Task 1 - Hello world to console twice - add a new line and a new tab.
 Console.WriteLine("Hello\nWorld!");
 Console.WriteLine("Hello\tWorld!");

 // Task 1.1 - insert a double-quotation mark without using the character escape sequence - notice the error
  Console.WriteLine("Hello "world"!");
  
// Task 1.2 - Do the above but correctly
Console.WriteLine("Hello \"world\"!");

// Task 1.3 - Attempt to use the backslash to display a file path - Notice the error
Console.WriteLine("c:\source\repos");

// Task 1.4 - Do the above but correctly
Console.WriteLine("c:\\source\\repos");

// Task 1.5 - Create the mockup of the command line tool
Console.WriteLine("Genarating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Task 1.6 - Create a Vervatim String - add some white space
Console.WriteLine(@"c:\source\repos
    (This is where your code goes)");

// Task 1.7 - Add a verbatim string below the mockup you created
Console.WriteLine("Genarating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoice");

// Task 1.8 - Hello world but with Unicode escape characters

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u2061\u306F World!");

// Task 1.9 - Complete the mockup Command tool adding a a phrase in Japanese that translates: "To generate Japanese invoices"
Console.WriteLine("Genarating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoice");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User Command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// Task 2 - concatenate two strings together
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

// Task 2.1 - Concatenate multiple variables and literal strings
string firstName = "Bob";
string greeting ="Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

// Task 2.2 -  Modify the code you wrote earlier - avoid using intermediate variables
string firstName = "Bob";
string greeting ="Hello";
Console.WriteLine(greeting + " " + firstName + "!");

// Task 3 - Use the above code but using string interpolation
string firstName = "Bob";
string greeting ="Hello";
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

//Task 3.1 - Use string interpolation to combine a literal string and a variable value
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

//Task 3.2 - Use string interpolation with multiple variables and literal strings
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

// Task 3.3 - Modify the code you wrote earlier - avoid using intermediate variables
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

// task 3.4 - Combine verbatim literals and string interpolation
string projectName = "First-Project";
Console.WriteLine($@"c:\Output\{projectName}\Data");

/* Task 4 - Coding Challenge 
You'll use what you've learned about character escape sequences, verbatim strings, unicode, and string interpolation to provide instructions in both English and Russian.
You may only use either the Console.WriteLine() or the Console.Write() method twice.
In other words, to complete this challenge, you can only create two instructions that actually print output to the console. If you need to print additional new lines or add any formatting, you must use what you've learned in this module to accomplish it.

Use character escape sequences, verbatim strings, unicode, and string interpolation to generate the output. */
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// English
Console.WriteLine($@"View English Output:
c:\Exercise\{projectName}\data.txt");
//Russian
Console.WriteLine($"\n{russianMessage}:\nc:\\Exercise\\{projectName}\\ru-RU\\data.txt");
