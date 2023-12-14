using System;
using System.Linq;

namespace DevGuru.Patterns.Proxy.ThirdParty
{
    public class Video
    {
        private static Random random = new Random();

        public string Id { get; }

        public string Title { get; }

        public string Data { get; } // imitation of byte array of the video

        public Video(string id, string title)
        {
            Id = id;
            Title = title;
            Data = $"Random video content: {GetRandomString()}";
        }

        private string GetRandomString()
        {
            int length = 10;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public override string ToString()
        {
            return $"\tVideo {Title} with Id {Id}:\n\t*{Data}*\n";
        }
    }
}
