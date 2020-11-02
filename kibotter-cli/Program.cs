using System;
using kibotter_cli.Twitter;

namespace kibotter_cli
{
    class Program
    {
        // for Windows
        static UserTokens LoadEnvVariable()
        {
            string consumerKey = Environment.GetEnvironmentVariable("KIBOTTER_CK", System.EnvironmentVariableTarget.User);
            string consumerSecret = Environment.GetEnvironmentVariable("KIBOTTER_CS", System.EnvironmentVariableTarget.User);
            string accessToken = Environment.GetEnvironmentVariable("KIBOTTER_AT", System.EnvironmentVariableTarget.User);
            string accessTokenSecret = Environment.GetEnvironmentVariable("KIBOTTER_AS", System.EnvironmentVariableTarget.User);

            return new UserTokens(consumerKey, consumerSecret, accessToken, accessTokenSecret);
        }
        // end
        
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Error : Can't tweet the void. (need 1 argment, ex. \"Hello World!\", to tweet)");
                return;
            }
            string text = args[0];

            UserTokens ut = LoadEnvVariable();
            TweetClass tc = new TweetClass(ut);
            tc.Tweet(text);
            Console.WriteLine($"tweeted : {text}");
        }
    }
}
