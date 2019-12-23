using System;

namespace deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
            string vacationType = Console.ReadLine();
            string destination;
            if (vacationType == "musical")
            {
                destination = "New Orleans";
            }
            else if (vacationType == "tropical")
            {
                destination = " a beach vacation in Mexico";
            }
            else
            {
                destination = "a whitewater rafting trip at the Grand Canyon";
            }


            Console.WriteLine("How many are in your group?");
            int groupSize = int.Parse(Console.ReadLine());
            string travelSuggestion;
            
            if (groupSize >= 1 && groupSize <= 2)
            {
                travelSuggestion = "first class flight";
            }
            else if (groupSize >= 3 && groupSize <= 5)
            {
                travelSuggestion = "helicopter ride";
            }
            else
            {
                travelSuggestion = "charter flight";
            }


            string result = $"Since you’re a group of {groupSize} going on a {vacationType} trip, you should take a {travelSuggestion} to {destination}";

            Console.WriteLine(result);
        }
    }
}
