namespace Homework 
{
    class NumberStats
    {
        public static void Main(string[] args)
        {
            //Prompt user for a number which decides how many entries there are, store in entries variable
            Console.WriteLine("Welcome to number stats! How many entries do you wish to enter?");

            int numEntries = 0;

            while(true)
            {
                try
                {
                    numEntries = Convert.ToInt32(Console.ReadLine());

                    if(numEntries >= 0)
                    {
                       break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive integer");
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter a positive integer");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Please enter a positive integer");
                }
            }


            //Output to the user how many expected entries there are
            Console.WriteLine("Expecting " + numEntries + " numbers");

            double sum = 0;
            var numZeros = 0;
            var numPositives = 0;
            var numNegatives = 0;

            for (int i = 0; i < numEntries; i++)
            {

                int entry = 0;

                while(true)
                {
                    try
                    {
                        entry = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Please enter an integer");
                    }
                    catch(OverflowException)
                    {
                        Console.WriteLine("Please enter an integer");
                    }
                }

                sum += entry;

                if(entry == 0)
                {
                    numZeros++;
                }
                else if(entry > 0)
                {
                    numPositives++;
                }
                else
                {
                    numNegatives++;
                }
            }

            double avg = sum / numEntries;

            if(numEntries == 0)
            {
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine("The sum of all numbers entered:" + sum);
                Console.WriteLine("The average of all numbers entered:" + avg);
                Console.WriteLine("The number of zeros entered:" + numZeros);
                Console.WriteLine("The number of positive numbers entered:" + numPositives);
                Console.WriteLine("The number of negative numbers entered:" + numNegatives);
                Console.WriteLine("Done!");
            }
            

        }
    }
}