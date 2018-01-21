using System.Collections.Generic;

namespace CvSite.Models
{
    public class GoogleNews
    {
        public string Status { get; set; }

        public int TotalResults { get; set; }

        public List<Articles> articles { get; set; }
    }
}