decimal stake = 0.00m;
decimal eur = 0.00m;
decimal amerPostive = 0.00m;
decimal amerNegative = 0.00m;
decimal brit = 0.00m;
decimal britNum = 0.00m;
decimal britDenom = 0.00m;
decimal winnings = 0.00m;
decimal payout = 0.00m;



Console.WriteLine("Wellcome To Sports Betting Calculator!");
Console.WriteLine("--------------------------------------\n");

Console.WriteLine("What is your stake? Type then press Enter");
stake = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("What is your odds type?");
Console.WriteLine("Choose from the list below:");
Console.WriteLine("\te - European/Decimal odds");
Console.WriteLine("\tap - American/Money Line Postive odds");
Console.WriteLine("\tan - American/Money Line Negative odds");
Console.WriteLine("\tb - British/Fractional odds");
Console.WriteLine("Your type:");

switch (Console.ReadLine())
{
    case "e":
       
        Console.WriteLine("What are your odds?");
        eur = Convert.ToDecimal(Console.ReadLine());
        winnings = eur * stake;
        Console.WriteLine("Winnings = $" + (stake * eur));
        payout = winnings + stake;
        Console.WriteLine("Payout = $" + payout);
        break;


    case "ap":
        Console.WriteLine("What are your odds?");
        amerPostive = Convert.ToDecimal(Console.ReadLine());
        amerPostive = amerPostive / 100;
        winnings = amerPostive * stake;
        Console.WriteLine("Winnings = $" + (stake * amerPostive));
        payout = winnings + stake; 
        Console.WriteLine("Payout = $" + payout);
        break;

    case "an":
        Console.WriteLine("What are your odds?");
        amerNegative = Convert.ToDecimal(Console.ReadLine());
        amerNegative = 100 / (amerNegative * -1);
        winnings = stake * amerNegative;
        Console.WriteLine("Winnings = $" + winnings);
        payout = winnings + stake;
        Console.WriteLine("Payout = $" + payout);
        break;

    case "b":
        Console.WriteLine("What are your odds?");
        Console.WriteLine("Enter Numerator");
        britNum = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter Denominator");
        britDenom = Convert.ToDecimal(Console.ReadLine());
        brit = britNum / britDenom;
        winnings = brit * stake;
        Console.WriteLine("Winnings = $" + (stake * brit));
        payout = winnings + stake;
        Console.WriteLine("Payout = $" + payout);
        break;
    
    default:
        Console.WriteLine("Oops");
        break;
}


