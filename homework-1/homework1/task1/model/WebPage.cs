

using task1.interfaces;

namespace task1.model
{
    public class WebPage : ISearchable
    {
        public string Url {get; set;}
        public string HtmlContent {get; set;}
        
        public WebPage(string url, string htmlContent)
        {
            Url = url;
            HtmlContent = htmlContent;
        }
        public bool Search(string word)
        {
            Console.WriteLine($"Scanning web source {Url} for {word}...");
            return HtmlContent.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
