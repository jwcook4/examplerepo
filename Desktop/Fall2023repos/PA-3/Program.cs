// ********** Attention **********

    // Please run this application in an actual command prompt and not VSC terminal



using System;

using System.Threading;

class Program
{
    static int currentHours = 0;
    static int usedWordsCount = 0;
    static string[] usedWords = new string[10];
    static int currentHoursFromSpin = 0;
    static int currentHoursPasswordCracker = 0;
    static int currentHoursSecretGame = 0;



    static void Main()
    {
        bool continuePlaying = true;
               
        DisplayMenu();
       
        do
        {   
            int userChoice = GetUserChoice();

            switch (userChoice)
            {
                case 1:
                    PasswordCrackerGame();
                    break;

                case 2:
                    SpinTheWheelGame();
                    break;

                case 3:
                    SecretGame();
                    break;

                case 4:
                    DisplayCurrentHours();
                    break;

                case 5:
                    continuePlaying = false;
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter the correct input");
                    break;
            }
        }   
        while (continuePlaying);

        DisplayFinalScreen();

        Console.ReadLine();
}
static void DisplayMenu()
{
    Console.Clear();
    Console.WriteLine("+==========================================================+");
    Console.WriteLine("| ____                _____          _       _             |");
    Console.WriteLine("|/ ___| _ __  _   _  |_   _| __ __ _(_)_ __ (_)_ __   __ _ |");
    Console.WriteLine("|\\___ \\| '_ \\| | | |   | || '__/ _` | | '_ \\| | '_ \\ / _` ||");
    Console.WriteLine("| ___) | |_) | |_| |   | || | | (_| | | | | | | | | | (_| ||");
    Console.WriteLine("|\\____/| .__/ \\__, |   |_| |_|\\__,_|_|_| |_|_|_| |_|\\__, ||");
    Console.WriteLine("| __  _ _|_|    |___/                                  |___/ |");
    Console.WriteLine("|  \\/  | ___ _ __  _   _                                  |");
    Console.WriteLine("| |\\/| |/ _ \\ '_ \\| | | |                                 |");
    Console.WriteLine("| |  | |  __/ | | | |_| |                                 |");
    Console.WriteLine("|_|  |_|\\___|_| |_|\\__,_|                                 |");
    Console.WriteLine("+==========================================================+");
    System.Console.WriteLine();
    Console.WriteLine("Press enter to continue");
    Console.ReadLine(); 
    Console.Clear();
}
   
 static void DisplayFinalScreen()
    {
        currentHours = currentHoursFromSpin + currentHoursPasswordCracker;


        if (currentHours >= 6){
        Console.Clear();
        Console.WriteLine("____    ____  ______    __    __     ____    __    ____  __  .__   __.");
        Console.WriteLine("\\   \\  /   / /  __  \\  |  |  |  |    \\   \\  /  \\  /   / |  | |  \\ |  |");
        Console.WriteLine(" \\   \\/   / |  |  |  | |  |  |  |     \\   \\/    \\/   /  |  | |   \\|  |");
        Console.WriteLine("  \\_    _/  |  |  |  | |  |  |  |      \\            /   |  | |  . `  |");
        Console.WriteLine("    |  |    |  `--'  | |  `--'  |       \\    /\\    /    |  | |  |\\   |");
        Console.WriteLine("    |__|     \\______/   \\______/         \\__/  \\__/     |__| |__| \\__|");
        }
        else{
        Console.Clear();
        Console.WriteLine("    ____    ____  ______    __    __      __        ______        _______. _______ ");
        Console.WriteLine("   \\   \\  /   / /  __  \\  |  |  |  |    |  |      /  __  \\      /       ||   ____|");
        Console.WriteLine("    \\   \\/   / |  |  |  | |  |  |  |    |  |     |  |  |  |    |   (----`|  |__   ");
        Console.WriteLine("     \\_    _/  |  |  |  | |  |  |  |    |  |     |  |  |  |     \\   \\    |   __|  ");
        Console.WriteLine("       |  |    |  `--'  | |  `--'  |    |  `----.|  `--'  | .----)   |   |  |____ ");
        Console.WriteLine("       |__|     \\______/   \\______/     |_______| \\______/  |_______/    |_______|");
        }
    }

