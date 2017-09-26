using System;

namespace dotnetCoreReducer
{
    class Program
    {  
        static void Main(string[] args)
        {
            string currentDomain = null;
            int currentCount = 0;
            string domain = null;

            string line;
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                // We've read a string similar to "i.imgur.com    1". 
                // Let's split it into a domain and an int representign a count.
                var vals = line.Split('\t');
                domain = vals[0];
                var count = int.Parse(vals[1]);

                // MapReduce sorts all keys (in our case - the domain) before passing to the reducer.
                // This means, if the newly parsed domain matches the previously seen currentDomain, 
                // we just increase the count.
                if (domain.Equals(currentDomain))
                {
                    currentCount++;
                }
                else
                {
                    // If we've received a new domain, we'll not see the previous one again. 
                    // Output the total count of previous domain, 
                    // and switch currentDomain to the new value.
                    if (currentDomain != null)
                    {
                        Console.WriteLine($"{currentDomain}\t{currentCount}");
                    }

                    currentDomain = domain;
                    currentCount = count;
                }
            }

            // Lastly output the last domain we saw, if any
            if (!string.IsNullOrEmpty(currentDomain))
            {
                Console.WriteLine($"{currentDomain}\t{currentCount}");
            }
        }
    }
}
