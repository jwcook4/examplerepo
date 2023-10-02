using System;

                //***** Main *****

class Program
{
    static string GetYesNoResponse(string question)
    {
        while (true)
        {
            Console.Write(question);
            string response = Console.ReadLine().ToLower(); // Convert to lowercase for proper case comparison

            if (response == "yes" || response == "no")
            {
                return response;
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
            }
        }
    }

                // ***** End Main *****

    
                // User Main Interface

    static void Main()
        
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Alabama TrailGuide App!");
            Console.WriteLine();
            Console.WriteLine("Please select an option (1, 2, 3, or type 'compass', 'park fees', or 'Exit'): ");
            Console.WriteLine("1. Compass");
            Console.WriteLine("2. Park Fees");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine(); 

            switch (choice)
            {
                case "1":
                case "compass":
                    NavigateWithCompass();
                    break;
                case "2":
                case "park fees":
                    CalculateParkFees();
                    break;
                case "3":
                case "exit":
                    Console.WriteLine("Exiting TrailGuide App.");
                    return;
                default:
                    Console.WriteLine("Invalid selection. Please enter a number or word corresponding to the options.");
                    Console.WriteLine();
                    break;
            }
        }
    }

             // Compass Navigation

    static void NavigateWithCompass()
{
    Console.WriteLine("Compass Functionality");

    int rightTurns;
    int leftTurns;

    // Prompt for right turns until the correct input is provided
    while (true)
    {
        Console.Write("Enter the number of right turns: ");
        string rightTurnsInput = Console.ReadLine();

        if (int.TryParse(rightTurnsInput, out rightTurns))
        {
            break; // Input is correct, exit the loop
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of right turns.");
        }
    }

    // Prompt for left turns until the correct input is provided
    while (true)
    {
        Console.Write("Enter the number of left turns: ");
        string leftTurnsInput = Console.ReadLine();

        if (int.TryParse(leftTurnsInput, out leftTurns))
        {
            break; // Input is correct, exit the loop
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of left turns.");
        }
    }

   int orientation = (rightTurns - leftTurns) % 4;
if (orientation < 0)
    orientation += 4;

string facingDirection = GetFacingDirection(orientation);

Console.WriteLine($"You are facing {facingDirection}.");
    Console.WriteLine();
}
static string GetFacingDirection(int orientation)
{
    switch (orientation)
    {
        case 0:
            return "North";
        case 1:
            return "East";
        case 2:
            return "South";
        case 3:
            return "West";
        default:
            throw new InvalidOperationException("Invalid orientation value.");
    }
}


            // Fees and Calculations
    
    static void CalculateParkFees()
{
    try
    {
        Console.WriteLine("Park Fees Functionality");

        string vehicleType = GetYesNoResponse("Are you driving an RV? (yes/no): ");

        // Declare and initialize the fee variable
        double fee = 0.0;

        // Determine base fee based on vehicle type
        if (vehicleType == "yes")
        {
            fee = 20.0; // RV base fee
        }
        else
        {
            fee = 10.0; // Non-RV base fee
        }

        Console.Write("Enter the number of attendees: ");
        int numberOfAttendees = int.Parse(Console.ReadLine());

        if (numberOfAttendees >= 6)
        {
            fee += 5.0; // Tax
            fee += (numberOfAttendees - 6) * 5.0; // Add $5.0 when it increases by increments of 6
        }

        Console.Write("How many children are in the group?: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        if (numberOfChildren > 0)
        {
            fee *= 0.8; // 20% discount on child tickets
        }

        double federalTax = fee * 0.09; // 9% federal tax

        double totalAmountDue = fee + federalTax;

        Console.WriteLine($"Total amount due: ${totalAmountDue:F2}");

        Console.Write("Enter the amount paid: ");
        double amountPaid = double.Parse(Console.ReadLine());

        if (amountPaid < totalAmountDue)
        {
            Console.WriteLine("Insufficient payment. Please pay the full amount.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Payment successful. Enjoy your visit to the park!");
            Console.WriteLine(new string('-', 35));
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}
}
     
