using System;
using System.Text;

namespace WordPressAutomation
{
    public class PostCreator
    {
        public static string PreviousTitle { get; set; }
        public static string PreviousBody { get; set; }
        private static string[] Words = new[] { "msanzi", "africa", "black", "programming", "programmer", "nonsense", "lucky", "Mandela", "Zuma", "Luther", "Modise", "Senior"};
        private static string[] Articles = new[] { "the", "an", "and", "a", "of", "to", "it", "as"};

        public static void CreatePost()
        {
            // add a new post
            NewPostPage.GoTo();

            PreviousTitle = CreateTitle();
            PreviousBody = CreateBody();

            NewPostPage.CreatePost(PreviousTitle)
                .WithBody(PreviousBody)
                .Publish();
        }

        private static string CreateBody()
        {
            return CreateRandomString() + ", body";
        }

        private static string CreateTitle()
        {
            return CreateRandomString() + ", title";
        }

        private static string CreateRandomString()
        {
            var str = new StringBuilder();

            var random = new Random();
            var cycles = random.Next(5 + 1);

            for(int i = 0; i < cycles; i++)
            {
                str.Append(Words[random.Next(Articles.Length)]);
                str.Append(" ");
                str.Append(Articles[random.Next(Articles.Length)]);
                str.Append(" ");
                str.Append(Words[random.Next(Articles.Length)]);
                str.Append(" ");
            }

            return str.ToString();

        }
    }
}