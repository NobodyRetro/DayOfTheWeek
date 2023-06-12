Console.WriteLine("What day is it based on the number I am given? (1-7)");
var DayNumber = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
switch (DayNumber)
{
    case 1:
        Console.WriteLine(" The day is Monday.");
        break;
    case 2:
        Console.WriteLine(" The day is Tuesday.");
        break;
    case 3:
        Console.WriteLine(" The day is Wednesday.");
        break;
    case 4:
        Console.WriteLine(" The day is Thursday.");
        break;
    case 5:
        Console.WriteLine(" The day is Friday.");
        break;
    case 6:
        Console.WriteLine(" The day is Saturday.");
        break;
    case 7:
        Console.WriteLine(" The day is Sunday.");
        break;
    default:
        Console.WriteLine(" Invalid Input");
        break;
}
Console.WriteLine("Press any key to exit.");
Console.ReadKey();