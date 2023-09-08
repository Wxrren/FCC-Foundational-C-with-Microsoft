//All tasks completed on Microsoft Learn Compiler seperately. All tasks were then stored here to make it easier keeping these exercises I've worked on in one place and neat. The below isn't intended to be compiled as one big code as there are intentional errors here.

// Task 1 - Character Literals. Add a single alphanumeric character and print to screen.
Console.WriteLine('b');

// Task 1.1 - Do the same but write Hello World! - Notice the error.
Console.WriteLine('Hello World!');

// Task 1.2 - Integer literals. Add a numeric whole number and print to screen.
Console.WriteLine(123);

// Task 1.3 - Floating-point Literals. Print a literal float number to screen.
Console.WriteLine(0.25f);

//Task 1.4 - Double Literal. Print a double number to screen. 
Console.WriteLine(2.625);

// Task 1.5 - Decimal Literal. Print a decimal literal to screen. 
Console.WriteLine(12.39816m);

// Task 1.6 - Boolean Literal. Print a boolean literal to screen.
Console.WriteLine(true);
Console.WriteLine(false);

// Task 1.7 - show the difference between int literals and string literals
Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);

// Task 2 - Declare some variables of different values.

string firstName;

char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;

// Task 3 - Create your first variable. 
string firstName;
firstName = "bob";

// Task 3.1 - Improperly assign a variable - notice the error.
string firstName;
"bob" = firstName;

// Task 3.2 - Improperly assign a value of the incorrect data type to the variable - Notice the error.
int firstName
firstName = "bob";

// Task 3.2 - Retrieve a value you stored in the variable
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

// Task 3.3 - Reassign the value of a variable
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

// Task 3.4 - Initialize the variable - Attempt to get a variable that's not been set. Notice the error.
string firstName;
Console.WriteLine(firstName);

// Task 3.5 - Declare and set the value in one line of code.
string firstName = "bob";
Console.WriteLine(firstName);

// Challenge - Display literal and variable values

var name = "Bob";
int message = 3;
float cold = 34.4f;

Console.Write("Hello "); 
Console.Write(name);
Console.Write("! ");
Console.Write("You have ");
Console.Write(message);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(cold);
Console.Write(" celsius.");

