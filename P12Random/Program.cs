Console.Write("Please give me a seed hihi: ");
int seed = int.Parse(Console.ReadLine());

Random random = new Random(seed);

Console.WriteLine("Random Numbers between 0 and 5 (inclusive):");
for (int i = 0; i < 3; i++)
{
    int random1 = random.Next(0, 5);
    Console.WriteLine(random1);
}

Console.WriteLine("\nRandom Numbers between 0 and 0.5 (inclusive):");
for (int i = 0; i < 3; i++)
{
    double random2 = random.NextDouble() * 0.5;
    Console.WriteLine(random2);
}



