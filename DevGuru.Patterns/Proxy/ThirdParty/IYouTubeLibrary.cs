using System.Collections.Generic;

namespace DevGuru.Patterns.Proxy.ThirdParty
{
    public interface IYouTubeLibrary
    {
        Dictionary<string, Video> GetPopularVideos();
        Video GetVideo(string videoId);
    }
}
