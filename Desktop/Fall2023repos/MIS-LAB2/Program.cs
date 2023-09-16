// Main

string season = GetSeason();

string message = FavoriteSeasonMessage(season);

Console.WriteLine(message);

// End Main

static string GetSeason()
{
    Console.WriteLine("Enter the current season (Spring, Fall, or Winter)");
    string userInput = Console.ReadLine();
    return(userInput);
}



    static string FavoriteSeasonMessage(string season)
    {
        string message;
        
        if (season == "Fall")
    
        {
            message = "Sherlenthia's favorite season is Fall!!!";
        }
        else if (season == "Winter")
        {
            message = "Manav's favorite season is Winter!";
        }
        else 
        {
            message = "It is not a TA's favorite season, you are alone";
        }
         return message;
    }
