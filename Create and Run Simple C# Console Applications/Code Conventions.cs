// Task 1 - Create effective code comments

string firstName = "Bob";
int widgetsPurchased = 7;
//Testing a change to the message.
//int widgetsSold = 7;
//Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

// Task 1.1 - put in new code with comments for each line
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

//Task 1.2 - Create a short paragraph explaing the problem the code fixes

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

//Task 2 Add code to illustrate how whitespace is ignored by the C# compiler
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2
string firstWord="hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

//Task 2.1 - Take a minute to consider how you would use whitespace to improve the readability of this code.
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

//Task 2.2 - Correct the above code and improve readability
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

/* Task 3 - Complete a challenge activity to improve code readability
I am provided with a code sample that is poorly styled and commented. 
My goal is to update the code using style guidelines for variable names, code comments, and whitespace to improve code readability.
*/

// Provided sample
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

// Corrected Sample

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] Message = originalMessage.ToCharArray();
Array.Reverse(Message);

int letterCount = 0;

foreach (char i in charMessage) 
{ 
    if (letter == 'o') 
    { 
        letterCount++; } 
}

string newMessage = new String(Message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");