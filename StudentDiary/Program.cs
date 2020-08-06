using System;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.Average();
            //float max = diary.MaxRating();
            //float min = diary.MinRating();


            for (; ; )
            {
                Console.WriteLine("Podaj ocenę: ");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 555)
                {
                    break;
                }

                if (result) // = result == true
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba! Podaj liczbę z zakresu 1 - 10");
                    }
                    
                }

            }

            Console.WriteLine("Średnia ocen to: " + diary.Average());
            Console.WriteLine("Najwyższa ocena to: " + diary.MaxRating());
            Console.WriteLine("Najniższa ocena to: " + diary.MinRating());
            Console.ReadKey();

            Diary diary2 = new Diary();
            Diary diary3 = new Diary();

        }
    }
}
