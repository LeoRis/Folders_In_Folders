using System;

namespace DifferentBasic
{
    public class Seasons
    {
        public string _month;

        public DateTime _date;

        public void CheckSeason(string month)
        {
            month.ToLower();
            switch (month)
            {
                case "january":
                case "february":
                case "march":
                    {
                        Console.WriteLine("It's winter.");
                    }
                    break;
                case "april":
                case "may":
                case "june":
                    {
                        Console.WriteLine("It's spring.");
                    }
                    break;
                case "july":
                case "august":
                case "september":
                    {
                        Console.WriteLine("It's summer.");
                    }
                    break;
                case "october":
                case "november":
                case "december":
                    {
                        Console.WriteLine("It's autumn.");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong season");
                    break;
            }
        }
    }
}
