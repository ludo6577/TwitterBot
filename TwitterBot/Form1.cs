using System;
using System.Windows.Forms;
using TweetSharp;

namespace TwitterBot
{
    public partial class Form1 : Form
    {
        private static string DefaultConsumerKey = "??";
        private static string DefaultConsumerSecret = "??";

        private static string DefaultAccessToken = "??-??";
        private static string DefaultAccessTokenSecret = "??????";

        public Form1()
        {
            InitializeComponent();
            ConsumerKey.Text = DefaultConsumerKey;
            ConsumerSecret.Text = DefaultConsumerSecret;
            TwitterAccessToken.Text = DefaultAccessToken;
            TwitterAccessTokenSecret.Text = DefaultAccessTokenSecret;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Connect(ConsumerKey.Text, ConsumerSecret.Text, TwitterAccessToken.Text, TwitterAccessTokenSecret.Text);
        }

        private void buttonUnfollow_Click(object sender, EventArgs e)
        {
        }

        private void Log(string text)
        {
            StatusTextBox.Text += text + Environment.NewLine;
        }

        private void Connect(string consumerKey, string consumerSecret, string accessToken, string accessTokenSecret)
        {
            // In v1.1, all API calls require authentication
            var service = new TwitterService(consumerKey, consumerSecret);
            service.AuthenticateWith(accessToken, accessTokenSecret);

            Log("Connected");

            TwitterRateLimitStatusSummary rate = service.GetRateLimitStatus(new GetRateLimitStatusOptions());

            Log("Limimte rate: " + rate.RawSource);

            var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());
            foreach (var tweet in tweets)
            {
                Console.WriteLine("{0} says '{1}'", tweet.User.ScreenName, tweet.Text);
            }

            TwitterCursorList<TwitterUser> friends = service.ListFollowers(new ListFollowersOptions());

            Log("Friends: " + friends.Count);

            foreach (var friend in friends)
            {
                Log(String.Format("Friend: {0}", friend.Name));
            }
        }
    }
}
