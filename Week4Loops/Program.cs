// See FOR-LOOP
// Dry principle -  do not reapeat yourself.

Console.WriteLine("kas sulle meeldib õppida y/n");
char õppida = Convert.ToChar(Console.ReadLine());

if (õppida == 'y')
{
    Console.WriteLine("Tubli laps, võta kommi!");
}

else if (õppida == 'n')
{
    Console.WriteLine("Hinda 10 palli süsteemis, kui palju sulle ei meeldi õppida:");
    int lauseKordaja = Convert.ToInt32(Console.ReadLine());

    int i = 0;

    for (i = 0; i < lauseKordaja; i++)
    {
        Console.WriteLine("Sa pead õppima!");

    }

    Console.WriteLine(i);
}


else 
{
    Console.WriteLine("Sisestasid tundmatu väärtuse, õpi lugema!");
}

