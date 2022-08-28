using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Proxy.ThirdParty
{
    public interface IYouTubeLibrary
    {
        Dictionary<string, Video> GetPopularVideos();

        Video GetVideo(string videoId);
    }
}