    static int GetUserChoice()
    {
        Console.Clear();
        Console.WriteLine("1. Password Cracker Game");
        System.Console.WriteLine();
        Console.WriteLine("2. Spin the Wheel Game");
        System.Console.WriteLine();
        Console.WriteLine("3. S3CRT 6AM3");
        System.Console.WriteLine();
        Console.WriteLine("4. Display Current Hours");
        System.Console.WriteLine();
        Console.WriteLine("5. Exit the program");
       System.Console.WriteLine("-------------------------------------");
        Console.Write("Enter your choice (1-4): ");
       
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            Console.Write("Enter your choice (1-4): ");
        }
        return choice;
    }

static bool IsWordUsed(string word)
    {
        for (int i = 0; i < usedWordsCount; i++)
        {
            if (usedWords[i] == word)
            {
                return true; 
            }
        }
        return false; 
    }

static void PasswordCrackerGame()
{
    Console.Clear();
    
    int incorrectGuessCount = 0;
    int correctGuessCount = 0;
    
    bool continuePlaying = true;

    Console.WriteLine(@"_                          __                  
        |_) _  _  _     _  __ _|   /   __ _  _  |  _  __
        |  (_|_> _> \^/(_) | (_|   \__ | (_|(_  |<(/_ |");

    int emptyLines = (Console.WindowHeight - 10) / 8;
    for (int i = 0; i < emptyLines; i++)
    {
        Console.WriteLine();
    }

    Console.WriteLine("Welcome to the Password Cracker Game, guess the word and be awarded");
    System.Console.WriteLine("-------------------------------------");

    if (currentHoursPasswordCracker >= 3)
    {
Console.WriteLine("____ ___  __  __ ____  _     _____ _____ _____ ");
Console.WriteLine(" / ___/ _ \\|  \\/  |  _ \\| |   | ____|_   _| ____|");
Console.WriteLine("| |  | | | | |\\/| | |_) | |   |  _|   | | |  _|  ");
Console.WriteLine("| |__| |_| | |  | |  __/| |___| |___  | | | |___ ");
Console.WriteLine(" \\____\\___/|_|  |_|_|   |_____|_____| |_| |_____|");
        System.Console.WriteLine("----------------------------------");
        Console.WriteLine("Press enter to return to the main menu");
        Console.ReadLine();
        GetUserChoice();
        return;
    }

    ResetUsedWords();

    string selectedWord;

    do
    {
        selectedWord = GetRandomWord();
    } while (IsWordUsed(selectedWord));

    char[] guessedWord = new char[selectedWord.Length];
    for (int i = 0; i < selectedWord.Length; i++)
    {
        guessedWord[i] = '_';
    }

    usedWords[usedWordsCount] = selectedWord;
    usedWordsCount++;

    while (incorrectGuessCount < 10)
    {
        System.Console.WriteLine();
        Console.WriteLine($"Attempts remaining: {10 - incorrectGuessCount}");
        System.Console.WriteLine();
        Console.WriteLine($"Current word: {new string(guessedWord)}");
        System.Console.WriteLine();
        Console.Write("Enter your guess: ");
        string guessInput = Console.ReadLine();

        if (guessInput.Length == 1)
        {
            char guess = char.ToUpper(guessInput[0]);

            bool alreadyGuessed = IsWordUsed(guess.ToString());

            if (!alreadyGuessed)
            {
                 if (usedWordsCount < usedWords.Length)
                {
                    usedWords[usedWordsCount] = guess.ToString();
                    usedWordsCount++;
                }
                else if (incorrectGuessCount == 10)
                {
        Console.WriteLine(" _____ _    ___ _     ");
        Console.WriteLine("|  ___/ \\  |_ _| |    ");
        Console.WriteLine("| |_ / _ \\ | || |    ");
        Console.WriteLine("|  _/ ___ \\| || |___ ");
        Console.WriteLine("|_|/_/   \\_\\___|_____|");
        System.Console.WriteLine("----------------------------------");
        System.Console.WriteLine("Press enter to return to the main menu");
                    Console.ReadLine();
                    GetUserChoice();
                    return;
                }

                bool correctGuess = false;
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == guess)
                    {
                        guessedWord[i] = guess;
                        correctGuess = true;
                        correctGuessCount++;
                    }
                }

                if (correctGuess)
                {
                    Console.Clear();
                    Console.WriteLine("\nCorrect guess! Keep it up!");

                    if (correctGuessCount == selectedWord.Length)
                    {
                        System.Console.WriteLine();
                        Console.WriteLine($"Congratulations! You guessed the word '{selectedWord}'! 1 hour has been rewarded");
                        System.Console.WriteLine("---------------------------------------------------------------------------");
                        currentHoursPasswordCracker += 1;

                        if (currentHoursPasswordCracker >= 3)
                        {
                            Console.WriteLine("You've reached the maximum limit of 3 hours.");
                            currentHoursPasswordCracker = 3;
                        }

                            Console.WriteLine("Press enter to return to the main menu or press 'Y' to play again");
                        ConsoleKeyInfo key = Console.ReadKey();

                        if (key.KeyChar == 'Y' || key.KeyChar == 'y')
                        {
                            Console.Clear(); 
                            PasswordCrackerGame(); 
                        }
                        else
                        {
                            GetUserChoice(); 
                        }

                        return;
                    }
                }
                    else
                    {
                        Console.Clear();
                        incorrectGuessCount++;
                    }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nThis letter has been guessed. Please try again.");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter a single letter as your guess.");
        }
    }

    if (incorrectGuessCount == 10)
{
    Console.WriteLine(" _____ _    ___ _     ");
    Console.WriteLine("|  ___/ \\  |_ _| |    ");
    Console.WriteLine("| |_ / _ \\ | || |    ");
    Console.WriteLine("|  _/ ___ \\| || |___ ");
    Console.WriteLine("|_|/_/   \\_\\___|_____|");
    System.Console.WriteLine("----------------------------------");
    System.Console.WriteLine("Press enter to return to the main menu");    
    Console.ReadLine();
    GetUserChoice(); 
    return;  
}
}     



static void ResetUsedWords()
{
    usedWords = new string[10];
    usedWordsCount = 0;
}


    static string GetRandomWord(){
        string[] words = { "SPY", "HACKER", "SECRET", "PENGUIN", "TRAINING" };
        Random random = new Random();
        return words[random.Next(words.Length)];
    }
    

static void SpinTheWheelGame()
{
if (currentHoursFromSpin >= 3)
    {
        Console.WriteLine("Congratulations! You have completed the Spin the Wheel game.");
        Console.WriteLine("Press enter to return to the main menu");
        Console.ReadLine();
        GetUserChoice();
        return;

    }

    string asciiArt = @"
 __  ____  __ __  __ ______ __  __  ____ __    __ __  __  ____  ____ __   
(( \\ || \\ || ||\\ || | || | ||  || ||    ||    || ||  || ||    ||    ||   
 \\  ||_// || || \\||   ||   ||==|| ||==  \\ /\ // ||==|| ||==  ||==  ||   
  \\ ||    || ||  \||   ||   ||  || ||___  \V/\V/  ||  || ||___ ||___ ||__|";

    Console.WriteLine(asciiArt);
    Console.WriteLine("Spin the wheel and allow your future to be told");

    string[] wheelOptions = { "Earn 1 credit hour", "Randomly gain or lose 2 hours", "Lose 1 credit hour", "Lose all credits", "Nothing happens" };
    Random random = new Random();
    int spinResult = GetRandomNumber(5);
    Console.WriteLine($"Wheel Option: {wheelOptions[spinResult]}");

    switch (spinResult)
    {
        case 0:
            System.Console.WriteLine();
            Console.WriteLine("Congratulations! You have earned 1 hour");
            currentHoursFromSpin += 1;

            if (currentHoursFromSpin >= 3)
            {
                currentHoursFromSpin = 3;
                Console.WriteLine("You've reached the maximum limit of 3 hours.");
            }
            break;

        case 1:
            int randomHour = GetRandomNumber(-2, 3);  
            Console.WriteLine($"You landed on: {randomHour} hours");

        if (randomHour > 0)
        {
            Console.WriteLine($"Congratulations! You gained {randomHour} hour{(randomHour > 1 ? "s" : "")}.");
        }
        else if (randomHour < 0)
        {
            Console.WriteLine($"Oh no! You lost {-randomHour} hour{(randomHour < -1 ? "s" : "")}.");
        }
        else
        {
            Console.WriteLine("Nothing happened. Your hours remain unchanged.");
        }

        if (currentHours + currentHoursFromSpin + randomHour > 3)
        {
            int remainingHours = 3 - currentHours - currentHoursFromSpin;
            currentHoursFromSpin += remainingHours;
            Console.WriteLine($"You've reached the maximum limit of 3 hours. Adding {remainingHours} hours.");
        }
        else
        {
            currentHoursFromSpin += randomHour;
        }
        break;


       case 2:
    Console.WriteLine("You lost 1 hour. Don't give up, keep spinning!");

    if (currentHoursFromSpin > 0)
    {
        currentHoursFromSpin = Math.Max(0, currentHoursFromSpin - 1);
    }
    break;


    case 3:
    Console.WriteLine("YIKES! You lost all of your hours. Maybe you're just unlucky");

    if (currentHoursFromSpin > 0)
    {
        currentHoursFromSpin = Math.Max(0, currentHoursFromSpin - 2);
    }
    else
    {
        currentHoursFromSpin -= 2;

        if (currentHoursFromSpin < -4)
        {
            currentHoursFromSpin =- 4; 
        }
    }
    break;


        case 4:
            Console.WriteLine("YOUR COMPUTER WILL SELF DESTRUCT IN: ");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Wait Wait Wait. This is only a training exercise. I apologize for this inconvenience. Self-destruct negated.");
            System.Console.WriteLine();
            break;
    }

    Console.WriteLine("Press enter to return to the main menu or press 'Y' to play again");
    ConsoleKeyInfo key = Console.ReadKey();

    if (key.KeyChar == 'Y' || key.KeyChar == 'y')
    {
        Console.Clear(); 
        SpinTheWheelGame(); 
    }
    else
    {
        GetUserChoice(); 
    }
}



static int GetRandomNumber(int maxValue)
{
    Random random = new Random();
    return random.Next(maxValue);
}

static int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    return random.Next(minValue, maxValue);
}

static void SecretGame()
{
    Console.Clear();

    int incorrectGuessCount = 0;
    int correctGuessCount = 0;
    char[] snowmanParts = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

    Console.WriteLine("You made it to the 53CR3T 6AM3... Guess the new passwords.");

    string selectedWord = LoadRandomWordFromFile("words.txt");

    char[] guessedWord = new char[selectedWord.Length];
    for (int i = 0; i < selectedWord.Length; i++)
    {
        guessedWord[i] = '_';
    }

    while (incorrectGuessCount < 10)
    {
        Console.WriteLine($"Snowman: {new string(snowmanParts)}");
        Console.WriteLine($"Attempts remaining: {10 - incorrectGuessCount}");
        Console.WriteLine($"Current word: {new string(guessedWord)}");
        Console.Write("Enter your guess: ");
        string guessInput = Console.ReadLine();

        if (guessInput.Length == 1)
        {
            char guess = char.ToUpper(guessInput[0]);

            bool correctGuess = false;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == guess)
                {
                    guessedWord[i] = guess;
                    correctGuess = true;
                    correctGuessCount++;
                }
            }

            if (!correctGuess)
            {
                Console.Clear();
                incorrectGuessCount++;
            }

            if (correctGuessCount == selectedWord.Length)
            {
                Console.Clear();
                Console.WriteLine($"Congratulations! You guessed the word '{selectedWord}'!");
                currentHoursSecretGame += 1; 

                Console.WriteLine("Press enter to return to the main menu or press 'Y' to play again");
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.KeyChar == 'Y' || key.KeyChar == 'y')
                {
                    Console.Clear();
                    SecretGame();
                }
                else
                {
                    GetUserChoice();
                }

                return; 
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter a single letter as your guess.");
        }
    }

    Console.WriteLine($"Snowman: {new string(snowmanParts)}");
    Console.WriteLine("Oops! You couldn't complete the snowman. Better luck next time!");

    Console.WriteLine("Press enter to return to the main menu");
    Console.ReadLine();
    GetUserChoice();
}


static string LoadRandomWordFromFile(string filePath)
{
    try
    {
        string[] words = File.ReadAllLines(filePath);
        
        if (words.Length > 0)
        {
            Random random = new Random();
            return words[random.Next(words.Length)];
        }
        else
        {
            Console.WriteLine("The file is empty or does not contain any words.");
            return null;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading words from file: {ex.Message}");
        return null;
    }
}

static void DisplayCurrentHours()
{
Console.WriteLine();
Console.WriteLine($"You currently have: {currentHoursPasswordCracker + currentHoursFromSpin} hours");

    Console.WriteLine("Energy Bar:");
    Console.WriteLine("  _______");
    Console.WriteLine(" |       |");

    for (int i = 6; i > 0; i--)
    {
         if ((currentHoursPasswordCracker + currentHoursFromSpin) >= i)
        {
            Console.Write(" |█████| ");
        }
        else
        {
            Console.Write(" |       | ");
        }
        Console.WriteLine();
    }

    Console.WriteLine(" |_______|");

    Console.WriteLine("Press 1 to return to the menu");

    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice) || choice != 1)
    {
        Console.WriteLine("Invalid input. Please press 1 to return to the main menu.");
    }
}

}