string[] namen = {"Mayer","Huber","Gruber"};
int[] punkte = {21,18,15};


for (int i = 0; i < namen.Length; i++)
{
    if (punkte[i] >= 21)
        Console.WriteLine($"{namen[i]} - 1 (sehr gut)");
    else if (punkte[i] >= 18)
        Console.WriteLine($"{namen[i]} - 2 (gut)");
    else if (punkte[i] >= 15)
        Console.WriteLine($"{namen[i]} - 3 (befriedigend)");
    else if (punkte[i] >= 12)
        Console.WriteLine($"{namen[i]} - 4 (genügend)");
    else
        Console.WriteLine($"{namen[i]} - 5 (nicht genügend)");
}