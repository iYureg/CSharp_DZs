int randomNumber = new Random().Next(0, 101);


for (int i = 0; i <= randomNumber; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Четное число: " + i);
    }

    
}
