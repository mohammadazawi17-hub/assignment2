Console.WriteLine("Enter a month number (1 - 12):");
string month = Console.ReadLine();

switch (month)
{
    case "4":
    case "6":
    case "9":
    case "11":
        Console.WriteLine("30");

        break;

    case "1":
    case "3":
    case "5":
    case "7":
    case "8":
    case "10":
    case "12":
        Console.WriteLine("31");

        break;
    case "2":
        Console.WriteLine("28");
           break;
    default:
        Console.WriteLine("Invalid input");
        break;



}