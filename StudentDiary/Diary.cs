using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        // Stan (zmienne - pola)
        List<float> ratings;

        // Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float Average()
        {
            float sum = 0;
            float avg = 0;
            foreach (var rate in ratings)
	        {
                sum += rate;
	        }
            avg = sum / ratings.Count();
            return avg;
        }

        public float MaxRating()
        {
            return ratings.Max();
        }

        public float MinRating()
        {
            return ratings.Min();
        }
    }
}
