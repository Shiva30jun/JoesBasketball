using System;



namespace JoesBasketball


{
    class Games


    {
        static void Main()
        {

            Console.WriteLine("Number of Purple tickets:");
            int purpleTickets = int.Parse(Console.ReadLine());

            if (purpleTickets <= 0) // The input of number purple tickets should be positive not negative
            {
                Console.WriteLine("Invalid input. Please must enter a positive number.");
                return;
            }



            Console.WriteLine("Number of Green tickets:");
            int greenTickets = int.Parse(Console.ReadLine());

            if (greenTickets <= 0) // The input of number green tickets should be positive not negative
            {
                Console.WriteLine("Invalid input. Please must enter a positive number.");
                return;
            }


            Console.WriteLine("Number of Blue tickets:");
            int blueTickets = int.Parse(Console.ReadLine());

            if (blueTickets <= 0) // The input of number blue tickets should be positive not negative
            {
                Console.WriteLine("Invalid input. Please must enter a positive number.");
                return;
            }


            // Cost of each ticket according to each colour seat
            int purpleticketPrice = 50;
            int greenticketPrice = 80;
            int blueticketPrice = 100;


            int totalCost = (purpleTickets * purpleticketPrice) + (greenTickets * greenticketPrice) + (blueTickets * blueticketPrice);


            int totalTickets = purpleTickets + greenTickets + blueTickets;
            int averageCost = totalCost / totalTickets;


            // Showing results
            Console.WriteLine("Total money spent is: $" + totalCost);
            Console.WriteLine("Average cost per each game is: $" + averageCost);




            Console.ReadLine();
        }
    }
}
