namespace dotnetCoreMapper
{
    using System;

    using Newtonsoft.Json;

    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                var post = JsonConvert.DeserializeObject<Models.RedditPost>(line);

                // Write the domain and count, separated by a tab, to stdout
                // e.g. "i.imgur.com    1".
                Console.WriteLine($"{post.Data.Domain}\t1");
            }
        }
    }
}
