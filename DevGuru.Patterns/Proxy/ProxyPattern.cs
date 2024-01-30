using DevGuru.Core;
using DevGuru.Patterns.Proxy;
using System;
using System.Linq;

namespace DevGuru.Patterns
{
    public class ProxyPattern : PatternBase
    {
        public override string Name => "Proxy";
        protected override string DescriptionFormatted => "\t[Controls access to an object by serving as a surrogate or placeholder,]\n\t[enabling additional functionality such as lazy loading, access control, or logging.]\n";
        protected override string IdeaFormatted => "\t[The third party YouTube library is responsible for videos downloading.]\n\t[YouTubeCacheProxy provides caching mechanism over the library.]\n";

        protected override void RunCore()
        {
            var proxy = new YouTubeCacheProxy();
            proxy.GetPopularVideos().Values.ToList().ForEach(Console.WriteLine);
            proxy.GetPopularVideos().Values.ToList().ForEach(Console.WriteLine);

            var video = proxy.GetVideo("turtle");
            Console.WriteLine(video);

            video = proxy.GetVideo("cat");
            Console.WriteLine(video);

            video = proxy.GetVideo("dog1");
            Console.WriteLine(video);

            video = proxy.GetVideo("dog");
            Console.WriteLine(video);

            video = proxy.GetVideo("turtle");
            Console.WriteLine(video);

            proxy.Reset();

            video = proxy.GetVideo("dog");
            Console.WriteLine(video);

            video = proxy.GetVideo("turtle");
            Console.WriteLine(video);
        }
    }
}
