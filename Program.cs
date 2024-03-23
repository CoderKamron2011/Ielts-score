using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        bool isContinue = true;
        do
        {
            double speakingMark, readingMark, writingMark, listeningMark;

            Console.Clear();
            Console.Write("Inter your listening score: ");
            speakingMark = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inter your reading score: ");
            readingMark = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inter your writing score: ");
            writingMark = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inter your speking score: ");
            listeningMark = Convert.ToDouble(Console.ReadLine());


            double totalMarks = speakingMark + readingMark + writingMark + listeningMark;


            double averageMark = totalMarks / 4;

            if (5 <= averageMark && averageMark <= 6)
            {
                if (averageMark == 5)
                {
                    Console.WriteLine("Modest 5");
                }
                if (5 < averageMark && averageMark <= 5.5)
                {
                    Console.WriteLine("Modest 5.5");
                }
                if (5.5 < averageMark && averageMark <= 6)
                {
                    Console.WriteLine("Competent 6");
                }
            }
            if (6 <= averageMark && averageMark <= 7)
            {
                if (averageMark == 6)
                {
                    Console.WriteLine("Competent 6");
                }
                if (6 < averageMark && averageMark <= 6.5)
                {
                    Console.WriteLine("Competent 6.5");
                }
                if (6.5 < averageMark && averageMark <= 7)
                {
                    Console.WriteLine("Good 7");
                }
            }
            if (7 <= averageMark && averageMark < 8)
            {
                if (averageMark == 7)
                {
                    Console.WriteLine("Good 7");
                }
                if (7 < averageMark && averageMark <= 7.5)
                {
                    Console.WriteLine("Good 7.5");
                }
                if (7.5 < averageMark && averageMark <= 8)
                {
                    Console.WriteLine("Excelent: 8");
                }
            }
            if (8 <= averageMark && averageMark <= 9)
            {
                if (averageMark == 8)
                {
                    Console.WriteLine("Excelent: 8");
                }
                if (8 < averageMark && averageMark <= 8.5)
                {
                    Console.WriteLine("Excelent: 8.5");
                }
                if (8.5 < averageMark && averageMark <= 9)
                {
                    Console.WriteLine("Expert 9.0");
                }
            }

            Console.Write("Is continue(yes / no): ");
            string command = Console.ReadLine();

            if (command.ToLower().Contains("no") is true)
            {
                isContinue = false;
            }
        } while (isContinue is true);

    }
}