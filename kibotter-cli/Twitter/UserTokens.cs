namespace kibotter_cli.Twitter
{
    internal class UserTokens
    {
        public string ConsumerKey { get; }
        public string ConsumerSecret { get; }
        public string AccessToken { get; }
        public string AccessTokenSecret { get; }

        public UserTokens(string ck, string cs, string at, string ats)
        {
            ConsumerKey = ck;
            ConsumerSecret = cs;
            AccessToken = at;
            AccessTokenSecret = ats;
        }
    }
}