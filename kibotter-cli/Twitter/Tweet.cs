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
            catch
            {
                throw new Exception("Error : Failed to make Tokens.");
            }
        }

        public void Tweet(string text)
        {
            try
            {
                Api.Statuses.Update(status => text);
            }
            catch
            {
                throw new Exception("Error : Failed to tweet.");
            }
        }
    }
}