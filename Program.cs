// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;

class Program
{
    static void Main()
    {

        double speakingMark, readingMark, writingMark, listeningMark;

        Console.Clear();
        Console.Write("Speaking ballarini kiriting: ");
        speakingMark = Convert.ToDouble(Console.ReadLine());

        Console.Write("Reading ballarini kiriting: ");
        readingMark = Convert.ToDouble(Console.ReadLine());

        Console.Write("Writing ballarini kiriting: ");
        writingMark = Convert.ToDouble(Console.ReadLine());

        Console.Write("Listening ballarini kiriting: ");
        listeningMark = Convert.ToDouble(Console.ReadLine());

        double totalMarks = speakingMark + readingMark + writingMark + listeningMark;

        double averageMark = totalMarks / 4;

        Console.WriteLine($"Ortacha bal: {averageMark}");

        Console.Write("Davom etasizmi? (yes/no): ");
        string continueInput = Console.ReadLine();

        if (continueInput.ToLower() == "yes")
        {
            Main();
        }
        else if (continueInput.ToLower() == "no")
        {
            Console.WriteLine("Dastur to'xtatildi.");
        }
        else
        {
            Console.WriteLine("error!!");
        }
    }
}