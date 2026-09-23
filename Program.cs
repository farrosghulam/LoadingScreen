int totalSteps = 15;

for (int step = 1; step <= totalSteps; step++)
{
    Console.WriteLine($"Loading... Step {step} of {totalSteps}");
    if (step % 3 == 0)
    {
        Console.WriteLine("\nCheckpoint reached!\n");
    }
}

Console.WriteLine("\nDungeon is ready. Enter now!");