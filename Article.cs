using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCArticleScraper
{
    public class Article
    {
        public string URL { get; set; }
        public string Title { get; set; }
        public string DatePosted { get; set; }
        public string ArticleText { get; set; }
    }
}
