using DevGuru.Patterns.Proxy.ThirdParty;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevGuru.Patterns.Proxy
{
    public class YouTubeCacheProxy : IYouTubeLibrary
    {
        private readonly Lazy<ThirdPartyYouTube> youTubeLazy = new();
        private ThirdPartyYouTube YouTubeConnector => youTubeLazy.Value;

        private readonly Dictionary<string, Video> cacheAllVideos = new();
        private Dictionary<string, Video> cachePopularVideos = new();

        public Dictionary<string, Video> GetPopularVideos()
        {
            if (!cachePopularVideos.Any())
            {
                cachePopularVideos = YouTubeConnector.GetPopularVideos();
            }
            else
            {
                Console.WriteLine($"_cache_ : {nameof(cachePopularVideos).ToUpper()}");
            }

            return cachePopularVideos;
        }

        public Video GetVideo(string videoId)
        {
            if (cacheAllVideos.ContainsKey(videoId))
            {
                Console.WriteLine($"_cache_ : {videoId}, {nameof(cacheAllVideos).ToUpper()}");
                return cacheAllVideos[videoId];
            }
            else if (cachePopularVideos.ContainsKey(videoId))
            {
                Console.WriteLine($"_cache_ : {videoId}, {nameof(cachePopularVideos).ToUpper()}");
                return cachePopularVideos[videoId];
            }
            else
            {
                var video = YouTubeConnector.GetVideo(videoId);
                cacheAllVideos[videoId] = video;
                return video;
            }
        }

        public void Reset()
        {
            Console.WriteLine("_cache_ reset...");
            cachePopularVideos.Clear();
            cacheAllVideos.Clear();
        }
    }
}
