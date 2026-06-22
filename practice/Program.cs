/*
CONSOLE INPUT / OUTPUT

Printing to the Terminal, using the String kinda like an F string in Python

Console.WriteLine("What plastic is your disc made of?");
string? plastic = Console.ReadLine();

Console.WriteLine("What Mold is your disc?");
string? mold = Console.ReadLine();

Console.WriteLine($"Your Disc is a {plastic} {mold}");
*/





/*
VARIABLES AND TYPES

Declaring variables and using them in printed terminal lines

string name = "explorer";
string brand = "Lattitude";
int speed = 7;
int glide = 5;
int turn = 0;
int fade = 2;

Console.WriteLine($"{brand} {name}");
Console.WriteLine($"Flight: {speed} / {glide} / {turn} / {fade}");
*/



/* PARSING NUMBERS 

Getting user input then attempting to convert it from a string to a number stored in a new variable through a parse 

Console.WriteLine("Enter your discs speed:");
string? inputSpeed = Console.ReadLine();

Console.WriteLine($"Enter your discs glide:");
string? inputGlide = Console.ReadLine();

Console.WriteLine($"Enter your discs turn:");
string? inputTurn = Console.ReadLine();

Console.WriteLine($"Enter your discs fade:");
string? inputFade = Console.ReadLine();

bool successSpeed = int.TryParse(inputSpeed, out int speed);
bool successGlide = int.TryParse(inputGlide, out int glide);
bool successTurn = int.TryParse(inputTurn, out int turn);
bool successFade = int.TryParse(inputFade, out int fade);

if (successSpeed)
{
    if (successGlide)
    {
        if (successTurn)
        {
            if (successFade)
            {
                Console.WriteLine($"Your discs flight numbers are {speed} / {glide} / {turn} / {fade}");
            }
            else
            {
                Console.WriteLine($"Please enter a number");
            }

        }
        
    else
    {
        Console.WriteLine($"Please enter a number");
    }
    }
}
else
{
    Console.WriteLine($"Please enter a number");
}

*/



/* 
CONDITIONALS 

Pretty much the same syntax as python, make sure to use '==' for equals to

Console.WriteLine($"Enter a speed:");
string? input = Console.ReadLine();

bool validate = int.TryParse(input, out int speed);

if (speed < 4)
{
    Console.WriteLine($"Your chose a putter");
}
else if (speed == 4)
{
    Console.WriteLine($"Your chose an approach");
}
else if (speed == 5)
{
    Console.WriteLine($"You chose a midrange");
}
else if (speed > 5 && speed < 10)
{
    Console.WriteLine($"You chose a Fairway");
}
else if (speed >= 10)
{
    Console.WriteLine($"You chose a Distance Driver");
}
else
{
    Console.WriteLine("error");
}

*/

/*    METHODS      

static void DiscMenu()
{

    Console.WriteLine("1. Add Disc");
    Console.WriteLine("2. Remove Disc");
    Console.WriteLine("3. Exit");

    string? input = Console.ReadLine();
    bool success = int.TryParse(input, out int choice);

    if (success)
    {
        NamedDisc("Googa");
    }
}

static void NamedDisc(string name)
{
    Console.WriteLine($"The Disc is {name}");
}

static void main()
{
    DiscMenu();
}

main();

*/


/*   LOOPS  */

static void DiscMenu()
{

    Console.WriteLine("1. Add Disc");
    Console.WriteLine("2. Remove Disc");
    Console.WriteLine("3. Exit");
}

bool running = true;
while (running == true)
{
    DiscMenu();
    string? input = Console.ReadLine();
    if  (input == "1")
    {
        Console.WriteLine("What disc would you like to add?");
        string? discToAdd = Console.ReadLine();
    }
    else if (input == "2")
    {
        Console.WriteLine("What disc would you like to remove?");
        string? discToRemove = Console.ReadLine();
    }
    else if (input == "3")
    {
        running = false;
    }
}