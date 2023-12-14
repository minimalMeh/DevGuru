using DevGuru.Patterns.Proxy.ThirdParty;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevGuru.Patterns.Proxy
{
    public class YouTubeCacheProxy : IYouTubeLibrary
    {
        private readonly Lazy<ThirdPartyYouTube> youTubeLazy = new Lazy<ThirdPartyYouTube>();
        private ThirdPartyYouTube YouTubeLib => youTubeLazy.Value;

        private readonly Dictionary<string, Video> cacheAllVideos = new Dictionary<string, Video>();
        private Dictionary<string, Video> cachePopularVideos = new Dictionary<string, Video>();

        private const string CACHE_MASK = "CACHE: ";

        public Dictionary<string, Video> GetPopularVideos()
        {
            if (!cachePopularVideos.Any())
            {
                cachePopularVideos = YouTubeLib.GetPopularVideos();
            }
            else
            {
                Console.WriteLine(CACHE_MASK + "Retrieved popular from cache.");
            }

            return cachePopularVideos;
        }

        public Video GetVideo(string videoId)
        {
            if (cacheAllVideos.ContainsKey(videoId))
            {
                Console.WriteLine(CACHE_MASK + "Returned from all videos cache.");
                return cacheAllVideos[videoId];
            }
            else if (cachePopularVideos.ContainsKey(videoId))
            {
                Console.WriteLine(CACHE_MASK + "Returned from popular videos cache.");
                return cachePopularVideos[videoId];
            }
            else
            {
                var video = YouTubeLib.GetVideo(videoId);
                cacheAllVideos[videoId] = video;
                return video;
            }
        }

        public void Reset()
        {
            cachePopularVideos.Clear();
            cacheAllVideos.Clear();
        }
    }
}
