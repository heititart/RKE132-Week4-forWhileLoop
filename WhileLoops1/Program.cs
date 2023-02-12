
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool = true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine($"cpu has generated {cpuRandom}");
    Console.WriteLine("Make a quess. Eneter a number 1-3:");
    int userNumber = Int32.Parse(Console.ReadLine()); //Convert.ToInt32(Console.ReadLine());


    if (userNumber == cpuRandom) 
    {
        Console.WriteLine("Corect you guessed right");
        //loopActive = false;
        break;
    }

    else
    {
        Console.WriteLine("oops try again!");

    }



}

Console.WriteLine("Have a nice day!");
