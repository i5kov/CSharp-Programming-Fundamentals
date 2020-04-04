using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int numberOfArticles = int.Parse(Console.ReadLine());
        List<Article> articles = new List<Article>();

        for (int i = 0; i < numberOfArticles; i++)
        {
            string[] article = Console.ReadLine().Split(", ");
            string articleTitle = article[0];
            string articleContent = article[1];
            string articleAuthor = article[2];

            articles.Add(new Article(articleTitle, articleContent, articleAuthor));
        }

        string filterBy = Console.ReadLine().ToLower();

        switch (filterBy)
        {
            case "title":
                articles.OrderBy(x => x.Title).ToList().ForEach(x => Console.WriteLine(x));
                break;
            case "content":
                articles.OrderBy(x => x.Content).ToList().ForEach(x => Console.WriteLine(x));
                break;
            case "author":
                articles.OrderBy(x => x.Author).ToList().ForEach(x => Console.WriteLine(x));
                break;
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}