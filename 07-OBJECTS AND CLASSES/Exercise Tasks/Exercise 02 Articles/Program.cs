using System;

class Program
{
    static void Main()
    {
        string[] article = Console.ReadLine().Split(", ");
        int numberOfCommands = int.Parse(Console.ReadLine());
        Article myArticle = new Article(article[0], article[1], article[2]);

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] command = Console.ReadLine().Split(": ");
            string operation = command[0].ToLower();
            string text = command[1];

            switch (operation)
            {
                case "edit":
                    myArticle.Edit(text);
                    break;
                case "changeauthor":
                    myArticle.ChangeAuthor(text);
                    break;
                case "rename":
                    myArticle.Rename(text);
                    break;
            }

        }
        Console.WriteLine(myArticle);

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

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}