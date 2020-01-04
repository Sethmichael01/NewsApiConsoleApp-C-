using System;
using System.Net;

namespace NewsApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://newsapi.org/v2/top-headlines?" +
          "country=us&" +
          "apiKey=27e5ee2f6d704aaa8be077730cd1d85c";
            var json = new WebClient().DownloadString(url);
            Console.WriteLine(json);
        }
    }
}
