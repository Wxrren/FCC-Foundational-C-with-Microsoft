// Task 1 - Write hello world using composite formatting
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

//Task 1.1 - Update your code with different inputs
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

//Task 1.2 - Hello world using string interpolation
string first = "Hello";
string second = "world";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// Task 1.3 - display a price using the currency format specifier
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:c} save {discount:c}");

//Task 1.4 - ormat the number for readability by including commas to delineate thousands, millions, billions
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

//Task 1.5 - Format percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

//Task 1.6 - combine formatting approaches 
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);

Console.WriteLine(yourDiscount);

//Task 1.7 - Build on the previous code concatenating the calculated percentage using the string interpolation instead of string concatenation
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; 
Console.WriteLine(yourDiscount);

//Task 2 - Display the invoice number using string interpolation
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"  Shares: {productShares:N3} Product");
Console.WriteLine($"   Sub Total: {subtotal:C}");
Console.WriteLine($"     Tax: {taxPercentage:P}");
Console.WriteLine($"       Total Billed: {total:c}");

//Task 3- Formatting strings by adding whitespace before or after
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));

// Task 3.1 - pad both sides and display a -
string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

//Task 3.2 - Add the Payment ID to the output
string paymentId = "769C";

var formattedLine = paymentId.PadRight(6);

Console.WriteLine(formattedLine);

//Task 3.3 - Add the payee name to the output
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);

Console.WriteLine(formattedLine);

//Task 3.4 - Add the payment amount to the output
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine(formattedLine);

//Task 4 - Complete a challenge to apply string interpolation to a form letter
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);