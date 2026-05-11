// See https://aka.ms/new-console-template for more information
using task1.interfaces;
using task1.model;


Console.WriteLine("Hello, World!");

task1.model.Document myDoc = new task1.model.Document("Resume.pdf", "Experienced C# developer with a passion for clean code.");

WebPage myPage = new WebPage("https://example.com", "<html><body>Welcome to the tech blog!</body></html>");

List<ISearchable> searchibleItems = new List<ISearchable> {myDoc, myPage};

string query = "tech";

foreach(var item in searchibleItems)
{
    bool found = item.Search(query);
    Console.WriteLine(found ? "Result: Match found!\n" : "Result: No match.\n");
}
