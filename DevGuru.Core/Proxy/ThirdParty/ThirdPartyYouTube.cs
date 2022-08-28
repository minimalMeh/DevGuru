using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DevGuru.Core.Proxy.ThirdParty
{
    public class ThirdPartyYouTube : IYouTubeLibrary
    {
        public Dictionary<string, Video> GetPopularVideos()
        {
            Console.WriteLine("Connecting to the http://www.youtube.com/");
            Thread.Sleep(500);
            return GetRandomVideos();
        }

        public Video GetVideo(string videoId)
        {
            Thread.Sleep(600);
            Console.WriteLine("Connecting to the http://www.youtube.com/");
            return new Video(videoId, videoId.ToUpper());
        }

        private Dictionary<string, Video> GetRandomVideos()
        {
            var videos = new Dictionary<string, Video>
            {
                ["cat"] = new Video("cat", "CAT"),
                ["dog"] = new Video("dog", "DOG"),
                ["fish"] = new Video("fish", "FISH"),
                ["horse"] = new Video("horse", "HORSE"),
                ["BoJack_HorseMan"] = new Video("BoJack_HorseMan", "BOJACK HORSEMAN"),
            };
            Console.WriteLine("Finished downloading.");
            return videos;
        }
    }
}
