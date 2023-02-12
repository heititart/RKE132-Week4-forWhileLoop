Random rnd = new Random();

int myRandomNum = rnd.Next(0, 10);
int RandomSum = 0;

for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 10);
    RandomSum = RandomSum + myRandomNum;
    Console.WriteLine($" My random number is: {myRandomNum}");

}

Console.WriteLine($"Final total {RandomSum}");