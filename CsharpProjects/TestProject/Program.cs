// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello C#!");

// Call the methods of a .Net class Library unit 3
Random dice = new Random(); // create instance of Random class
int roll = dice.Next(1, 7); // generate random number between 1 and 6
Console.WriteLine(roll); // display the random number

