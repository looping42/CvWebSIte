using System;
using static System.Net.Mime.MediaTypeNames;

namespace CvSite.Models
{
    public class Articles
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Uri Url { get; set; }

        public Uri UrlToImage { get; set; }

        public DateTime PublishedAt { get; set; }

        //        "source": {
        //"id": "google-news",
        //"name": "Google News"
        //},
        //"author": "Chris Quinn",
        //"title": "Police: Man shoots, kills mother of three Sunday morning; flees with their 2-year-old son",
        //"description": null,
        //"url": "https://www.mysanantonio.com/news/local/crime/article/Police-Man-shoots-kills-mother-of-three-Sunday-12513309.php",
        //"urlToImage": "https://s.hdnux.com/photos/70/72/31/14919237/3/rawImage.jpg",
        //"publishedAt": "2018-01-21T17:58:25+00:00"
    }
}