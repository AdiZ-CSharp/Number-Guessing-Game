string appName = "Number Guessing Game";
string appVersion = "1.0.0";
string appAuthor = "ztech58";


Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);


Console.WriteLine("\n\n\nThis is a number guessing game. Please choose a minimum number (inclusive): ");

int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nNow, choose a maximum number (exclusive): ");

int max = Convert.ToInt32(Console.ReadLine());

if(min > max)
{
    while(min > max)
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Sorry, please choose a maximum number larger than your minimum number:");
        max = Convert.ToInt32(Console.ReadLine());
    }
}

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\nNow, choose a number between " + min + "(inclusive) & " + max + "(exclusive).");

int guess = Convert.ToInt32(Console.ReadLine());

int answer = RNG(min, max);

if (guess == answer)
{
    Console.WriteLine("\nWell done! Your guess was correct.");
}

if (guess > answer)
{
    int dif = guess - answer;
    Console.WriteLine("\nYour guess was " + dif + " too high.\nThe correct number was " + answer);
}

if (guess < answer)
{
    int dif = answer - guess;
    Console.WriteLine("\nYour guess was " + dif + " too low.\nThe correct number was " + answer);
}

Console.WriteLine("\nThanks for playing! Click any key to end the game.");


// Wait before ending program //
Console.ReadKey();


static int RNG(int min, int max)
{
    int result;

    Random numberGen = new Random();
    result = numberGen.Next(min, max);

    return result;
}