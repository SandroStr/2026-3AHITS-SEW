class Programm
{

    static int GetNote(int punkte)
{
    if (punkte >= 21)
        return 1;
    else if (punkte >= 18)
        return 2;
    else if (punkte >= 15)
        return 3;
    else if (punkte >= 12)
        return 4;
    else
        return 5;
}

static string GetNoteText(int note)
{
    if (note == 1)
        return "sehr gut";
    else if (note == 2)
        return "gut";
    else if (note == 3)
        return "befriedigend";
    else if (note == 4)
        return "genügend";
    else
        return "nicht genügend";
}


    static void Main()
    {
        string[] namen = { "Mayer", "Huber", "Gruber" };
        int[] punkte = { 21, 18, 15 };

        for (int i = 0; i < namen.Length; i++)
        {
            int note = GetNote(punkte[i]);
            Console.WriteLine($"{namen[i]} - {note} ({GetNoteText(note)})");
        }
    }

}

/* Ohne 2 Methoden
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
*/