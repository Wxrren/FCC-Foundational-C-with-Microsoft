// Task 1 - Create decision logic with if statements

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total >= 15)
{
    Console.WriteLine("You win!");
}
if (total < 15)
{
    Console.WriteLine("Sorry, You lose.");
}

// Task 1.1 - Add another if statement to implement the doubles bonus
if ((roll1 == roll2)  (roll2 == roll3)  (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

// Task 1.2 - Add another if statement to implement the triples bonus
if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

// Task 2 - Create nested decision logic with if, else if, and else

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if ((roll1 == roll2)  (roll2 == roll3)  (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else 
{
    Console.WriteLine("You win a kitten!");
}

// Task 3 coding challenge
Random random = new Random();
int daysUntilExpiration = random.next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your suscription ends in {daysUntilExpiration} days");
    discountPercentage = 20%;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your suscription ends in {daysUntilExpiration} days");
    discountPercentage = 10%;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!")
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}


