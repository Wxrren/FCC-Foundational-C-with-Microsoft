//Task 1 Write a do-while statement to break when a certain random number is generated

Random random = new Random ();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

//Task 1.1  Write a while statement that iterates only while a random number is greater than some value

Random random = new Random ();
int current = random.Next(1,11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");

//Task 1.2  Use the continue statement to step directly to the Boolean expression
Random random = new Random ();
int current = random.Next(1,11);

do{
    current = random.Next(1,11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

//Task 2  write code to implement the game rules
Random dice = new Random();
int hero = 10;
int monster = 10;

do
{
    int roll = dice.Next(1,11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1,11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
    
} while (hero > 0 && monster >0);

Console.WriteLine(hero > monster ? "Hero Wins!" : "Monster Wins!");

// Task 2 but with a while loop
while (hero > 0 && monster >0)
{
    int roll = dice.Next(1,11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    roll = dice.Next(1,11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
} 

Console.WriteLine(hero > monster ? "Hero Wins!" : "Monster Wins!");

//Task 3  Examine the difference between do and while statement iterations
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

while (validNumber == false)
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
}

Console.WriteLine($"Your input value ({numValue}) has been accepted.");


//Task 3.1  Examine the difference between do and while statement iterations

string? readResult;
string valueEntered = "";
string role1 = "Administrator";
string role2 = "Manager";
string role3 = "User";
bool validRole = false;

Console.WriteLine($"Enter your role name ({role1} {role2}, {role3})");

while(validRole == false)
{
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        valueEntered = readResult.Trim();
    }

    if (valueEntered.ToLower() == "administrator" || valueEntered.ToLower() == "manager" || valueEntered.ToLower() == "user")
    {
        validRole = true;
    }
   
    else
    {
        validRole = false;
        Console.WriteLine($"The role name that you entered, ({valueEntered})is not valid. Enter your role name ({role1} {role2}, {role3})");
    }
}

Console.WriteLine($"Your input value ({valueEntered}) Has been accepted.");

//Task 3.2  Examine the difference between do and while statement iterations

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    //Extract the sentences from each string and display them seperately
    while (periodLocation != -1)
    {
        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}