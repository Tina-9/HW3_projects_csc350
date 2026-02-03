// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello C#!");

// Call the methods of a .Net class Library unit 3
Random dice = new Random(); // create instance of Random class
int roll = dice.Next(1, 7); // generate random number between 1 and 6
Console.WriteLine(roll); // display the random number

//Overloaded methods unit 4
int number = 7;
string text = "seven";

Console.WriteLine(number); // calls the method that takes an int
Console.WriteLine(); // calls the method that takes a string
Console.WriteLine(text);// calls the method that takes a string