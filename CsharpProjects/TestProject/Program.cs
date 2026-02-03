//See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello C#!");

//***************************************************//
//* Call the methods of a .Net class Library unit 3 *//
//***************************************************//

//Random dice = new Random(); // create instance of Random class
//int roll = dice.Next(1, 7); // generate random number between 1 and 6
//Console.WriteLine(roll); // display the random number


//*****************************//
//* Overloaded methods unit 4 *//
//*****************************//

//int number = 7;
//string text = "seven";

//Console.WriteLine(number); // calls the method that takes an int
//Console.WriteLine(); // calls the method that takes a string
//Console.WriteLine(text);// calls the method that takes a string



//**************************************//
//* exercise unit 4 overloaded methods *//
//**************************************//
Random dice = new();// create instance of Random class
int roll1 = dice.Next();// generate random number
int roll2 = dice.Next(101);// generate random number between 0 and 100
int roll3 = dice.Next(50, 101);// generate random number between 50 and 100

Console.WriteLine($"First roll: {roll1}");// display the random number
Console.WriteLine($"Second roll: {roll2}");// display the random number
Console.WriteLine($"Third roll: {roll3}");// display the random number