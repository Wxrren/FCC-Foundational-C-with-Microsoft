// Task 1 - Make a Dice role method
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// Task 2 - Make a dice roll method that rolls 3 times. Make sure 1 has 0 input.
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// Task 3 - Code Challenge: Implement a method of the Math class that returns the larger of two numbers
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);
