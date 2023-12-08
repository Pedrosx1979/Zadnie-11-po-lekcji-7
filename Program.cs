
using System;

Console.WriteLine("Podaj ocenę ucznia");

int rating = Int32.Parse(Console.ReadLine());

switch (rating)
{
    case 1:
        Console.WriteLine("Niedostateczny");
        break;

    case 2:
        Console.WriteLine("Dopuszczający");
        break;

    case 3:
        Console.WriteLine("Dostateczny");
        break;

    case 4:
        Console.WriteLine("Dobry");
        break;

    case 5:
        Console.WriteLine("Bardzo dobry");
        break;

    case 6:
        Console.WriteLine("Celujący");
        break;

    default:
        Console.WriteLine("To Prymus :)");
        break;

}


/*int rating = Int32.Parse(Console.ReadLine());


if (rating == 1)
{
    Console.WriteLine("Niedostateczny");
}
else if (rating == 2)
{
    Console.WriteLine("Dopuszczająca");
}
else if (rating == 3)
{
    Console.WriteLine("Dostateczna");
}
else if (rating == 4)
{
    Console.WriteLine("Dobra");
}
else if (rating == 5)
{
    Console.WriteLine("Bardzo dobra");
}
else if (rating == 6)
{
    Console.WriteLine("Celująca");
}
else
{
    Console.WriteLine("To prymus :)");
}*/



