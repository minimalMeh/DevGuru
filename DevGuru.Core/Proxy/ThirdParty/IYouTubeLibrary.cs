using System.Collections.Generic;

namespace DevGuru.Core.Proxy.ThirdParty
{
    public interface IYouTubeLibrary
    {
        Dictionary<string, Video> GetPopularVideos();

        Video GetVideo(string videoId);
    }
}
