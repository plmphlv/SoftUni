using System;
using System.Linq;

namespace _02.Articles
{
    internal class Articles
    {
        static void Main(string[] args)
        {
            string[] baseArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Article article = new Article(baseArticle[0], baseArticle[1], baseArticle[2]);

            int numOfEdits = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfEdits; i++)
            {

                string[] cmdArgs = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (cmdArgs[0])
                {
                    case "Edit":

                        article.EditContent(cmdArgs[1]);

                        break;
                    case "ChangeAuthor":

                        article.ChangeAuthor(cmdArgs[1]);

                        break;
                    case "Rename":

                        article.RenameArticle(cmdArgs[1]);

                        break;

                }

            }

            Console.WriteLine(article.ToString());
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

        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }

        public void RenameArticle(string newTitle)
        {
            Title = newTitle;
        }

        public void EditContent(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}