using System;
using CoreTweet;
using kibotter_cli;

namespace kibotter_cli.Twitter
{
    class TweetClass
    {
        public Tokens Api { get; }

        public TweetClass(UserTokens ut)
        {
            try
            {
                Api = Tokens.Create(ut.ConsumerKey, ut.ConsumerSecret, ut.AccessToken, ut.AccessTokenSecret);
            }
            catch(TwitterException te)
            {
                Console.WriteLine(te);
                Environment.Exit(1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error : Failed to make Tokens.");
                Environment.Exit(1);
            }
        }

        public void Tweet(string text)
        {
            try
            {
                Api.Statuses.Update(status => text);
            }
            catch(TwitterException te)
            {
                Console.WriteLine(te);
                Environment.Exit(1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error : Failed to tweet.");
                Environment.Exit(1);
            }
        }
    }
}