﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace DevGuru.Patterns.Proxy.ThirdParty
{
    public class ThirdPartyYouTube : IYouTubeLibrary
    {
        public Dictionary<string, Video> GetPopularVideos()
        {
            Console.WriteLine($"{nameof(GetPopularVideos)}: Connecting to the http://www.youtube.com/ ...");
            Thread.Sleep(200);
            return GetRandomVideos();
        }

        public Video GetVideo(string videoId)
        {
            Console.WriteLine($"{nameof(GetVideo)} \"{videoId}\": Connecting to the http://www.youtube.com/ ...");
            Thread.Sleep(100);
            return new Video(videoId, videoId.ToUpper());
        }

        private static Dictionary<string, Video> GetRandomVideos()
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
