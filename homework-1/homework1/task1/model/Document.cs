

using task1.interfaces;

namespace task1.model
{
    public class Document : ISearchable
    {
        public string Title {get; set;}
        public string Content {get; set;}

        public Document(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public bool Search(string word)
        {
            Console.WriteLine($"Searching for {word} in document: {Title} ");
            return Content.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
